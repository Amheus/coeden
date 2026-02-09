using Coeden.Common;
using Coeden.Common.Enumerators;
using Coeden.Common.Helpers;
using Coeden.Common.Settings;
using Coeden.Common.Superclasses;
using Coeden.Forms.ObjectCreators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Coeden.Forms
{
    public partial class Dashboard : Form
    {
        private SettingsWrapper _settings;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void RefreshConnectionsList()
        {
            listView_registrars.Items.Clear();
            _settings = SettingsManager.GetSettings();

            foreach (var connection in _settings.Connections)
            {
                var item = new ListViewItem(connection.Name);
                item.Tag = connection;
                item.SubItems.Add(connection.Note);
                this.listView_registrars.Items.Add(item);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            RefreshConnectionsList();
        }

        private void toolStripMenu_connections_createANewConnection_Click(object sender, EventArgs e)
        {
            var connectionCreator = new ConnectionCreator();
            if (connectionCreator.ShowDialog() == DialogResult.OK)
            {
                _settings.Connections.Add(connectionCreator.CreatedConnection);
                SettingsManager.SaveSettings(_settings);
                RefreshConnectionsList();
                MessageBox.Show("Connection added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenu_connections_deleteSelectedConnection_Click(object sender, EventArgs e)
        {

        }

        private void listView_registrars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_registrars.SelectedItems.Count == 0)
            {
                listView_domains.Items.Clear();
                listView_targets.Items.Clear();
                return;
            }

            var selectedConnection = (ConnectionModel)listView_registrars.SelectedItems[0].Tag;
            listView_domains.Items.Clear();
            listView_targets.Items.Clear();

            foreach (var domain in selectedConnection.Domains)
            {
                var item = new ListViewItem(domain.Name);
                item.Tag = domain;
                this.listView_domains.Items.Add(item);
            }
        }

        private void listView_domains_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_domains.SelectedItems.Count == 0)
            {
                listView_targets.Items.Clear();
                listView_dnsRecords.Items.Clear();
                return;
            }

            var selectedDomain = (DomainDetails)listView_domains.SelectedItems[0].Tag;
            listView_targets.Items.Clear();
            listView_dnsRecords.Items.Clear();

            foreach (var target in selectedDomain.Targets)
            {
                var item = new ListViewItem(target.Name);
                item.SubItems.Add(target.Type.ToString());
                item.SubItems.Add(target.DnsRecords.Count.ToString());
                item.Tag = target;

                switch (target.Type)
                {
                    case DnsTargetType.Public:
                        item.ForeColor = Color.Blue;
                        break;
                    case DnsTargetType.Local:
                        item.ForeColor = Color.Green;
                        break;
                    case DnsTargetType.Both:
                        item.ForeColor = Color.Purple;
                        break;
                }

                this.listView_targets.Items.Add(item);
            }
        }

        private void listView_targets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_targets.SelectedItems.Count == 0)
            {
                listView_dnsRecords.Items.Clear();
                return;
            }

            var selectedTarget = (DnsTarget)listView_targets.SelectedItems[0].Tag;
            var selectedDomain = (DomainDetails)listView_domains.SelectedItems[0].Tag;
            listView_dnsRecords.Items.Clear();

            // manual DNS records
            foreach (var record in selectedTarget.DnsRecords)
            {
                var item = new ListViewItem(record.Type.ToString());
                item.SubItems.Add(record.Host);
                item.SubItems.Add(record.Value);
                item.SubItems.Add(record.TTL.ToString());
                item.Tag = record;
                this.listView_dnsRecords.Items.Add(item);
            }

            // tree generated records
            var treeRecords = GetTreeGeneratedRecords(selectedDomain, selectedTarget);
            foreach (var record in treeRecords)
            {
                var item = new ListViewItem(record.Type.ToString());
                item.SubItems.Add(record.Host);
                item.SubItems.Add(record.Value);
                item.SubItems.Add(record.TTL.ToString());
                item.SubItems.Add("[Tree]");

                item.ForeColor = Color.Gray;
                item.Font = new Font(item.Font, FontStyle.Italic);

                item.Tag = record;
                this.listView_dnsRecords.Items.Add(item);
            }
        }

        private List<DnsRecord> GetTreeGeneratedRecords(DomainDetails domain, DnsTarget target)
        {
            var allTreeRecords = new List<DnsRecord>();

            foreach (var profile in _settings.Profiles)
            {
                if (!ShouldIncludeProfile(profile.TargetType, target.Type))
                    continue;

                var profileRecords = TreeProfileHelper.GenerateDnsRecords(profile);

                var matchingRecords = profileRecords.Where(r =>
                    r.Host.EndsWith(domain.Name, StringComparison.OrdinalIgnoreCase) ||
                    r.Host.Equals(domain.Name, StringComparison.OrdinalIgnoreCase)
                ).ToList();

                allTreeRecords.AddRange(matchingRecords);
            }

            return allTreeRecords;
        }

        private bool ShouldIncludeProfile(DnsTargetType profileType, DnsTargetType targetType)
        {
            if (profileType == DnsTargetType.Both || targetType == DnsTargetType.Both)
                return true;

            return profileType == targetType;
        }


        private void toolStripMenu_connections_createANewDomain_Click(object sender, EventArgs e)
        {
            if (listView_registrars.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a connection first.", "No Connection Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var domainCreator = new DomainCreator();
            if (domainCreator.ShowDialog() == DialogResult.OK)
            {
                var selectedConnection = (ConnectionModel)listView_registrars.SelectedItems[0].Tag;
                selectedConnection.Domains.Add(new DomainDetails { Name = domainCreator.DomainName });

                SettingsManager.SaveSettings(_settings);
                listView_registrars_SelectedIndexChanged(null, null);

                MessageBox.Show("Domain added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenu_connections_deletedSelectedDomain_Click(object sender, EventArgs e)
        {
            if (listView_registrars.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a connection first.", "No Connection Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listView_domains.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a domain first.", "No Domain Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDomain = (DomainDetails)listView_domains.SelectedItems[0].Tag;
            var selectedConnection = (ConnectionModel)listView_registrars.SelectedItems[0].Tag;

            var result = MessageBox.Show(
                $"Are you sure you want to delete the domain '{selectedDomain.Name}'?\n\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                selectedConnection.Domains.Remove(selectedDomain);
                SettingsManager.SaveSettings(_settings);
                listView_registrars_SelectedIndexChanged(null, null);

                MessageBox.Show("Domain deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenu_targets_createANewTarget_Click(object sender, EventArgs e)
        {
            if (listView_domains.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a domain first.", "No Domain Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var targetCreator = new DnsTargetCreator();
            if (targetCreator.ShowDialog() == DialogResult.OK)
            {
                var selectedDomain = (DomainDetails)listView_domains.SelectedItems[0].Tag;
                selectedDomain.Targets.Add(targetCreator.CreatedTarget);

                SettingsManager.SaveSettings(_settings);
                listView_domains_SelectedIndexChanged(null, null);

                MessageBox.Show($"Target '{targetCreator.CreatedTarget.Name}' added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenu_targets_deleteSelectedTarget_Click(object sender, EventArgs e)
        {
            if (listView_domains.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a domain first.", "No Domain Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listView_targets.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a target to delete.", "No Target Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedTarget = (DnsTarget)listView_targets.SelectedItems[0].Tag;
            var selectedDomain = (DomainDetails)listView_domains.SelectedItems[0].Tag;

            var result = MessageBox.Show(
                $"Are you sure you want to delete the target '{selectedTarget.Name}' and all its DNS records?\n\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                selectedDomain.Targets.Remove(selectedTarget);
                SettingsManager.SaveSettings(_settings);
                listView_domains_SelectedIndexChanged(null, null);

                MessageBox.Show("Target deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenu_dnsRecords_createANewDnsRecord_Click(object sender, EventArgs e)
        {
            if (listView_targets.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a target first.", "No Target Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dnsRecordCreator = new DnsRecordCreator();
            if (dnsRecordCreator.ShowDialog() == DialogResult.OK)
            {
                var selectedTarget = (DnsTarget)listView_targets.SelectedItems[0].Tag;
                selectedTarget.DnsRecords.Add(dnsRecordCreator.CreatedRecord);

                SettingsManager.SaveSettings(_settings);
                listView_targets_SelectedIndexChanged(null, null);

                MessageBox.Show("DNS record created successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenu_dnsRecords_deleteSelectedDnsRecord_Click(object sender, EventArgs e)
        {
            if (listView_targets.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a target first.", "No Target Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listView_dnsRecords.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a DNS record to delete.", "No DNS Record Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRecord = (DnsRecord)listView_dnsRecords.SelectedItems[0].Tag;

            if (selectedRecord.IsFromTree)
            {
                MessageBox.Show("Cannot delete tree-generated records. Please edit the tree structure instead.",
                    "Read-Only Record",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedTarget = (DnsTarget)listView_targets.SelectedItems[0].Tag;

            var result = MessageBox.Show(
                $"Are you sure you want to delete the DNS record '{selectedRecord.Host}' ({selectedRecord.Type})?\n\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                selectedTarget.DnsRecords.Remove(selectedRecord);
                SettingsManager.SaveSettings(_settings);
                listView_targets_SelectedIndexChanged(null, null);

                MessageBox.Show("DNS record deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenu_treeMode_Click(object sender, EventArgs e)
        {
            var treeModeForm = new TreeMode();
            treeModeForm.ShowDialog();
            RefreshConnectionsList();
        }

        private void toolStripMenu_file_saveStateToFile_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveDialog.DefaultExt = "json";
                saveDialog.FileName = $"coeden-dump-{DateTime.Now:yyyy-MM-dd}";
                saveDialog.Title = "Save Settings to File";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var settings = SettingsManager.GetSettings();

                        var json = System.Text.Json.JsonSerializer.Serialize(settings, new System.Text.Json.JsonSerializerOptions
                        {
                            WriteIndented = true
                        });

                        System.IO.File.WriteAllText(saveDialog.FileName, json);

                        MessageBox.Show($"Settings saved successfully to:\n{saveDialog.FileName}", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to save settings:\n{ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripMenu_file_loadStateFromFile_Click(object sender, EventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openDialog.Title = "Load Settings from File";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var confirmResult = MessageBox.Show(
                            "Loading settings from file will replace your current configuration.\n\nDo you want to continue?",
                            "Confirm Load",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirmResult != DialogResult.Yes)
                            return;

                        var json = System.IO.File.ReadAllText(openDialog.FileName);

                        var settings = System.Text.Json.JsonSerializer.Deserialize<SettingsWrapper>(json);

                        if (settings == null)
                        {
                            MessageBox.Show("Failed to load settings: Invalid file format.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        SettingsManager.SaveSettings(settings);

                        RefreshConnectionsList();

                        MessageBox.Show($"Settings loaded successfully from:\n{openDialog.FileName}", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Text.Json.JsonException ex)
                    {
                        MessageBox.Show($"Failed to parse settings file:\n{ex.Message}", "Invalid Format",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to load settings:\n{ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripMenu_file_resetState_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This'll destroy all currently configured dns records within the current state.  This will not directly effect live DNS.", "Reset state?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SettingsManager.SaveSettings(new SettingsWrapper());
                RefreshConnectionsList();
            }
        }
    }
}
