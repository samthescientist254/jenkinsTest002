using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PesaConnectExclusions
    {
        public int Id { get; set; }
        public int? InstId { get; set; }
        public string Bin { get; set; }
        public string Description { get; set; }
        public string Acquirer { get; set; }

        public InstitutionsBackups Inst { get; set; }
    }
}
