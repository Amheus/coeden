namespace Coeden.Forms.ObjectCreators
{
    partial class HostnameCreator
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
            button_create = new Button();
            textBox_hostname = new TextBox();
            groupBox_hostname = new GroupBox();
            groupBox_hostname.SuspendLayout();
            SuspendLayout();
            // 
            // button_create
            // 
            button_create.Dock = DockStyle.Bottom;
            button_create.Location = new Point(0, 51);
            button_create.Name = "button_create";
            button_create.Size = new Size(384, 30);
            button_create.TabIndex = 11;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // textBox_hostname
            // 
            textBox_hostname.Dock = DockStyle.Fill;
            textBox_hostname.Location = new Point(3, 19);
            textBox_hostname.Name = "textBox_hostname";
            textBox_hostname.Size = new Size(378, 23);
            textBox_hostname.TabIndex = 0;
            // 
            // groupBox_hostname
            // 
            groupBox_hostname.Controls.Add(textBox_hostname);
            groupBox_hostname.Dock = DockStyle.Top;
            groupBox_hostname.Location = new Point(0, 0);
            groupBox_hostname.Name = "groupBox_hostname";
            groupBox_hostname.Size = new Size(384, 48);
            groupBox_hostname.TabIndex = 10;
            groupBox_hostname.TabStop = false;
            groupBox_hostname.Text = "Hostname";
            // 
            // HostnameCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 81);
            Controls.Add(button_create);
            Controls.Add(groupBox_hostname);
            Name = "HostnameCreator";
            Text = "HostnameCreator";
            Load += HostnameCreator_Load;
            groupBox_hostname.ResumeLayout(false);
            groupBox_hostname.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_create;
        private TextBox textBox_hostname;
        private GroupBox groupBox_hostname;
    }
}