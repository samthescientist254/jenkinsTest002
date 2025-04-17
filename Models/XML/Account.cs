using Newtonsoft.Json;
using System.Xml.Serialization;
namespace TransactionDataApiSettlement.Models.XML
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class Account
    {
        [XmlElement("riskDomains")]
        public RiskDomains riskDomains { get; set; }
        [XmlElement("cards")]
        public Cards cards { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string templateCode { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string creditLimit { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankAccount { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankSortCode { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankBranch { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankName { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankDdEnabled { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankDdAmount { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankDdPercentage { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankDdCombination { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bankAccCountry { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minPayAmount { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minPayPercentage { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minPayCombination { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stmtTriggerBal { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StmtMailOption { get; set; }
    }
}
