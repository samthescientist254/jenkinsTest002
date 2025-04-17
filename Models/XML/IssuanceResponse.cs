using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.XML
{
    public class IssuanceResponse
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public List<ReponseKey> responseKeys { get; set; }
    }
}
