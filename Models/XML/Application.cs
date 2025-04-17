using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    [XmlRoot(elementName: "application")]
    public class Application
    {

        [XmlElement(ElementName = "customer")]
        public Customer customer { get; set; }
    }
}
