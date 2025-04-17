using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace TransactionDataApiSettlement.Models.XML
{
   
    public class Accounts
    {
        [XmlElement(ElementName = "account")]
        public Account account { get; set; }
        
    }

}
