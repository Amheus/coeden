using Coeden.Common.Enumerators;
using Coeden.Common.Settings;
using System;
using System.Windows.Forms;

namespace Coeden.Forms.ObjectCreators
{
    public partial class DnsRecordCreator : Form
    {
        public DnsRecord CreatedRecord { get; private set; }

        public DnsRecordCreator()
        {
            InitializeComponent();
        }

        private void DnsRecordCreator_Load(object sender, EventArgs e)
        {
            comboBox_type.Items.Add("A");
            comboBox_type.Items.Add("AAAA");
            comboBox_type.Items.Add("CNAME");
            comboBox_type.Items.Add("MX");
            comboBox_type.Items.Add("TXT");

            comboBox_type.SelectedIndex = 0;

            numericUpDown_ttl.Value = 3600;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_host.Text))
            {
                MessageBox.Show("Please enter a host/name for the DNS record.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_host.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_value.Text))
            {
                MessageBox.Show("Please enter a value for the DNS record.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_value.Focus();
                return;
            }

            if (comboBox_type.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a record type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_type.Focus();
                return;
            }

            DnsRecordType recordType = comboBox_type.SelectedItem.ToString() switch
            {
                "A" => DnsRecordType.A,
                "AAAA" => DnsRecordType.AAAA,
                "CNAME" => DnsRecordType.CNAME,
                "MX" => DnsRecordType.MX,
                "TXT" => DnsRecordType.TXT,
                _ => DnsRecordType.A
            };

            CreatedRecord = new DnsRecord
            {
                Host = textBox_host.Text.Trim(),
                Type = recordType,
                Value = textBox_value.Text.Trim(),
                TTL = (int)numericUpDown_ttl.Value,
                IsFromTree = false
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
