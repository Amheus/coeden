using Coeden.Common.Enumerators;
using Coeden.Common.Settings;
using System;
using System.Windows.Forms;

namespace Coeden.Forms.ObjectCreators
{
    public partial class DnsTargetCreator : Form
    {
        public DnsTarget CreatedTarget { get; private set; }

        public DnsTargetCreator()
        {
            InitializeComponent();
        }

        private void DnsTargetCreator_Load(object sender, EventArgs e)
        {
            comboBox_type.Items.Add("Public");
            comboBox_type.Items.Add("Local");
            comboBox_type.Items.Add("Both");
            comboBox_type.SelectedIndex = 0;

            textBox_name.Focus();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                MessageBox.Show("Please enter a target name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_name.Focus();
                return;
            }

            if (comboBox_type.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a target type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_type.Focus();
                return;
            }

            DnsTargetType targetType = comboBox_type.SelectedItem.ToString() switch
            {
                "Public" => DnsTargetType.Public,
                "Local" => DnsTargetType.Local,
                "Both" => DnsTargetType.Both,
                _ => DnsTargetType.Public
            };

            CreatedTarget = new DnsTarget
            {
                Name = textBox_name.Text.Trim(),
                Type = targetType,
                Note = textBox_notes.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
