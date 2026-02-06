using Coeden.Common.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coeden.Common.Settings
{
    public class DnsRecord
    {
        public string Host { get; set; } = string.Empty;
        public DnsRecordType Type { get; set; }
        public string Value { get; set; } = string.Empty;
        public int TTL { get; set; } = 3600;
        public bool IsFromTree { get; set; } = false;
    }
}
