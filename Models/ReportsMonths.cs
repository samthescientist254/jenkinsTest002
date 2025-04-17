using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ReportsMonths
    {
        public short MonthNum { get; set; }
        public string MonthName { get; set; }
        public string MonthAbbrev { get; set; }
    }
}
