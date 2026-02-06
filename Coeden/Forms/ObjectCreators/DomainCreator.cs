using System;
using System.Windows.Forms;

namespace Coeden.Forms.ObjectCreators
{
    public partial class DomainCreator : Form
    {
        public string DomainName { get; private set; } = string.Empty;

        public DomainCreator()
        {
            InitializeComponent();
        }

        private void DomainCreator_Load(object sender, EventArgs e)
        {
            textBox_name.Focus();
            this.AcceptButton = button_create;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                MessageBox.Show("Please enter a domain name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_name.Focus();
                return;
            }

            this.DomainName = textBox_name.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
