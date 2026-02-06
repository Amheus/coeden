using Coeden.Common.Superclasses;

namespace Coeden.Common.Settings
{
    public class SettingsWrapper
    {
        public List<ConnectionModel> Connections { get; set; } = new();
        public List<TreeProfile> Profiles { get; set; } = new();
    }
}
