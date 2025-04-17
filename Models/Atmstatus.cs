using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Atmstatus
    {
        public int Id { get; set; }
        public DateTime? TimeReported { get; set; }
        public string Termid { get; set; }
        public string UpdatedBy { get; set; }
        public int? StatusCode { get; set; }
        public string Description { get; set; }
        public string ActionTaken { get; set; }
        public DateTime? TimeOfAction { get; set; }
    }
}
