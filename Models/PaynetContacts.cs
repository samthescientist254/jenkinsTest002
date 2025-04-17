using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PaynetContacts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Extension { get; set; }
        public string Department { get; set; }
    }
}
