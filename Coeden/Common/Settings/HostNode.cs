using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coeden.Common.Settings
{
    public class HostNode
    {
        public string Hostname { get; set; } = string.Empty;
        public List<HostNode> CnameChildren { get; set; } = new();
    }
}
