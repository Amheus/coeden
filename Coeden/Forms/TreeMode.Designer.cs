namespace Coeden.Forms
{
    partial class TreeMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeMode));
            toolStrip1 = new ToolStrip();
            toolStripMenu_profiles = new ToolStripDropDownButton();
            toolStripMenu_profiles_createANewProfile = new ToolStripMenuItem();
            toolStripMenu_profiles_deleteSelectedProfile = new ToolStripMenuItem();
            toolStripMenu_tree = new ToolStripDropDownButton();
            toolStripMenu_profiles_addRootIPAddress = new ToolStripMenuItem();
            toolStripMenu_profiles_addNode = new ToolStripMenuItem();
            toolStripMenu_profiles_deleteNode = new ToolStripMenuItem();
            listView_profiles = new ListView();
            columnHeader_profileName = new ColumnHeader();
            treeView_cnameStructure = new TreeView();
            columnHeader_type = new ColumnHeader();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenu_profiles, toolStripMenu_tree });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(984, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripMenu_profiles
            // 
            toolStripMenu_profiles.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_profiles.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenu_profiles_createANewProfile, toolStripMenu_profiles_deleteSelectedProfile });
            toolStripMenu_profiles.Image = (Image)resources.GetObject("toolStripMenu_profiles.Image");
            toolStripMenu_profiles.ImageTransparentColor = Color.Magenta;
            toolStripMenu_profiles.Name = "toolStripMenu_profiles";
            toolStripMenu_profiles.Size = new Size(59, 22);
            toolStripMenu_profiles.Text = "Profiles";
            // 
            // toolStripMenu_profiles_createANewProfile
            // 
            toolStripMenu_profiles_createANewProfile.Name = "toolStripMenu_profiles_createANewProfile";
            toolStripMenu_profiles_createANewProfile.Size = new Size(191, 22);
            toolStripMenu_profiles_createANewProfile.Text = "Create a New Profile";
            toolStripMenu_profiles_createANewProfile.Click += toolStripMenu_profiles_createANewProfile_Click;
            // 
            // toolStripMenu_profiles_deleteSelectedProfile
            // 
            toolStripMenu_profiles_deleteSelectedProfile.Name = "toolStripMenu_profiles_deleteSelectedProfile";
            toolStripMenu_profiles_deleteSelectedProfile.Size = new Size(191, 22);
            toolStripMenu_profiles_deleteSelectedProfile.Text = "Delete Selected Profile";
            toolStripMenu_profiles_deleteSelectedProfile.Click += toolStripMenu_profiles_deleteSelectedProfile_Click;
            // 
            // toolStripMenu_tree
            // 
            toolStripMenu_tree.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_tree.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenu_profiles_addRootIPAddress, toolStripMenu_profiles_addNode, toolStripMenu_profiles_deleteNode });
            toolStripMenu_tree.Image = (Image)resources.GetObject("toolStripMenu_tree.Image");
            toolStripMenu_tree.ImageTransparentColor = Color.Magenta;
            toolStripMenu_tree.Name = "toolStripMenu_tree";
            toolStripMenu_tree.Size = new Size(42, 22);
            toolStripMenu_tree.Text = "Tree";
            // 
            // toolStripMenu_profiles_addRootIPAddress
            // 
            toolStripMenu_profiles_addRootIPAddress.Name = "toolStripMenu_profiles_addRootIPAddress";
            toolStripMenu_profiles_addRootIPAddress.Size = new Size(182, 22);
            toolStripMenu_profiles_addRootIPAddress.Text = "Add Root IP Address";
            toolStripMenu_profiles_addRootIPAddress.Click += toolStripMenu_tree_addIpAddress_Click;
            // 
            // toolStripMenu_profiles_addNode
            // 
            toolStripMenu_profiles_addNode.Name = "toolStripMenu_profiles_addNode";
            toolStripMenu_profiles_addNode.Size = new Size(182, 22);
            toolStripMenu_profiles_addNode.Text = "Add Node";
            toolStripMenu_profiles_addNode.Click += toolStripMenu_tree_addHost_Click;
            // 
            // toolStripMenu_profiles_deleteNode
            // 
            toolStripMenu_profiles_deleteNode.Name = "toolStripMenu_profiles_deleteNode";
            toolStripMenu_profiles_deleteNode.Size = new Size(182, 22);
            toolStripMenu_profiles_deleteNode.Text = "Delete Node";
            toolStripMenu_profiles_deleteNode.Click += toolStripMenu_tree_deleteNode_Click;
            // 
            // listView_profiles
            // 
            listView_profiles.Columns.AddRange(new ColumnHeader[] { columnHeader_profileName, columnHeader_type });
            listView_profiles.Dock = DockStyle.Left;
            listView_profiles.FullRowSelect = true;
            listView_profiles.Location = new Point(0, 25);
            listView_profiles.MultiSelect = false;
            listView_profiles.Name = "listView_profiles";
            listView_profiles.Size = new Size(350, 936);
            listView_profiles.TabIndex = 4;
            listView_profiles.UseCompatibleStateImageBehavior = false;
            listView_profiles.View = View.Details;
            listView_profiles.SelectedIndexChanged += listView_profiles_SelectedIndexChanged;
            // 
            // columnHeader_profileName
            // 
            columnHeader_profileName.Text = "Profile Name";
            columnHeader_profileName.Width = 200;
            // 
            // treeView_cnameStructure
            // 
            treeView_cnameStructure.Dock = DockStyle.Fill;
            treeView_cnameStructure.FullRowSelect = true;
            treeView_cnameStructure.Location = new Point(350, 25);
            treeView_cnameStructure.Name = "treeView_cnameStructure";
            treeView_cnameStructure.Size = new Size(634, 936);
            treeView_cnameStructure.TabIndex = 5;
            // 
            // columnHeader_type
            // 
            columnHeader_type.Text = "Type";
            columnHeader_type.Width = 100;
            // 
            // TreeMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 961);
            Controls.Add(treeView_cnameStructure);
            Controls.Add(listView_profiles);
            Controls.Add(toolStrip1);
            Name = "TreeMode";
            Text = "TreeMode";
            Load += TreeMode_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripMenu_profiles;
        private ToolStripMenuItem toolStripMenu_profiles_createANewProfile;
        private ToolStripMenuItem toolStripMenu_profiles_deleteSelectedProfile;
        private ListView listView_profiles;
        private ColumnHeader columnHeader_profileName;
        private TreeView treeView_cnameStructure;
        private ToolStripDropDownButton toolStripMenu_tree;
        private ToolStripMenuItem toolStripMenu_profiles_addNode;
        private ToolStripMenuItem toolStripMenu_profiles_deleteNode;
        private ToolStripMenuItem toolStripMenu_profiles_addRootIPAddress;
        private ColumnHeader columnHeader_type;
    }
}