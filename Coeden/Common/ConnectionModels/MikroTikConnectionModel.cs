using Coeden.Common.Superclasses;
using System.Text.Json.Serialization;

namespace Coeden.Common.ConnectionModels
{
    internal class MikroTikConnectionModel : ConnectionModel
    {
        public override string Name => "MikroTik";

        public string Host { get;set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
