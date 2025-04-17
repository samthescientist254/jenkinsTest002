using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    public class People
    {
            
        [XmlElement("person")]
        public Person person { get; set; }
    }
}
