namespace Coeden.Forms.ConnectionCreators
{
    partial class IonosConnectionCreator
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
            groupBox_publicPrefix = new GroupBox();
            textBox_publicPrefix = new TextBox();
            groupBox_secret = new GroupBox();
            textBox_secret = new TextBox();
            button_create = new Button();
            groupBox_publicPrefix.SuspendLayout();
            groupBox_secret.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_publicPrefix
            // 
            groupBox_publicPrefix.Controls.Add(textBox_publicPrefix);
            groupBox_publicPrefix.Dock = DockStyle.Top;
            groupBox_publicPrefix.Location = new Point(0, 0);
            groupBox_publicPrefix.Name = "groupBox_publicPrefix";
            groupBox_publicPrefix.Size = new Size(384, 48);
            groupBox_publicPrefix.TabIndex = 0;
            groupBox_publicPrefix.TabStop = false;
            groupBox_publicPrefix.Text = "Public Prefix";
            // 
            // textBox_publicPrefix
            // 
            textBox_publicPrefix.Dock = DockStyle.Fill;
            textBox_publicPrefix.Location = new Point(3, 19);
            textBox_publicPrefix.Name = "textBox_publicPrefix";
            textBox_publicPrefix.Size = new Size(378, 23);
            textBox_publicPrefix.TabIndex = 0;
            // 
            // groupBox_secret
            // 
            groupBox_secret.Controls.Add(textBox_secret);
            groupBox_secret.Dock = DockStyle.Top;
            groupBox_secret.Location = new Point(0, 48);
            groupBox_secret.Name = "groupBox_secret";
            groupBox_secret.Size = new Size(384, 48);
            groupBox_secret.TabIndex = 1;
            groupBox_secret.TabStop = false;
            groupBox_secret.Text = "Secret";
            // 
            // textBox_secret
            // 
            textBox_secret.Dock = DockStyle.Fill;
            textBox_secret.Location = new Point(3, 19);
            textBox_secret.Name = "textBox_secret";
            textBox_secret.Size = new Size(378, 23);
            textBox_secret.TabIndex = 0;
            // 
            // button_create
            // 
            button_create.Dock = DockStyle.Bottom;
            button_create.Location = new Point(0, 111);
            button_create.Name = "button_create";
            button_create.Size = new Size(384, 30);
            button_create.TabIndex = 2;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // Ionos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 141);
            Controls.Add(button_create);
            Controls.Add(groupBox_secret);
            Controls.Add(groupBox_publicPrefix);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Ionos";
            Text = "Ionos";
            groupBox_publicPrefix.ResumeLayout(false);
            groupBox_publicPrefix.PerformLayout();
            groupBox_secret.ResumeLayout(false);
            groupBox_secret.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_publicPrefix;
        private TextBox textBox_publicPrefix;
        private GroupBox groupBox_secret;
        private TextBox textBox_secret;
        private Button button_create;
    }
}