using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models
{
    public class SettlementModel
    {
        public string participant { get; set; }
        public string role { get; set; }
        public string settlementInstitution { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
      
    }
}
