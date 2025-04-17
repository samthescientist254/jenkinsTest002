using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Calendar
    {
        public DateTime Dayofyear { get; set; }
        public bool? Isweekday { get; set; }
        public bool? Isholiday { get; set; }
        public short? Y { get; set; }
        public short? Fy { get; set; }
        public byte? Q { get; set; }
        public byte? M { get; set; }
        public byte? D { get; set; }
        public byte? Dw { get; set; }
        public string Monthname { get; set; }
        public string Dayname { get; set; }
        public byte? W { get; set; }
        public string Holname { get; set; }
    }
}
