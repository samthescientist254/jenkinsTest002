using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Holidays
    {
        public DateTime Dayofyear { get; set; }
        public bool Isholiday { get; set; }
        public string Holname { get; set; }
    }
}
