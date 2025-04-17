using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Profiles
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public int ShclogPageSize { get; set; }
        public int AtmbalPageSize { get; set; }
    }
}
