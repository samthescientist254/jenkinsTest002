using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PptLogCategories
    {
        public int Id { get; set; }
        public string LogCategory { get; set; }
        public string Description { get; set; }
    }
}
