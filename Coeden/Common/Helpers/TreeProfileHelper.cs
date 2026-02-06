using Coeden.Common.Settings;
using System.Collections.Generic;

namespace Coeden.Common.Helpers
{
    public static class TreeProfileHelper
    {
        public static List<DnsRecord> GenerateDnsRecords(TreeProfile profile)
        {
            var records = new List<DnsRecord>();

            foreach (var ipNode in profile.IpAddresses)
            {
                foreach (var host in ipNode.Hosts)
                {
                    records.Add(new DnsRecord
                    {
                        Host = host.Hostname,
                        Type = Enumerators.DnsRecordType.A,
                        Value = ipNode.IpAddress,
                        TTL = 3600,
                        IsFromTree = true
                    });

                    GenerateCnameRecordsRecursive(host, host.Hostname, records);
                }
            }

            return records;
        }

        private static void GenerateCnameRecordsRecursive(HostNode parent, string targetHostname, List<DnsRecord> records)
        {
            foreach (var child in parent.CnameChildren)
            {
                records.Add(new DnsRecord
                {
                    Host = child.Hostname,
                    Type = Enumerators.DnsRecordType.CNAME,
                    Value = targetHostname,
                    TTL = 3600,
                    IsFromTree = true
                });

                GenerateCnameRecordsRecursive(child, child.Hostname, records);
            }
        }
    }
}
