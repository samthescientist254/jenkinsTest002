using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.XML
{
    public class KeyResponse
    {
        public string key { get; set; }
        public string expiryTime { get; set; }
        public string responseMessage { get; set; }
        public string responseCode { get; set; }
    }
}
