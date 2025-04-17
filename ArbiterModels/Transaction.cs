namespace TransactionDataApiSettlement.ArbiterModels
{
    public class Transaction
    {
        public string issuerCode { get; set; }
        public string issuer { get; set; }
        public string issuerCountry { get; set; }
        public string acquirer { get; set; }
        public string acquirerCode { get; set; }
        public string acquirerCountry { get; set; }
        public string merchantCode { get; set; }
        public string merchant { get; set; }
        public string merchantCountry { get; set; }
        public string merchantType { get; set; }
        public string merchantReference { get; set; }
        public string customerReference { get; set; }
        public string transactionReference { get; set; }
        public string transactionStore { get; set; }
        public string transactionDate { get; set; }
        public decimal? transactionAmount { get; set; }
        public string transactionType { get; set; }
        public decimal? DatetransactionAmountadded { get; set; }
        public string surchargeAmount { get; set; }
        public string transactionCurrencyCode { get; set; }
        public string transactionRate { get; set; }
        public decimal? settlementAmount { get; set; }
        public string settlementCurrencyCode { get; set; }
        public string settlementRate { get; set; }
        public string schemeAmount { get; set; }
        public string schemeCurrencyCode { get; set; }
        public string terminalType { get; set; }
        public string terminalId { get; set; }
        public string stan { get; set; }
        public string pan { get; set; }
        public string retrievalReferenceNumber { get; set; }
        public string cardScheme { get; set; }
        public string cardAcceptorCode { get; set; }
        public string cardAcceptorLocation { get; set; }
        public string sourceNodeName { get; set; }
        public string sinkNodeName { get; set; }
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public bool settled { get; set; }
        public string additionalInfo { get; set; }
        public string region { get; set; }
    }
}
