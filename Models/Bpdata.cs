using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Bpdata
    {
        public long Bpdataid { get; set; }
        public decimal? Billercode { get; set; }
        public string Reference { get; set; }
        public string Accountname { get; set; }
        public DateTime? Laststatementdate { get; set; }
        public decimal? Laststatementamount { get; set; }
        public decimal? Amountdue { get; set; }
        public decimal? Minimumamountdue { get; set; }
        public DateTime? Duedate { get; set; }
        public decimal? Bpbatchcode { get; set; }
        public string ProductId { get; set; }
    }
}
