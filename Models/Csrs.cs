using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Csrs
    {
        public int Id { get; set; }
        public int Csrid { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string Termid { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
