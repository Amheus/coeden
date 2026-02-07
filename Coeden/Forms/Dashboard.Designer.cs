namespace Coeden.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            toolStrip1 = new ToolStrip();
            toolStripMenu_file = new ToolStripDropDownButton();
            toolStripMenu_file_saveStateToFile = new ToolStripMenuItem();
            toolStripMenu_file_loadStateFromFile = new ToolStripMenuItem();
            toolStripMenu_file_resetState = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenu_connections = new ToolStripDropDownButton();
            toolStripMenu_connections_createANewConnection = new ToolStripMenuItem();
            toolStripMenu_connections_deleteSelectedConnection = new ToolStripMenuItem();
            toolStripMenu_domains = new ToolStripDropDownButton();
            toolStripMenu_connections_createANewDomain = new ToolStripMenuItem();
            toolStripMenu_connections_deletedSelectedDomain = new ToolStripMenuItem();
            toolStripMenu_targets = new ToolStripDropDownButton();
            toolStripMenu_targets_createANewTarget = new ToolStripMenuItem();
            toolStripMenu_targets_deleteSelectedTarget = new ToolStripMenuItem();
            toolStripMenu_dnsRecords = new ToolStripDropDownButton();
            toolStripMenu_dnsRecords_createANewDnsRecord = new ToolStripMenuItem();
            toolStripMenu_dnsRecords_deleteSelectedDnsRecord = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenu_treeMode = new ToolStripButton();
            listView_registrars = new ListView();
            columnHeader_name = new ColumnHeader();
            columnHeader_note = new ColumnHeader();
            listView_domains = new ListView();
            columnHeader_domainName = new ColumnHeader();
            listView_dnsRecords = new ListView();
            columnHeader_dnsRecords_type = new ColumnHeader();
            columnHeader_dnsRecords_host = new ColumnHeader();
            columnHeader_dnsRecords_value = new ColumnHeader();
            columnHeader_dnsRecords_ttl = new ColumnHeader();
            listView_targets = new ListView();
            columnHeader_targets = new ColumnHeader();
            columnHeader_type = new ColumnHeader();
            columnHeader_totalRecords = new ColumnHeader();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenu_file, toolStripSeparator2, toolStripMenu_connections, toolStripMenu_domains, toolStripMenu_targets, toolStripMenu_dnsRecords, toolStripSeparator1, toolStripMenu_treeMode });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1984, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripMenu_file
            // 
            toolStripMenu_file.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_file.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenu_file_saveStateToFile, toolStripMenu_file_loadStateFromFile, toolStripMenu_file_resetState });
            toolStripMenu_file.Image = (Image)resources.GetObject("toolStripMenu_file.Image");
            toolStripMenu_file.ImageTransparentColor = Color.Magenta;
            toolStripMenu_file.Name = "toolStripMenu_file";
            toolStripMenu_file.Size = new Size(38, 22);
            toolStripMenu_file.Text = "File";
            // 
            // toolStripMenu_file_saveStateToFile
            // 
            toolStripMenu_file_saveStateToFile.Name = "toolStripMenu_file_saveStateToFile";
            toolStripMenu_file_saveStateToFile.Size = new Size(179, 22);
            toolStripMenu_file_saveStateToFile.Text = "Save State to File";
            toolStripMenu_file_saveStateToFile.Click += toolStripMenu_file_saveStateToFile_Click;
            // 
            // toolStripMenu_file_loadStateFromFile
            // 
            toolStripMenu_file_loadStateFromFile.Name = "toolStripMenu_file_loadStateFromFile";
            toolStripMenu_file_loadStateFromFile.Size = new Size(179, 22);
            toolStripMenu_file_loadStateFromFile.Text = "Load State from File";
            toolStripMenu_file_loadStateFromFile.Click += toolStripMenu_file_loadStateFromFile_Click;
            // 
            // toolStripMenu_file_resetState
            // 
            toolStripMenu_file_resetState.Name = "toolStripMenu_file_resetState";
            toolStripMenu_file_resetState.Size = new Size(179, 22);
            toolStripMenu_file_resetState.Text = "Reset State";
            toolStripMenu_file_resetState.Click += toolStripMenu_file_resetState_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripMenu_connections
            // 
            toolStripMenu_connections.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_connections.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenu_connections_createANewConnection, toolStripMenu_connections_deleteSelectedConnection });
            toolStripMenu_connections.Image = (Image)resources.GetObject("toolStripMenu_connections.Image");
            toolStripMenu_connections.ImageTransparentColor = Color.Magenta;
            toolStripMenu_connections.Name = "toolStripMenu_connections";
            toolStripMenu_connections.Size = new Size(87, 22);
            toolStripMenu_connections.Text = "Connections";
            // 
            // toolStripMenu_connections_createANewConnection
            // 
            toolStripMenu_connections_createANewConnection.Name = "toolStripMenu_connections_createANewConnection";
            toolStripMenu_connections_createANewConnection.Size = new Size(219, 22);
            toolStripMenu_connections_createANewConnection.Text = "Create a New Connection";
            toolStripMenu_connections_createANewConnection.Click += toolStripMenu_connections_createANewConnection_Click;
            // 
            // toolStripMenu_connections_deleteSelectedConnection
            // 
            toolStripMenu_connections_deleteSelectedConnection.Name = "toolStripMenu_connections_deleteSelectedConnection";
            toolStripMenu_connections_deleteSelectedConnection.Size = new Size(219, 22);
            toolStripMenu_connections_deleteSelectedConnection.Text = "Delete Selected Connection";
            toolStripMenu_connections_deleteSelectedConnection.Click += toolStripMenu_connections_deleteSelectedConnection_Click;
            // 
            // toolStripMenu_domains
            // 
            toolStripMenu_domains.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_domains.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenu_connections_createANewDomain, toolStripMenu_connections_deletedSelectedDomain });
            toolStripMenu_domains.Image = (Image)resources.GetObject("toolStripMenu_domains.Image");
            toolStripMenu_domains.ImageTransparentColor = Color.Magenta;
            toolStripMenu_domains.Name = "toolStripMenu_domains";
            toolStripMenu_domains.Size = new Size(67, 22);
            toolStripMenu_domains.Text = "Domains";
            // 
            // toolStripMenu_connections_createANewDomain
            // 
            toolStripMenu_connections_createANewDomain.Name = "toolStripMenu_connections_createANewDomain";
            toolStripMenu_connections_createANewDomain.Size = new Size(199, 22);
            toolStripMenu_connections_createANewDomain.Text = "Create a New Domain";
            toolStripMenu_connections_createANewDomain.Click += toolStripMenu_connections_createANewDomain_Click;
            // 
            // toolStripMenu_connections_deletedSelectedDomain
            // 
            toolStripMenu_connections_deletedSelectedDomain.Name = "toolStripMenu_connections_deletedSelectedDomain";
            toolStripMenu_connections_deletedSelectedDomain.Size = new Size(199, 22);
            toolStripMenu_connections_deletedSelectedDomain.Text = "Delete Selected Domain";
            toolStripMenu_connections_deletedSelectedDomain.Click += toolStripMenu_connections_deletedSelectedDomain_Click;
            // 
            // toolStripMenu_targets
            // 
            toolStripMenu_targets.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_targets.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenu_targets_createANewTarget, toolStripMenu_targets_deleteSelectedTarget });
            toolStripMenu_targets.Image = (Image)resources.GetObject("toolStripMenu_targets.Image");
            toolStripMenu_targets.ImageTransparentColor = Color.Magenta;
            toolStripMenu_targets.Name = "toolStripMenu_targets";
            toolStripMenu_targets.Size = new Size(58, 22);
            toolStripMenu_targets.Text = "Targets";
            // 
            // toolStripMenu_targets_createANewTarget
            // 
            toolStripMenu_targets_createANewTarget.Name = "toolStripMenu_targets_createANewTarget";
            toolStripMenu_targets_createANewTarget.Size = new Size(190, 22);
            toolStripMenu_targets_createANewTarget.Text = "Create A New Target";
            toolStripMenu_targets_createANewTarget.Click += toolStripMenu_targets_createANewTarget_Click;
            // 
            // toolStripMenu_targets_deleteSelectedTarget
            // 
            toolStripMenu_targets_deleteSelectedTarget.Name = "toolStripMenu_targets_deleteSelectedTarget";
            toolStripMenu_targets_deleteSelectedTarget.Size = new Size(190, 22);
            toolStripMenu_targets_deleteSelectedTarget.Text = "Delete Selected Target";
            toolStripMenu_targets_deleteSelectedTarget.Click += toolStripMenu_targets_deleteSelectedTarget_Click;
            // 
            // toolStripMenu_dnsRecords
            // 
            toolStripMenu_dnsRecords.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_dnsRecords.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenu_dnsRecords_createANewDnsRecord, toolStripMenu_dnsRecords_deleteSelectedDnsRecord });
            toolStripMenu_dnsRecords.Image = (Image)resources.GetObject("toolStripMenu_dnsRecords.Image");
            toolStripMenu_dnsRecords.ImageTransparentColor = Color.Magenta;
            toolStripMenu_dnsRecords.Name = "toolStripMenu_dnsRecords";
            toolStripMenu_dnsRecords.Size = new Size(88, 22);
            toolStripMenu_dnsRecords.Text = "DNS Records";
            // 
            // toolStripMenu_dnsRecords_createANewDnsRecord
            // 
            toolStripMenu_dnsRecords_createANewDnsRecord.Name = "toolStripMenu_dnsRecords_createANewDnsRecord";
            toolStripMenu_dnsRecords_createANewDnsRecord.Size = new Size(220, 22);
            toolStripMenu_dnsRecords_createANewDnsRecord.Text = "Create a New DNS Record";
            toolStripMenu_dnsRecords_createANewDnsRecord.Click += toolStripMenu_dnsRecords_createANewDnsRecord_Click;
            // 
            // toolStripMenu_dnsRecords_deleteSelectedDnsRecord
            // 
            toolStripMenu_dnsRecords_deleteSelectedDnsRecord.Name = "toolStripMenu_dnsRecords_deleteSelectedDnsRecord";
            toolStripMenu_dnsRecords_deleteSelectedDnsRecord.Size = new Size(220, 22);
            toolStripMenu_dnsRecords_deleteSelectedDnsRecord.Text = "Delete Selected DNS Record";
            toolStripMenu_dnsRecords_deleteSelectedDnsRecord.Click += toolStripMenu_dnsRecords_deleteSelectedDnsRecord_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripMenu_treeMode
            // 
            toolStripMenu_treeMode.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_treeMode.Image = (Image)resources.GetObject("toolStripMenu_treeMode.Image");
            toolStripMenu_treeMode.ImageTransparentColor = Color.Magenta;
            toolStripMenu_treeMode.Name = "toolStripMenu_treeMode";
            toolStripMenu_treeMode.Size = new Size(67, 22);
            toolStripMenu_treeMode.Text = "Tree Mode";
            toolStripMenu_treeMode.Click += toolStripMenu_treeMode_Click;
            // 
            // listView_registrars
            // 
            listView_registrars.Columns.AddRange(new ColumnHeader[] { columnHeader_name, columnHeader_note });
            listView_registrars.Dock = DockStyle.Left;
            listView_registrars.FullRowSelect = true;
            listView_registrars.Location = new Point(0, 25);
            listView_registrars.MultiSelect = false;
            listView_registrars.Name = "listView_registrars";
            listView_registrars.Size = new Size(400, 936);
            listView_registrars.TabIndex = 2;
            listView_registrars.UseCompatibleStateImageBehavior = false;
            listView_registrars.View = View.Details;
            listView_registrars.SelectedIndexChanged += listView_registrars_SelectedIndexChanged;
            // 
            // columnHeader_name
            // 
            columnHeader_name.Text = "Registrar Name";
            columnHeader_name.Width = 150;
            // 
            // columnHeader_note
            // 
            columnHeader_note.Text = "Note";
            columnHeader_note.Width = 200;
            // 
            // listView_domains
            // 
            listView_domains.Columns.AddRange(new ColumnHeader[] { columnHeader_domainName });
            listView_domains.Dock = DockStyle.Left;
            listView_domains.FullRowSelect = true;
            listView_domains.Location = new Point(400, 25);
            listView_domains.MultiSelect = false;
            listView_domains.Name = "listView_domains";
            listView_domains.Size = new Size(265, 936);
            listView_domains.TabIndex = 3;
            listView_domains.UseCompatibleStateImageBehavior = false;
            listView_domains.View = View.Details;
            listView_domains.SelectedIndexChanged += listView_domains_SelectedIndexChanged;
            // 
            // columnHeader_domainName
            // 
            columnHeader_domainName.Text = "DomainName";
            columnHeader_domainName.Width = 200;
            // 
            // listView_dnsRecords
            // 
            listView_dnsRecords.Columns.AddRange(new ColumnHeader[] { columnHeader_dnsRecords_type, columnHeader_dnsRecords_host, columnHeader_dnsRecords_value, columnHeader_dnsRecords_ttl });
            listView_dnsRecords.Dock = DockStyle.Fill;
            listView_dnsRecords.FullRowSelect = true;
            listView_dnsRecords.Location = new Point(1040, 25);
            listView_dnsRecords.MultiSelect = false;
            listView_dnsRecords.Name = "listView_dnsRecords";
            listView_dnsRecords.Size = new Size(944, 936);
            listView_dnsRecords.TabIndex = 4;
            listView_dnsRecords.UseCompatibleStateImageBehavior = false;
            listView_dnsRecords.View = View.Details;
            // 
            // columnHeader_dnsRecords_type
            // 
            columnHeader_dnsRecords_type.Text = "Type";
            columnHeader_dnsRecords_type.Width = 100;
            // 
            // columnHeader_dnsRecords_host
            // 
            columnHeader_dnsRecords_host.Text = "Host";
            columnHeader_dnsRecords_host.Width = 200;
            // 
            // columnHeader_dnsRecords_value
            // 
            columnHeader_dnsRecords_value.Text = "Value";
            columnHeader_dnsRecords_value.Width = 400;
            // 
            // columnHeader_dnsRecords_ttl
            // 
            columnHeader_dnsRecords_ttl.Text = "TTL";
            columnHeader_dnsRecords_ttl.Width = 100;
            // 
            // listView_targets
            // 
            listView_targets.Columns.AddRange(new ColumnHeader[] { columnHeader_targets, columnHeader_type, columnHeader_totalRecords });
            listView_targets.Dock = DockStyle.Left;
            listView_targets.FullRowSelect = true;
            listView_targets.Location = new Point(665, 25);
            listView_targets.MultiSelect = false;
            listView_targets.Name = "listView_targets";
            listView_targets.Size = new Size(375, 936);
            listView_targets.TabIndex = 5;
            listView_targets.UseCompatibleStateImageBehavior = false;
            listView_targets.View = View.Details;
            listView_targets.SelectedIndexChanged += listView_targets_SelectedIndexChanged;
            // 
            // columnHeader_targets
            // 
            columnHeader_targets.Text = "Target";
            columnHeader_targets.Width = 140;
            // 
            // columnHeader_type
            // 
            columnHeader_type.Text = "Type";
            columnHeader_type.Width = 100;
            // 
            // columnHeader_totalRecords
            // 
            columnHeader_totalRecords.Text = "Total Records";
            columnHeader_totalRecords.Width = 100;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1984, 961);
            Controls.Add(listView_dnsRecords);
            Controls.Add(listView_targets);
            Controls.Add(listView_domains);
            Controls.Add(listView_registrars);
            Controls.Add(toolStrip1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripMenu_connections;
        private ToolStripMenuItem toolStripMenu_connections_createANewConnection;
        private ListView listView_registrars;
        private ColumnHeader columnHeader_name;
        private ListView listView_domains;
        private ColumnHeader columnHeader_domainName;
        private ToolStripDropDownButton toolStripMenu_domains;
        private ToolStripMenuItem toolStripMenu_connections_createANewDomain;
        private ToolStripMenuItem toolStripMenu_connections_deletedSelectedDomain;
        private ToolStripDropDownButton toolStripMenu_dnsRecords;
        private ToolStripMenuItem toolStripMenu_dnsRecords_createANewDnsRecord;
        private ListView listView_dnsRecords;
        private ColumnHeader columnHeader_dnsRecords_type;
        private ColumnHeader columnHeader_dnsRecords_host;
        private ColumnHeader columnHeader_dnsRecords_value;
        private ColumnHeader columnHeader_dnsRecords_ttl;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripMenu_treeMode;
        private ToolStripMenuItem toolStripMenu_dnsRecords_deleteSelectedDnsRecord;
        private ListView listView_targets;
        private ColumnHeader columnHeader_targets;
        private ToolStripDropDownButton toolStripMenu_targets;
        private ToolStripMenuItem toolStripMenu_targets_createANewTarget;
        private ToolStripMenuItem toolStripMenu_targets_deleteSelectedTarget;
        private ColumnHeader columnHeader_type;
        private ColumnHeader columnHeader_totalRecords;
        private ToolStripDropDownButton toolStripMenu_file;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenu_file_saveStateToFile;
        private ToolStripMenuItem toolStripMenu_file_loadStateFromFile;
        private ColumnHeader columnHeader_note;
        private ToolStripMenuItem toolStripMenu_file_resetState;
        private ToolStripMenuItem toolStripMenu_connections_deleteSelectedConnection;
    }
}