using Coeden.Common.Superclasses;
using System.Text.Json.Serialization;

namespace Coeden.Common.ConnectionModels
{
    internal class CloudflareConnectionModel : ConnectionModel
    {
        public override string Name => "Cloudflare";

        public string ApiToken { get; set; } = string.Empty;
    }
}
