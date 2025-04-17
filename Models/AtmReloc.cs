using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class AtmReloc
    {
        public int Id { get; set; }
        public DateTime? RelocDate { get; set; }
        public string Termid { get; set; }
        public string OldLocation { get; set; }
        public string OldTermid { get; set; }
    }
}
