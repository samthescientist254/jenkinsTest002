using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    public class Cards
    {


        [XmlElement(ElementName = "card")]
        public Card card { get; set; }
    }
}
