using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PastelCsvAtmusage
    {
        public long Id { get; set; }
        public long? AccountCode { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionId { get; set; }
        public string Reference { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Description { get; set; }
    }
}
