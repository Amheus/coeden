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
    public partial class IonosConnectionCreator : Form
    {
        public IonosConnectionCreator()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            this.textBox_publicPrefix.ReadOnly = true;
            this.textBox_secret.ReadOnly = true;
            this.button_create.Enabled = false;
            this.button_create.Text = "Creating...";


            SettingsWrapper settings = SettingsManager.GetSettings();
            settings.Connections.Add(new IonosConnectionModel
            {
                PublicPrefix = this.textBox_publicPrefix.Text,
                Secret = this.textBox_secret.Text
            });
            SettingsManager.SaveSettings(settings);
        }
    }
}
