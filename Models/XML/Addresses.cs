using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    public class Addresses
    {   
        [XmlElement(ElementName = "address")]
        public Address address { get; set; }
    }
}
