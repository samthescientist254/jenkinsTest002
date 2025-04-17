namespace TransactionDataApiSettlement.Models.XML
{
    public class MySetting
    {
        public string FilesPath { get; set; }
        public string initiatorRid { get; set; }
        public string processorInstName { get; set; }
        public string lifePhase { get; set; }
        public string kind { get; set; }
        public string categoryText { get; set; }
        public string txurl { get; set; }
        public string txpaths { get; set; }
        public string filename { get; set; }
        public string remotepath { get; set; }
        public string kadiurl { get; set; }

        public string smtpclient { get; set; }
        public string smtpport { get; set; }
        public string adminEmail { get; set; }
        public string mailFrom { get; set; }
        public string netUsr { get; set; }
        public string recipients { get; set; }
        public string netPas { get; set; }
        public string emailTemplate { get; set; }
    }
}
