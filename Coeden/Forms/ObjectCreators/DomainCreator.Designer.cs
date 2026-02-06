namespace Coeden.Forms.ObjectCreators
{
    partial class DomainCreator
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
            textBox_name = new TextBox();
            groupBox_name = new GroupBox();
            groupBox_name.SuspendLayout();
            SuspendLayout();
            // 
            // button_create
            // 
            button_create.Dock = DockStyle.Bottom;
            button_create.Location = new Point(0, 51);
            button_create.Name = "button_create";
            button_create.Size = new Size(384, 30);
            button_create.TabIndex = 7;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // textBox_name
            // 
            textBox_name.Dock = DockStyle.Fill;
            textBox_name.Location = new Point(3, 19);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(378, 23);
            textBox_name.TabIndex = 0;
            // 
            // groupBox_name
            // 
            groupBox_name.Controls.Add(textBox_name);
            groupBox_name.Dock = DockStyle.Top;
            groupBox_name.Location = new Point(0, 0);
            groupBox_name.Name = "groupBox_name";
            groupBox_name.Size = new Size(384, 48);
            groupBox_name.TabIndex = 6;
            groupBox_name.TabStop = false;
            groupBox_name.Text = "Name";
            // 
            // DomainCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 81);
            Controls.Add(button_create);
            Controls.Add(groupBox_name);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DomainCreator";
            Text = "DomainCreator";
            Load += DomainCreator_Load;
            groupBox_name.ResumeLayout(false);
            groupBox_name.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_create;
        private TextBox textBox_name;
        private GroupBox groupBox_name;
    }
}