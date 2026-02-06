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
    public partial class IpAddressCreator : Form
    {
        public string CreatedIpAddress { get; private set; }
        public IpAddressCreator()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            this.CreatedIpAddress = textBox_ipAddress.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void IpAddressCreator_Load(object sender, EventArgs e)
        {

        }
    }
}
