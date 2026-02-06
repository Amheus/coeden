using Coeden.Common;
using Coeden.Common.Enumerators;
using Coeden.Common.Settings;
using Coeden.Forms.ObjectCreators;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Coeden.Forms
{
    public partial class TreeMode : Form
    {
        private TreeProfile _currentProfile;

        public TreeMode()
        {
            InitializeComponent();
        }

        private void TreeMode_Load(object sender, EventArgs e)
        {
            RefreshProfilesList();
        }

        private void RefreshProfilesList()
        {
            listView_profiles.Items.Clear();
            treeView_cnameStructure.Nodes.Clear();

            SettingsManager.CurrentSettingsInstance = SettingsManager.GetSettings();

            foreach (var profile in SettingsManager.CurrentSettingsInstance.Profiles)
            {
                var item = new ListViewItem(profile.Name);
                item.SubItems.Add(profile.TargetType.ToString());
                item.Tag = profile;

                switch (profile.TargetType)
                {
                    case DnsTargetType.Public:
                        item.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case DnsTargetType.Local:
                        item.ForeColor = System.Drawing.Color.Green;
                        break;
                    case DnsTargetType.Both:
                        item.ForeColor = System.Drawing.Color.Purple;
                        break;
                }

                listView_profiles.Items.Add(item);
            }
        }

        private void RefreshDnsTree()
        {
            treeView_cnameStructure.Nodes.Clear();

            if (_currentProfile == null)
                return;

            foreach (var ipNode in _currentProfile.IpAddresses)
            {
                var ipTreeNode = new TreeNode($"[A] {ipNode.IpAddress}");
                ipTreeNode.Tag = ipNode;
                ipTreeNode.ForeColor = System.Drawing.Color.Blue;

                foreach (var host in ipNode.Hosts)
                {
                    AddHostNodeRecursive(ipTreeNode, host, true);
                }

                treeView_cnameStructure.Nodes.Add(ipTreeNode);
            }

            treeView_cnameStructure.ExpandAll();
        }

        private void AddHostNodeRecursive(TreeNode parentNode, HostNode hostNode, bool isARecord)
        {
            string recordType = isARecord ? "A" : "CNAME";
            var treeNode = new TreeNode($"[{recordType}] {hostNode.Hostname}");
            treeNode.Tag = hostNode;
            treeNode.ForeColor = isARecord ? System.Drawing.Color.DarkGreen : System.Drawing.Color.Purple;

            parentNode.Nodes.Add(treeNode);

            foreach (var child in hostNode.CnameChildren)
            {
                AddHostNodeRecursive(treeNode, child, false);
            }
        }

        private void listView_profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_profiles.SelectedItems.Count == 0)
            {
                _currentProfile = null;
                treeView_cnameStructure.Nodes.Clear();
                return;
            }

            _currentProfile = (TreeProfile)listView_profiles.SelectedItems[0].Tag;
            RefreshDnsTree();
        }

        private void toolStripMenu_profiles_createANewProfile_Click(object sender, EventArgs e)
        {
            var profileCreationForm = new TreeModeProfileCreator();
            if (profileCreationForm.ShowDialog() == DialogResult.OK)
            {
                var newProfile = profileCreationForm.CreatedProfile;

                SettingsManager.CurrentSettingsInstance.Profiles.Add(newProfile);
                SettingsManager.SaveSettings(SettingsManager.CurrentSettingsInstance);

                RefreshProfilesList();

                MessageBox.Show("Profile created successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenu_profiles_deleteSelectedProfile_Click(object sender, EventArgs e)
        {
            if (listView_profiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a profile to delete.", "No Profile Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProfile = (TreeProfile)listView_profiles.SelectedItems[0].Tag;

            var result = MessageBox.Show(
                $"Are you sure you want to delete the profile '{selectedProfile.Name}'?\n\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SettingsManager.CurrentSettingsInstance.Profiles.Remove(selectedProfile);
                SettingsManager.SaveSettings(SettingsManager.CurrentSettingsInstance);

                RefreshProfilesList();

                MessageBox.Show("Profile deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenu_tree_addIpAddress_Click(object sender, EventArgs e)
        {
            if (_currentProfile == null)
            {
                MessageBox.Show("Please select a profile first.", "No Profile Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var IpAddressCreator = new IpAddressCreator();
            if(IpAddressCreator.ShowDialog() == DialogResult.OK)
            {
                string ipAddress = IpAddressCreator.CreatedIpAddress;
                if (string.IsNullOrWhiteSpace(ipAddress))
                    return;

                ipAddress = ipAddress.Trim();

                if (_currentProfile.IpAddresses.Any(ip => ip.IpAddress == ipAddress))
                {
                    MessageBox.Show("This IP address already exists.", "Duplicate IP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newIpNode = new IpNode { IpAddress = ipAddress };
                _currentProfile.IpAddresses.Add(newIpNode);

                SettingsManager.SaveSettings(SettingsManager.CurrentSettingsInstance);
                RefreshDnsTree();
            }
        }

        private void toolStripMenu_tree_addHost_Click(object sender, EventArgs e)
        {
            if (_currentProfile == null)
            {
                MessageBox.Show("Please select a profile first.", "No Profile Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (treeView_cnameStructure.SelectedNode == null)
            {
                MessageBox.Show("Please select an IP address or hostname to add a child to.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hostnameCreator = new HostnameCreator();
            if (hostnameCreator.ShowDialog() == DialogResult.OK)
            {
                string hostname = hostnameCreator.CreatedHostname;

                if (string.IsNullOrWhiteSpace(hostname))
                    return;

                hostname = hostname.Trim().ToLower();

                var newHost = new HostNode { Hostname = hostname };

                var selectedTag = treeView_cnameStructure.SelectedNode.Tag;

                if (selectedTag is IpNode ipNode)
                {
                    ipNode.Hosts.Add(newHost);
                }
                else if (selectedTag is HostNode hostNode)
                {
                    hostNode.CnameChildren.Add(newHost);
                }

                SettingsManager.SaveSettings(SettingsManager.CurrentSettingsInstance);
                RefreshDnsTree();
            }

        }

        private void toolStripMenu_tree_deleteNode_Click(object sender, EventArgs e)
        {
            if (treeView_cnameStructure.SelectedNode == null)
            {
                MessageBox.Show("Please select a node to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedTag = treeView_cnameStructure.SelectedNode.Tag;
            string nodeName = "";
            bool isDeleted = false;

            if (selectedTag is IpNode ipNode)
            {
                nodeName = ipNode.IpAddress;
                var result = MessageBox.Show(
                    $"Are you sure you want to delete IP '{ipNode.IpAddress}' and all its hosts?\n\nThis action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _currentProfile.IpAddresses.Remove(ipNode);
                    isDeleted = true;
                }
            }
            else if (selectedTag is HostNode hostNode)
            {
                nodeName = hostNode.Hostname;
                var result = MessageBox.Show(
                    $"Are you sure you want to delete '{hostNode.Hostname}' and all its CNAMEs?\n\nThis action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    isDeleted = RemoveHostNodeRecursive(_currentProfile.IpAddresses, hostNode);
                }
            }

            if (isDeleted)
            {
                SettingsManager.SaveSettings(SettingsManager.CurrentSettingsInstance);
                RefreshDnsTree();
            }
        }

        private bool RemoveHostNodeRecursive(System.Collections.Generic.List<IpNode> ipNodes, HostNode hostToRemove)
        {
            foreach (var ipNode in ipNodes)
            {
                if (ipNode.Hosts.Remove(hostToRemove))
                    return true;

                foreach (var host in ipNode.Hosts)
                {
                    if (RemoveHostFromChildren(host, hostToRemove))
                        return true;
                }
            }
            return false;
        }

        private bool RemoveHostFromChildren(HostNode parent, HostNode hostToRemove)
        {
            if (parent.CnameChildren.Remove(hostToRemove))
                return true;

            foreach (var child in parent.CnameChildren)
            {
                if (RemoveHostFromChildren(child, hostToRemove))
                    return true;
            }

            return false;
        }
    }
}
