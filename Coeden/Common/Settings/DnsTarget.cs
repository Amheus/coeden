using Coeden.Common.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coeden.Common.Settings
{
    public class DnsTarget
    {
        public required string Name { get; set; }
        public DnsTargetType Type { get; set; }
        public string Note { get; set; } = string.Empty;
        public List<DnsRecord> DnsRecords { get; set; } = new();
    }
}
