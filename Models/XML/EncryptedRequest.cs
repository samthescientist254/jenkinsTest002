using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.XML
{
    public class EncryptedRequest
    {
        public string enc { get; set; }
        public string signature { get; set; }
        public int instid { get; set; }
    }
}
