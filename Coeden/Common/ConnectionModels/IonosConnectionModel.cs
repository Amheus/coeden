using Coeden.Common.Superclasses;
using System.Text.Json.Serialization;

namespace Coeden.Common.ConnectionModels
{
    internal class IonosConnectionModel : ConnectionModel
    {
        public override string Name => "Ionos";

        public string PublicPrefix { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
    }
}
