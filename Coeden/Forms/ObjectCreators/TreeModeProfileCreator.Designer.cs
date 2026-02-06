namespace Coeden.Forms.ObjectCreators
{
    partial class TreeModeProfileCreator
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
            button_create = new Button();
            groupBox_targetType = new GroupBox();
            comboBox_targetType = new ComboBox();
            groupBox_name.SuspendLayout();
            groupBox_targetType.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_name
            // 
            groupBox_name.Controls.Add(textBox_name);
            groupBox_name.Dock = DockStyle.Top;
            groupBox_name.Location = new Point(0, 48);
            groupBox_name.Name = "groupBox_name";
            groupBox_name.Size = new Size(384, 48);
            groupBox_name.TabIndex = 8;
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
            // button_create
            // 
            button_create.Dock = DockStyle.Bottom;
            button_create.Location = new Point(0, 106);
            button_create.Name = "button_create";
            button_create.Size = new Size(384, 30);
            button_create.TabIndex = 9;
            button_create.Text = "Create";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // groupBox_targetType
            // 
            groupBox_targetType.Controls.Add(comboBox_targetType);
            groupBox_targetType.Dock = DockStyle.Top;
            groupBox_targetType.Location = new Point(0, 0);
            groupBox_targetType.Name = "groupBox_targetType";
            groupBox_targetType.Size = new Size(384, 48);
            groupBox_targetType.TabIndex = 10;
            groupBox_targetType.TabStop = false;
            groupBox_targetType.Text = "Target Type";
            // 
            // comboBox_targetType
            // 
            comboBox_targetType.Dock = DockStyle.Fill;
            comboBox_targetType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_targetType.FormattingEnabled = true;
            comboBox_targetType.Location = new Point(3, 19);
            comboBox_targetType.Name = "comboBox_targetType";
            comboBox_targetType.Size = new Size(378, 23);
            comboBox_targetType.TabIndex = 0;
            // 
            // TreeModeProfileCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 136);
            Controls.Add(groupBox_name);
            Controls.Add(button_create);
            Controls.Add(groupBox_targetType);
            Name = "TreeModeProfileCreator";
            Text = "TreeModeProfileCreator";
            Load += TreeModeProfileCreator_Load;
            groupBox_name.ResumeLayout(false);
            groupBox_name.PerformLayout();
            groupBox_targetType.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_name;
        private TextBox textBox_name;
        private Button button_create;
        private GroupBox groupBox_targetType;
        private ComboBox comboBox_targetType;
    }
}