using Coeden.Common;
using Coeden.Common.ConnectionModels;
using Coeden.Common.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coeden.Forms.ConnectionCreators
{
    public partial class MikroTikConnectionCreator : Form
    {
        public MikroTikConnectionCreator()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            this.textBox_username.ReadOnly = true;
            this.textBox_password.ReadOnly = true;
            this.button_create.Enabled = false;
            this.button_create.Text = "Creating...";


            SettingsWrapper settings = SettingsManager.GetSettings();
            settings.Connections.Add(new MikroTikConnectionModel
            {
                Username = this.textBox_username.Text,
                Password = this.textBox_password.Text
            });
            SettingsManager.SaveSettings(settings);
        }
    }
}
