using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coeden.Forms.ObjectCreators
{
    public partial class HostnameCreator : Form
    {
        public string CreatedHostname { get; private set; }
        public HostnameCreator()
        {
            InitializeComponent();
        }

        private void HostnameCreator_Load(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            this.CreatedHostname = textBox_hostname.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
