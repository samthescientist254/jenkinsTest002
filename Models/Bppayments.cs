using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Bppayments
    {
        public string Pan { get; set; }
        public string Acquirer { get; set; }
        public decimal? Amount { get; set; }
        public DateTime LocalDate { get; set; }
        public decimal? LocalTime { get; set; }
        public string TermId { get; set; }
        public decimal Trace { get; set; }
        public string Custdata1 { get; set; }
        public string Custdata2 { get; set; }
        public decimal? Respcode { get; set; }
        public decimal? Status { get; set; }
        public string BeneficiaryId { get; set; }
        public DateTime? SettledDate { get; set; }
        public string Reference { get; set; }
        public decimal? Fee1 { get; set; }
        public decimal? Fee2 { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
