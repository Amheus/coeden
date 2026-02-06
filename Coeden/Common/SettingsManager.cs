using Coeden.Common.Settings;
using System;
using System.Net.NetworkInformation;
using System.Text.Json;

namespace Coeden.Common
{
    internal static class SettingsManager
    {
        internal static SettingsWrapper CurrentSettingsInstance = new();


        private static readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = false
        };

        internal static SettingsWrapper GetSettings()
        {
            try
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.Connections))
                {
                    return CreateDefaultSettings();
                }

                var settings = JsonSerializer.Deserialize<SettingsWrapper>(
                    Properties.Settings.Default.Connections, _options);

                return settings ?? CreateDefaultSettings();
            }
            catch (JsonException)
            {
                return CreateDefaultSettings();
            }
        }

        internal static void SaveSettings(SettingsWrapper settings)
        {
            Properties.Settings.Default.Connections = JsonSerializer.Serialize(settings, _options);
            Properties.Settings.Default.Save();
        }

        private static SettingsWrapper CreateDefaultSettings()
        {
            var defaultSettings = new SettingsWrapper();
            SaveSettings(defaultSettings);
            return defaultSettings;
        }
    }
}
