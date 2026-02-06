namespace Coeden.Forms.ObjectCreators
{
    partial class IpAddressCreator
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
            groupBox_ipAddress = new GroupBox();
            textBox_ipAddress = new TextBox();
            button_create = new Button();
            groupBox_ipAddress.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_ipAddress
            // 
            groupBox_ipAddress.Controls.Add(textBox_ipAddress);
            groupBox_ipAddress.Dock = DockStyle.Top;
            groupBox_ipAddress.Location = new Point(0, 0);
            groupBox_ipAddress.Name = "groupBox_ipAddress";
            groupBox_ipAddress.Size = new Size(384, 48);
            groupBox_ipAddress.TabIndex = 8;
            groupBox_ipAddress.TabStop = false;
            groupBox_ipAddress.Text = "IP Address";
            // 
            // textBox_ipAddress
            // 
            textBox_ipAddress.Dock = DockStyle.Fill;
            textBox_ipAddress.Location = new Point(3, 19);
            textBox_ipAddress.Name = "textBox_ipAddress";
            textBox_ipAddress.Size = new Size(378, 23);
            textBox_ipAddress.TabIndex = 0;
            // 
            // button_create
            // 
            button_create.Dock = DockStyle.Bottom;
            button_create.Location = new Point(0, 51);
            button_create.Name = "button_create";
            button_create.Size = new Size(384, 30);
            button_create.TabIndex = 9;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // IpAddressCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 81);
            Controls.Add(groupBox_ipAddress);
            Controls.Add(button_create);
            Name = "IpAddressCreator";
            Text = "IpAddressCreator";
            Load += IpAddressCreator_Load;
            groupBox_ipAddress.ResumeLayout(false);
            groupBox_ipAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_ipAddress;
        private TextBox textBox_ipAddress;
        private Button button_create;
    }
}