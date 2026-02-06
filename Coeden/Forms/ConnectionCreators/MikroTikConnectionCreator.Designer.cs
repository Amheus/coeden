namespace Coeden.Forms.ConnectionCreators
{
    partial class MikroTikConnectionCreator
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
            groupBox_password = new GroupBox();
            textBox_password = new TextBox();
            groupBox_username = new GroupBox();
            textBox_username = new TextBox();
            button_create = new Button();
            groupBox_password.SuspendLayout();
            groupBox_username.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_password
            // 
            groupBox_password.Controls.Add(textBox_password);
            groupBox_password.Dock = DockStyle.Top;
            groupBox_password.Location = new Point(0, 48);
            groupBox_password.Name = "groupBox_password";
            groupBox_password.Size = new Size(384, 48);
            groupBox_password.TabIndex = 3;
            groupBox_password.TabStop = false;
            groupBox_password.Text = "Password";
            // 
            // textBox_password
            // 
            textBox_password.Dock = DockStyle.Fill;
            textBox_password.Location = new Point(3, 19);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(378, 23);
            textBox_password.TabIndex = 0;
            // 
            // groupBox_username
            // 
            groupBox_username.Controls.Add(textBox_username);
            groupBox_username.Dock = DockStyle.Top;
            groupBox_username.Location = new Point(0, 0);
            groupBox_username.Name = "groupBox_username";
            groupBox_username.Size = new Size(384, 48);
            groupBox_username.TabIndex = 4;
            groupBox_username.TabStop = false;
            groupBox_username.Text = "Username";
            // 
            // textBox_username
            // 
            textBox_username.Dock = DockStyle.Fill;
            textBox_username.Location = new Point(3, 19);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(378, 23);
            textBox_username.TabIndex = 0;
            // 
            // button_create
            // 
            button_create.Dock = DockStyle.Bottom;
            button_create.Location = new Point(0, 111);
            button_create.Name = "button_create";
            button_create.Size = new Size(384, 30);
            button_create.TabIndex = 5;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // MikroTikConnectionCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 141);
            Controls.Add(groupBox_password);
            Controls.Add(groupBox_username);
            Controls.Add(button_create);
            Name = "MikroTikConnectionCreator";
            Text = "MikroTikConnectionCreator";
            groupBox_password.ResumeLayout(false);
            groupBox_password.PerformLayout();
            groupBox_username.ResumeLayout(false);
            groupBox_username.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_password;
        private TextBox textBox_password;
        private GroupBox groupBox_username;
        private TextBox textBox_username;
        private Button button_create;
    }
}