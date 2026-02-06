namespace Coeden.Forms.ObjectCreators
{
    partial class DnsRecordCreator
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
            groupBox_host = new GroupBox();
            textBox_host = new TextBox();
            groupBox_type = new GroupBox();
            comboBox_type = new ComboBox();
            button_create = new Button();
            groupBox_ttl = new GroupBox();
            numericUpDown_ttl = new NumericUpDown();
            groupBox_value = new GroupBox();
            textBox_value = new TextBox();
            groupBox_host.SuspendLayout();
            groupBox_type.SuspendLayout();
            groupBox_ttl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ttl).BeginInit();
            groupBox_value.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_host
            // 
            groupBox_host.Controls.Add(textBox_host);
            groupBox_host.Dock = DockStyle.Top;
            groupBox_host.Location = new Point(0, 48);
            groupBox_host.Name = "groupBox_host";
            groupBox_host.Size = new Size(384, 48);
            groupBox_host.TabIndex = 3;
            groupBox_host.TabStop = false;
            groupBox_host.Text = "Host";
            // 
            // textBox_host
            // 
            textBox_host.Dock = DockStyle.Fill;
            textBox_host.Location = new Point(3, 19);
            textBox_host.Name = "textBox_host";
            textBox_host.Size = new Size(378, 23);
            textBox_host.TabIndex = 0;
            // 
            // groupBox_type
            // 
            groupBox_type.Controls.Add(comboBox_type);
            groupBox_type.Dock = DockStyle.Top;
            groupBox_type.Location = new Point(0, 0);
            groupBox_type.Name = "groupBox_type";
            groupBox_type.Size = new Size(384, 48);
            groupBox_type.TabIndex = 4;
            groupBox_type.TabStop = false;
            groupBox_type.Text = "Type";
            // 
            // comboBox_type
            // 
            comboBox_type.Dock = DockStyle.Fill;
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Location = new Point(3, 19);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new Size(378, 23);
            comboBox_type.TabIndex = 0;
            // 
            // button_create
            // 
            button_create.Dock = DockStyle.Bottom;
            button_create.Location = new Point(0, 211);
            button_create.Name = "button_create";
            button_create.Size = new Size(384, 30);
            button_create.TabIndex = 5;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // groupBox_ttl
            // 
            groupBox_ttl.Controls.Add(numericUpDown_ttl);
            groupBox_ttl.Dock = DockStyle.Top;
            groupBox_ttl.Location = new Point(0, 144);
            groupBox_ttl.Name = "groupBox_ttl";
            groupBox_ttl.Size = new Size(384, 48);
            groupBox_ttl.TabIndex = 6;
            groupBox_ttl.TabStop = false;
            groupBox_ttl.Text = "TTL";
            // 
            // numericUpDown_ttl
            // 
            numericUpDown_ttl.Dock = DockStyle.Fill;
            numericUpDown_ttl.Location = new Point(3, 19);
            numericUpDown_ttl.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown_ttl.Name = "numericUpDown_ttl";
            numericUpDown_ttl.Size = new Size(378, 23);
            numericUpDown_ttl.TabIndex = 0;
            // 
            // groupBox_value
            // 
            groupBox_value.Controls.Add(textBox_value);
            groupBox_value.Dock = DockStyle.Top;
            groupBox_value.Location = new Point(0, 96);
            groupBox_value.Name = "groupBox_value";
            groupBox_value.Size = new Size(384, 48);
            groupBox_value.TabIndex = 7;
            groupBox_value.TabStop = false;
            groupBox_value.Text = "Value";
            // 
            // textBox_value
            // 
            textBox_value.Dock = DockStyle.Fill;
            textBox_value.Location = new Point(3, 19);
            textBox_value.Name = "textBox_value";
            textBox_value.Size = new Size(378, 23);
            textBox_value.TabIndex = 0;
            // 
            // DnsRecordCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 241);
            Controls.Add(groupBox_ttl);
            Controls.Add(groupBox_value);
            Controls.Add(groupBox_host);
            Controls.Add(groupBox_type);
            Controls.Add(button_create);
            Name = "DnsRecordCreator";
            Text = "DnsRecordCreator";
            Load += DnsRecordCreator_Load;
            groupBox_host.ResumeLayout(false);
            groupBox_host.PerformLayout();
            groupBox_type.ResumeLayout(false);
            groupBox_ttl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ttl).EndInit();
            groupBox_value.ResumeLayout(false);
            groupBox_value.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_host;
        private TextBox textBox_host;
        private GroupBox groupBox_type;
        private Button button_create;
        private GroupBox groupBox_ttl;
        private GroupBox groupBox_value;
        private TextBox textBox_value;
        private ComboBox comboBox_type;
        private NumericUpDown numericUpDown_ttl;
    }
}