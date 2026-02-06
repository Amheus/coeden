using Coeden.Common.Enumerators;
using Coeden.Common.Settings;
using System;
using System.Windows.Forms;

namespace Coeden.Forms.ObjectCreators
{
    public partial class TreeModeProfileCreator : Form
    {
        public TreeProfile CreatedProfile { get; private set; }

        public TreeModeProfileCreator()
        {
            InitializeComponent();
        }

        private void TreeModeProfileCreator_Load(object sender, EventArgs e)
        {
            comboBox_targetType.Items.Add("Public");
            comboBox_targetType.Items.Add("Local");
            comboBox_targetType.Items.Add("Both");
            comboBox_targetType.SelectedIndex = 0;

            textBox_name.Focus();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                MessageBox.Show("Please enter a profile name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_name.Focus();
                return;
            }

            if (comboBox_targetType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a target type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_targetType.Focus();
                return;
            }

            DnsTargetType targetType = comboBox_targetType.SelectedItem.ToString() switch
            {
                "Public" => DnsTargetType.Public,
                "Local" => DnsTargetType.Local,
                "Both" => DnsTargetType.Both,
                _ => DnsTargetType.Public
            };

            CreatedProfile = new TreeProfile
            {
                Name = textBox_name.Text.Trim(),
                TargetType = targetType
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
