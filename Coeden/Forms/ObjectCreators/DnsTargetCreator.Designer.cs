namespace Coeden.Forms.ObjectCreators
{
    partial class DnsTargetCreator
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
            groupBox_name = new GroupBox();
            textBox_name = new TextBox();
            groupBox_type = new GroupBox();
            comboBox_type = new ComboBox();
            button_create = new Button();
            groupBox_notes = new GroupBox();
            textBox_notes = new TextBox();
            groupBox_name.SuspendLayout();
            groupBox_type.SuspendLayout();
            groupBox_notes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_name
            // 
            groupBox_name.Controls.Add(textBox_name);
            groupBox_name.Dock = DockStyle.Top;
            groupBox_name.Location = new Point(0, 48);
            groupBox_name.Name = "groupBox_name";
            groupBox_name.Size = new Size(384, 48);
            groupBox_name.TabIndex = 3;
            groupBox_name.TabStop = false;
            groupBox_name.Text = "Name";
            // 
            // textBox_name
            // 
            textBox_name.Dock = DockStyle.Fill;
            textBox_name.Location = new Point(3, 19);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(378, 23);
            textBox_name.TabIndex = 0;
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
            button_create.Location = new Point(0, 156);
            button_create.Name = "button_create";
            button_create.Size = new Size(384, 30);
            button_create.TabIndex = 5;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // groupBox_notes
            // 
            groupBox_notes.Controls.Add(textBox_notes);
            groupBox_notes.Dock = DockStyle.Top;
            groupBox_notes.Location = new Point(0, 96);
            groupBox_notes.Name = "groupBox_notes";
            groupBox_notes.Size = new Size(384, 48);
            groupBox_notes.TabIndex = 6;
            groupBox_notes.TabStop = false;
            groupBox_notes.Text = "Notes";
            // 
            // textBox_notes
            // 
            textBox_notes.Dock = DockStyle.Fill;
            textBox_notes.Location = new Point(3, 19);
            textBox_notes.Name = "textBox_notes";
            textBox_notes.Size = new Size(378, 23);
            textBox_notes.TabIndex = 0;
            // 
            // DnsTargetCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 186);
            Controls.Add(groupBox_notes);
            Controls.Add(groupBox_name);
            Controls.Add(groupBox_type);
            Controls.Add(button_create);
            Name = "DnsTargetCreator";
            Text = "DnsTargetCreator";
            Load += DnsTargetCreator_Load;
            groupBox_name.ResumeLayout(false);
            groupBox_name.PerformLayout();
            groupBox_type.ResumeLayout(false);
            groupBox_notes.ResumeLayout(false);
            groupBox_notes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_name;
        private TextBox textBox_name;
        private GroupBox groupBox_type;
        private Button button_create;
        private ComboBox comboBox_type;
        private GroupBox groupBox_notes;
        private TextBox textBox_notes;
    }
}