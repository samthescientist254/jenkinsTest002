using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ShclogRoutedToVisa
    {
        public long Id { get; set; }
        public long ShclogId { get; set; }
        public string ShclogName { get; set; }
    }
}
