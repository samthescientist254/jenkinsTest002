using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public class ReversalResponse
    {

        public string settlementReference { get; set; }
        public string settlementType { get; set; }
        public string settlementDate { get; set; }
        public List<SettlementModel> settlements { get; set; }
    }
}
