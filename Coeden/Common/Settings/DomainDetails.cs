using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coeden.Common.Settings
{
    public class DomainDetails
    {
        public required string Name { get; set; }
        public List<DnsTarget> Targets { get; set; } = new();
    }
}
