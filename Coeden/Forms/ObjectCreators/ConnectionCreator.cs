using Coeden.Common.ConnectionModels;
using Coeden.Common.Enumerators;
using Coeden.Common.Settings;
using Coeden.Common.Superclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Coeden.Forms.ObjectCreators
{
    public partial class ConnectionCreator : Form
    {
        public ConnectionModel CreatedConnection { get; private set; }

        private Dictionary<string, TextBox> _settingsControls = new Dictionary<string, TextBox>();

        public ConnectionCreator()
        {
            InitializeComponent();
        }

        private void ConnectionCreator_Load(object sender, EventArgs e)
        {
            foreach (string connectionTypeName in Enum.GetNames(typeof(ConnectionType)))
            {
                var radioButton = new RadioButton
                {
                    Text = connectionTypeName,
                    AutoSize = true,
                    Margin = new Padding(0, 5, 0, 5),
                    Tag = connectionTypeName,
                };

                radioButton.Click += radioButtonSelect;

                if (flowLayoutPanel_connectionType.Controls.Count == 0)
                {
                    radioButton.Checked = true;
                }

                flowLayoutPanel_connectionType.Controls.Add(radioButton);
            }

            groupBox_connectionType.Controls.Clear();
            groupBox_connectionType.Controls.Add(flowLayoutPanel_connectionType);

            var firstRadio = flowLayoutPanel_connectionType.Controls.OfType<RadioButton>().FirstOrDefault();
            if (firstRadio != null)
            {
                radioButtonSelect(firstRadio, EventArgs.Empty);
            }
        }

        private void radioButtonSelect(object sender, EventArgs e)
        {
            var selectedRadio = flowLayoutPanel_connectionType.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked);

            if (selectedRadio == null)
            {
                return;
            }

            ConnectionType selectedType = Enum.Parse<ConnectionType>(selectedRadio.Tag.ToString());

            flowLayoutPanel_settings.Controls.Clear();
            _settingsControls.Clear();

            var textBox_settings_note = new TextBox
            {
                PlaceholderText = "Note",
                Width = 300,
                Margin = new Padding(0, 5, 0, 5)
            };
            _settingsControls["note"] = textBox_settings_note;
            flowLayoutPanel_settings.Controls.Add(new Label { Text = "Note", AutoSize = true });
            flowLayoutPanel_settings.Controls.Add(textBox_settings_note);

            switch (selectedType)
            {
                case ConnectionType.Cloudflare:
                    var textBox_cloudflare_apiToken = new TextBox
                    {
                        PlaceholderText = "API Token",
                        Width = 300,
                        Margin = new Padding(0, 5, 0, 5)
                    };
                    _settingsControls["apiToken"] = textBox_cloudflare_apiToken;
                    flowLayoutPanel_settings.Controls.Add(new Label { Text = "API Token", AutoSize = true });
                    flowLayoutPanel_settings.Controls.Add(textBox_cloudflare_apiToken);
                    break;

                case ConnectionType.Ionos:
                    var textBox_ionos_publicPrefix = new TextBox
                    {
                        PlaceholderText = "Public Prefix",
                        Width = 300,
                        Margin = new Padding(0, 5, 0, 5)
                    };
                    var textBox_ionos_secret = new TextBox
                    {
                        PlaceholderText = "Secret",
                        Width = 300,
                        Margin = new Padding(0, 5, 0, 5),
                        UseSystemPasswordChar = true
                    };
                    _settingsControls["publicPrefix"] = textBox_ionos_publicPrefix;
                    _settingsControls["secret"] = textBox_ionos_secret;

                    flowLayoutPanel_settings.Controls.Add(new Label { Text = "Public Prefix", AutoSize = true });
                    flowLayoutPanel_settings.Controls.Add(textBox_ionos_publicPrefix);
                    flowLayoutPanel_settings.Controls.Add(new Label { Text = "Secret", AutoSize = true, Margin = new Padding(0, 10, 0, 0) });
                    flowLayoutPanel_settings.Controls.Add(textBox_ionos_secret);
                    break;

                case ConnectionType.MikroTik:
                    var textBox_mikrotik_host = new TextBox
                    {
                        PlaceholderText = "Host/IP Address",
                        Width = 300,
                        Margin = new Padding(0, 5, 0, 5)
                    };
                    var textBox_mikrotik_username = new TextBox
                    {
                        PlaceholderText = "Username",
                        Width = 300,
                        Margin = new Padding(0, 5, 0, 5)
                    };
                    var textBox_mikrotik_password = new TextBox
                    {
                        PlaceholderText = "Password",
                        Width = 300,
                        Margin = new Padding(0, 5, 0, 5),
                        UseSystemPasswordChar = true
                    };
                    _settingsControls["host"] = textBox_mikrotik_host;
                    _settingsControls["username"] = textBox_mikrotik_username;
                    _settingsControls["password"] = textBox_mikrotik_password;

                    flowLayoutPanel_settings.Controls.Add(new Label { Text = "Host", AutoSize = true });
                    flowLayoutPanel_settings.Controls.Add(textBox_mikrotik_host);
                    flowLayoutPanel_settings.Controls.Add(new Label { Text = "Username", AutoSize = true, Margin = new Padding(0, 10, 0, 0) });
                    flowLayoutPanel_settings.Controls.Add(textBox_mikrotik_username);
                    flowLayoutPanel_settings.Controls.Add(new Label { Text = "Password", AutoSize = true, Margin = new Padding(0, 10, 0, 0) });
                    flowLayoutPanel_settings.Controls.Add(textBox_mikrotik_password);
                    break;

                default:
                    throw new NotImplementedException($"Connection type {selectedType} is not yet implemented.");
            }

            groupBox_settings.Controls.Add(flowLayoutPanel_settings);
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            var selectedRadio = flowLayoutPanel_connectionType.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked);

            if (selectedRadio == null)
            {
                MessageBox.Show("Please select a connection type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConnectionType selectedType = Enum.Parse<ConnectionType>(selectedRadio.Tag.ToString());

            try
            {
                CreatedConnection = CreateConnectionByType(selectedType);

                if (CreatedConnection == null)
                {
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating connection:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ConnectionModel CreateConnectionByType(ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.Cloudflare:
                    return CreateCloudflareConnection();

                case ConnectionType.Ionos:
                    return CreateIonosConnection();

                case ConnectionType.MikroTik:
                    return CreateMikroTikConnection();

                default:
                    throw new NotImplementedException($"Connection type {connectionType} is not yet implemented.");
            }
        }
        private ConnectionModel CreateCloudflareConnection()
        {
            if (!_settingsControls.TryGetValue("apiToken", out var apiTokenBox) || string.IsNullOrWhiteSpace(apiTokenBox.Text))
            {
                MessageBox.Show("Please enter an API Token.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            string note = string.Empty;
            if (_settingsControls.TryGetValue("note", out var noteBox))
            {
                note = noteBox.Text.Trim();
            }

            return new CloudflareConnectionModel
            {
                Note = note,
                ApiToken = apiTokenBox.Text.Trim(),
                Domains = new List<DomainDetails>()
            };
        }

        private ConnectionModel CreateIonosConnection()
        {
            if (!_settingsControls.TryGetValue("publicPrefix", out var publicPrefixBox) || string.IsNullOrWhiteSpace(publicPrefixBox.Text))
            {
                MessageBox.Show("Please enter a Public Prefix.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!_settingsControls.TryGetValue("secret", out var secretBox) ||
                string.IsNullOrWhiteSpace(secretBox.Text))
            {
                MessageBox.Show("Please enter a Secret.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            string note = string.Empty;
            if (_settingsControls.TryGetValue("note", out var noteBox))
            {
                note = noteBox.Text.Trim();
            }

            return new IonosConnectionModel
            {
                Note = note,
                PublicPrefix = publicPrefixBox.Text.Trim(),
                Secret = secretBox.Text.Trim(),
                Domains = new List<DomainDetails>()
            };
        }

        private ConnectionModel CreateMikroTikConnection()
        {
            if (!_settingsControls.TryGetValue("host", out var hostBox) || string.IsNullOrWhiteSpace(hostBox.Text))
            {
                MessageBox.Show("Please enter a Host/IP Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!_settingsControls.TryGetValue("username", out var usernameBox) || string.IsNullOrWhiteSpace(usernameBox.Text))
            {
                MessageBox.Show("Please enter a Username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!_settingsControls.TryGetValue("password", out var passwordBox) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Please enter a Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            string note = string.Empty;
            if (_settingsControls.TryGetValue("note", out var noteBox))
            {
                note = noteBox.Text.Trim();
            }

            return new MikroTikConnectionModel
            {
                Note = note,
                Host = hostBox.Text.Trim(),
                Username = usernameBox.Text.Trim(),
                Password = passwordBox.Text.Trim(),
                Domains = new List<DomainDetails>()
            };
        }
    }
}
