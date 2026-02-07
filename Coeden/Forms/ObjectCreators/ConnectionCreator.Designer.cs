namespace Coeden.Forms.ObjectCreators
{
    partial class ConnectionCreator
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
            groupBox_connectionType = new GroupBox();
            flowLayoutPanel_connectionType = new FlowLayoutPanel();
            groupBox_settings = new GroupBox();
            flowLayoutPanel_settings = new FlowLayoutPanel();
            button_create = new Button();
            groupBox_connectionType.SuspendLayout();
            groupBox_settings.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_connectionType
            // 
            groupBox_connectionType.Controls.Add(flowLayoutPanel_connectionType);
            groupBox_connectionType.Dock = DockStyle.Left;
            groupBox_connectionType.Location = new Point(0, 0);
            groupBox_connectionType.Name = "groupBox_connectionType";
            groupBox_connectionType.Size = new Size(200, 636);
            groupBox_connectionType.TabIndex = 1;
            groupBox_connectionType.TabStop = false;
            groupBox_connectionType.Text = "Connection Type";
            // 
            // flowLayoutPanel_connectionType
            // 
            flowLayoutPanel_connectionType.Dock = DockStyle.Fill;
            flowLayoutPanel_connectionType.Location = new Point(3, 19);
            flowLayoutPanel_connectionType.Name = "flowLayoutPanel_connectionType";
            flowLayoutPanel_connectionType.Size = new Size(194, 614);
            flowLayoutPanel_connectionType.TabIndex = 0;
            // 
            // groupBox_settings
            // 
            groupBox_settings.Controls.Add(flowLayoutPanel_settings);
            groupBox_settings.Dock = DockStyle.Fill;
            groupBox_settings.Location = new Point(200, 0);
            groupBox_settings.Name = "groupBox_settings";
            groupBox_settings.Size = new Size(384, 636);
            groupBox_settings.TabIndex = 2;
            groupBox_settings.TabStop = false;
            groupBox_settings.Text = "Settings";
            // 
            // flowLayoutPanel_settings
            // 
            flowLayoutPanel_settings.Dock = DockStyle.Fill;
            flowLayoutPanel_settings.Location = new Point(3, 19);
            flowLayoutPanel_settings.Name = "flowLayoutPanel_settings";
            flowLayoutPanel_settings.Size = new Size(378, 614);
            flowLayoutPanel_settings.TabIndex = 1;
            // 
            // button_create
            // 
            button_create.Dock = DockStyle.Bottom;
            button_create.Location = new Point(0, 636);
            button_create.Name = "button_create";
            button_create.Size = new Size(584, 25);
            button_create.TabIndex = 3;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // ConnectionCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 661);
            Controls.Add(groupBox_settings);
            Controls.Add(groupBox_connectionType);
            Controls.Add(button_create);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ConnectionCreator";
            Text = "ConnectionCreator";
            Load += ConnectionCreator_Load;
            groupBox_connectionType.ResumeLayout(false);
            groupBox_settings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_connectionType;
        private FlowLayoutPanel flowLayoutPanel_connectionType;
        private GroupBox groupBox_settings;
        private Button button_create;
        private FlowLayoutPanel flowLayoutPanel_settings;
    }
}