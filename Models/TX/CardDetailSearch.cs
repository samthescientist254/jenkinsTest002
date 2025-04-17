using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.TX
{
    public class CardDetailSearch
    {
        public int instid { get; set; }
        public string startDate { get; set; }
        public string enddate { get; set; }
    }
}
