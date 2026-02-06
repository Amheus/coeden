using Coeden.Common.ConnectionModels;
using Coeden.Common.Settings;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Coeden.Common.Superclasses
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(CloudflareConnectionModel), "cloudflare")]
    [JsonDerivedType(typeof(IonosConnectionModel), "ionos")]
    public abstract class ConnectionModel
    {
        public abstract string Name { get; }
        public List<DomainDetails> Domains { get; set; } = new();
    }
}
