using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models
{
    public class issuancekeys
    {
        public int id { get; set; }
        public DateTime datein { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int instid { get; set; }
        public string aeskey { get; set; }
        public int active { get; set; }
        public string publickeypath { get; set; }
    }
}
