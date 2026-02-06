using Coeden.Common.Enumerators;
using System.Collections.Generic;

namespace Coeden.Common.Settings
{
    public class TreeProfile
    {
        public required string Name { get; set; }
        public DnsTargetType TargetType { get; set; } = DnsTargetType.Public;
        public List<IpNode> IpAddresses { get; set; } = new();
    }
}
