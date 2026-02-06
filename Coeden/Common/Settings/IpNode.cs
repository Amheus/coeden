using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coeden.Common.Settings
{
    public class IpNode
    {
        public string IpAddress { get; set; } = string.Empty;
        public List<HostNode> Hosts { get; set; } = new();
    }
}
