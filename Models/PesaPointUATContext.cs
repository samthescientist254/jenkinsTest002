using Microsoft.EntityFrameworkCore;

namespace TransactionDataApiSettlement.Models
{
    public partial class PesaPointUATContext : DbContext
    {
        public PesaPointUATContext()
        {
        }

        public PesaPointUATContext(DbContextOptions<PesaPointUATContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Atm> Atm { get; set; }
        public virtual DbSet<AtmAccounts> AtmAccounts { get; set; }
        public virtual DbSet<Atmcutoff> Atmcutoff { get; set; }
        public virtual DbSet<issuancekeys> issuancekeys { get; set; }
        public virtual DbSet<Atmcutoff2> Atmcutoff2 { get; set; }
        public virtual DbSet<Atmpaynet> Atmpaynet { get; set; }
        public virtual DbSet<AtmReloc> AtmReloc { get; set; }
        public virtual DbSet<Atmstatus> Atmstatus { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<Batches> Batches { get; set; }
        public virtual DbSet<BinsBackups> BinsBackups { get; set; }
        public virtual DbSet<BinsPesaconnect> BinsPesaconnect { get; set; }
        public virtual DbSet<Bpdata> Bpdata { get; set; }
        public virtual DbSet<Bppayments> Bppayments { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<CalendarHoliday> CalendarHoliday { get; set; }
        public virtual DbSet<ChangeLog> ChangeLog { get; set; }
        public virtual DbSet<CscBins> CscBins { get; set; }
        public virtual DbSet<Csrs> Csrs { get; set; }
        public virtual DbSet<CustStmts> CustStmts { get; set; }
        public virtual DbSet<DailyIssuerStats> DailyIssuerStats { get; set; }
        public virtual DbSet<DailyTxnSummary> DailyTxnSummary { get; set; }
        public virtual DbSet<DataTransferPackageVariables> DataTransferPackageVariables { get; set; }
        public virtual DbSet<DeleteShclog76> DeleteShclog76 { get; set; }
        public virtual DbSet<Deposits> Deposits { get; set; }
        public virtual DbSet<DepositUsageMonitor> DepositUsageMonitor { get; set; }
        public virtual DbSet<EmailAccounts> EmailAccounts { get; set; }
        public virtual DbSet<EmailAlerts> EmailAlerts { get; set; }
        public virtual DbSet<Emailoutbox> Emailoutbox { get; set; }
        public virtual DbSet<EodLog> EodLog { get; set; }
        public virtual DbSet<Erroreps> Erroreps { get; set; }
        public virtual DbSet<FactShclog> FactShclog { get; set; }
        public virtual DbSet<FraudAlertConfigHistoryPrev> FraudAlertConfigHistoryPrev { get; set; }
        public virtual DbSet<FraudAlertFiltersHistoryPrev> FraudAlertFiltersHistoryPrev { get; set; }
        public virtual DbSet<FraudAlertFiltersPrev> FraudAlertFiltersPrev { get; set; }
        public virtual DbSet<FraudAlertLog> FraudAlertLog { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<HourlyWithdrawalsPerInst> HourlyWithdrawalsPerInst { get; set; }
        public virtual DbSet<Institutions> Institutions { get; set; }
        public virtual DbSet<InstitutionsBackups> InstitutionsBackups { get; set; }
        public virtual DbSet<KenyaBins> KenyaBins { get; set; }
        public virtual DbSet<LastRunTracking> LastRunTracking { get; set; }
        public virtual DbSet<LocalBins> LocalBins { get; set; }
        public virtual DbSet<LocationMaps> LocationMaps { get; set; }
        public virtual DbSet<M9001data> M9001data { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MonthlyTransactionsPerAcquirer> MonthlyTransactionsPerAcquirer { get; set; }
        public virtual DbSet<Mpesacommissions> Mpesacommissions { get; set; }
        public virtual DbSet<MpesacommissionsDtb> MpesacommissionsDtb { get; set; }
        public virtual DbSet<Msgtypes> Msgtypes { get; set; }
        public virtual DbSet<Msmq> Msmq { get; set; }
        public virtual DbSet<NagiosCassettes> NagiosCassettes { get; set; }
        public virtual DbSet<NoonStats> NoonStats { get; set; }
        public virtual DbSet<PastelCsvAtmusage> PastelCsvAtmusage { get; set; }
        public virtual DbSet<PastelCsvAtmusageReversals> PastelCsvAtmusageReversals { get; set; }
        public virtual DbSet<PaynetContacts> PaynetContacts { get; set; }
        public virtual DbSet<Pcodes> Pcodes { get; set; }
        public virtual DbSet<PesaConnectExclusions> PesaConnectExclusions { get; set; }
        public virtual DbSet<PhoneAccounts> PhoneAccounts { get; set; }
        public virtual DbSet<PossibleFraud> PossibleFraud { get; set; }
        public virtual DbSet<PptBins> PptBins { get; set; }
        public virtual DbSet<PptBinsBackups> PptBinsBackups { get; set; }
        public virtual DbSet<Pptcharges> Pptcharges { get; set; }
        public virtual DbSet<PptLog> PptLog { get; set; }
        public virtual DbSet<PptLogCategories> PptLogCategories { get; set; }
        public virtual DbSet<PptRevenue> PptRevenue { get; set; }
        public virtual DbSet<Ppupload> Ppupload { get; set; }
        public virtual DbSet<PrimeAccounts> PrimeAccounts { get; set; }
        public virtual DbSet<PrimeAcctypes> PrimeAcctypes { get; set; }
        public virtual DbSet<PrimeTtypes> PrimeTtypes { get; set; }
        public virtual DbSet<PrimeTumPostings> PrimeTumPostings { get; set; }
        public virtual DbSet<ProcessTracking> ProcessTracking { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<QueryLog> QueryLog { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<ReportsMonths> ReportsMonths { get; set; }
        public virtual DbSet<Repparams> Repparams { get; set; }
        public virtual DbSet<Respcodes> Respcodes { get; set; }
        public virtual DbSet<Revenue> Revenue { get; set; }
        public virtual DbSet<Reversals> Reversals { get; set; }
        public virtual DbSet<SettlementProcGrps> SettlementProcGrps { get; set; }
        public virtual DbSet<SettlementProcLog> SettlementProcLog { get; set; }
        public virtual DbSet<SettlStatementData> SettlStatementData { get; set; }
        public virtual DbSet<ShcdataIntegrity> ShcdataIntegrity { get; set; }
        public virtual DbSet<Shclog> Shclog { get; set; }
        public virtual DbSet<Shclog732Vs76> Shclog732Vs76 { get; set; }
        public virtual DbSet<ShclogAudit> ShclogAudit { get; set; }
        public virtual DbSet<ShclogBackup> ShclogBackup { get; set; }
        public virtual DbSet<ShclogDev> ShclogDev { get; set; }
        public virtual DbSet<ShclogNonPpt> ShclogNonPpt { get; set; }
        public virtual DbSet<ShclogNonPptDumps> ShclogNonPptDumps { get; set; }
        public virtual DbSet<ShclogNonPptExt> ShclogNonPptExt { get; set; }
        public virtual DbSet<ShclogNonPptOld> ShclogNonPptOld { get; set; }
        public virtual DbSet<ShclogNonPptTest> ShclogNonPptTest { get; set; }
        public virtual DbSet<ShclogPastelDataDailySummary> ShclogPastelDataDailySummary { get; set; }
        public virtual DbSet<ShclogPostilion> ShclogPostilion { get; set; }
        public virtual DbSet<ShclogRevaudit> ShclogRevaudit { get; set; }
        public virtual DbSet<ShclogRoutedToVisa> ShclogRoutedToVisa { get; set; }
        public virtual DbSet<ShclogTest> ShclogTest { get; set; }
        public virtual DbSet<SmsAccounts> SmsAccounts { get; set; }
        public virtual DbSet<SmsAlerts> SmsAlerts { get; set; }
        public virtual DbSet<Smscharges> Smscharges { get; set; }
        public virtual DbSet<SmsFiles> SmsFiles { get; set; }
        public virtual DbSet<Smsgatewaystatus> Smsgatewaystatus { get; set; }
        public virtual DbSet<SmsgatewaystatusOld> SmsgatewaystatusOld { get; set; }
        public virtual DbSet<SmsgwayUsers> SmsgwayUsers { get; set; }
        public virtual DbSet<SmsHttplinkExceptions> SmsHttplinkExceptions { get; set; }
        public virtual DbSet<Smsinbox> Smsinbox { get; set; }
        public virtual DbSet<SmslinkTypes> SmslinkTypes { get; set; }
        public virtual DbSet<Smsoutbox> Smsoutbox { get; set; }
        public virtual DbSet<SmsQueues> SmsQueues { get; set; }
        public virtual DbSet<SmsRouting> SmsRouting { get; set; }
        public virtual DbSet<SmssenderIds> SmssenderIds { get; set; }
        public virtual DbSet<SmsStatusChanges> SmsStatusChanges { get; set; }
        public virtual DbSet<Statements> Statements { get; set; }
        public virtual DbSet<Taskreps> Taskreps { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<ThresholdAlerts> ThresholdAlerts { get; set; }
        public virtual DbSet<TkReversals> TkReversals { get; set; }
        public virtual DbSet<TrxnTypes> TrxnTypes { get; set; }
        public virtual DbSet<UptimeLog> UptimeLog { get; set; }
        public virtual DbSet<UserAllowedSenderIds> UserAllowedSenderIds { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WgpStmts> WgpStmts { get; set; }
        public virtual DbSet<Wservices> Wservices { get; set; }

        // Unable to generate entity type for table 'dbo.CSRs_Deleted'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ManualChangeLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.csc_tempdata'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.csc_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bins_prev'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_very_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.condundrumids'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MPESARepeatCardUsageTbl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bins_left_ppt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.online_acquirerlog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bins_bak_preemv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.settings'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nic_pin_nochange'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nic_Pin_change'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MPESAMonthlyWeeklyStats'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MPESAMonthlyHourlyStats'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MOBILENETWORKS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MISSING_DATA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MobileTEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MPESACommissions_ALL_Previous'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ppt_bins_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MPESACommissions_ALL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ppt_guards'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FX_MOBILEPINS_WRONGPIN2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FX_MOBILEPINS_WRONGPIN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FX_MOBILEPINS_REISSUED'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FINAOutsourceBilling'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FuzzyLookupMatchIndex_FLRef_110907_11:46:02_11164_5731246d-d750-4e08-87bc-53277d58e6ac'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.fleet_downtime'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FuzzyLookupMatchIndex'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.fraudwatch_bins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.exch_rates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.postilion_uncertain'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sms_status'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.paynetresp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PostilionNodes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.calendar_2007'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.delete_charges'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dbo.atm_downtime'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PaymentsID_Holder'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BRSOUTDATA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_live'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MOBILESTMTS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PESATRASACTCommissions_CWDs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_flush_buffer_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MOBILERECHARGE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_flush_buffer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MOBILEPINSTATUSCHANGES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUTHREV_DATA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MOBILEPINS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.postilion_reimport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ZAPCommissions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DummyDate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.audit_trail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.email_alerts_temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.user_authcodes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.banks_deleted'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.voucher_decrypt_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GuardCellphones'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VISA_TXNS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nic_Active_cards'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_offsite'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.visa_bins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_non_ppt_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.visa_bin_import_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.KenswitchVolumes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NagiosErrors'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SHCLOG_NON_PPT_reversed_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpshclog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TmpDTBPesaConn'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Telkom Kenya test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_SHCLOG_WRONG_ACQUIRER_76'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_SHCLOG_WRONG_ACQUIRER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_routedviavisa'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.taskstest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TelkomKenyaCommissions_CWD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_NIC_REVERSALS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MPESAUniqueCustomers'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.testin12344'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CardsUsedYesterday'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ISTCARD_COPY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_suspect'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_MPESAUniqueCustomers'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_CWD_STATS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PESACONN_TXN_SUMMARY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_ATMREGN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_ATMPROVINCES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_atm3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HourlyWithdrawals'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tasks_prev'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.holidaytemp2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SMS_FILES_RESOLVED'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.params'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NIC_B2C_Commissions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_shclog_non_ppt_dumps_Summary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sms_deliv_status_codes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sms_clickatell_import'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PesaPointStats_Julia'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BPBENEFICIARIES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Dimension.Bins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BP_Vodafasta_test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BP_Vodafasta'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bins_problem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sms_route_changed'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.unbilled_txns'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_deleted_records'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.downtime_log_toDelete'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.downtime_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_audit_76'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DimBins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_audit_73'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.vbins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pesaconnect_acquirers'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VAT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TelkomKenyaMerchantCommissions_CWD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.stmnt_summary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.smsoutbox_messedup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Reports_Hours'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.run_away_alert_testing'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.run_away_alert'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.delete_shclog_reversed'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_non_ppt_dupl_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Reports_Days'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Query'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BillPayCommissions_CWD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GTB_ctl_file'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ppt_bins_bak_preemv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TelkomKenyaMerchantCommissions_CWD1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ATMREVENUE_TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GTB_CTL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BillPayCommissions_CWD1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SHCLOG_reversed_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mobifin_test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.shclog_reversed'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AtmErrorStatusCodes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FAILEDVISAUPLOAD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SUCCESSVISAUPLOADS1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.atmbal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.atm2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FraudAlertConfig_PREV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ATM_TMP_B4GTBNK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRIME_POSTING_RULES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.provinces'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.procgrp_changes'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
               
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atm>(entity =>
            {
                entity.HasKey(e => e.Termid);

                entity.ToTable("atm");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Actualload)
                    .HasColumnName("ACTUALLOAD")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Alertsfromhr).HasColumnName("ALERTSFROMHR");

                entity.Property(e => e.Alertstohr).HasColumnName("ALERTSTOHR");

                entity.Property(e => e.Bal76).HasColumnName("BAL_76");

                entity.Property(e => e.Balpercent)
                    .HasColumnName("BALPERCENT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Budgetcount).HasColumnName("BUDGETCOUNT");

                entity.Property(e => e.Budgetload)
                    .HasColumnName("BUDGETLOAD")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CommentUpdateTm)
                    .HasColumnName("COMMENT_UPDATE_TM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Curbalance)
                    .HasColumnName("CURBALANCE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Firsttxndate)
                    .HasColumnName("FIRSTTXNDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gprsno)
                    .HasColumnName("GPRSNO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastloaddate)
                    .HasColumnName("LASTLOADDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdateby)
                    .HasColumnName("LASTUPDATEBY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdatefrom)
                    .HasColumnName("LASTUPDATEFROM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Moveto76)
                    .HasColumnName("MOVETO_76")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nagiostatus)
                    .HasColumnName("NAGIOSTATUS")
                    .HasColumnType("text");

                entity.Property(e => e.PesaconnDt)
                    .HasColumnName("PESACONN_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Provinceid).HasColumnName("PROVINCEID");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Selected).HasColumnName("SELECTED");

                entity.Property(e => e.ShowBal)
                    .HasColumnName("SHOW_BAL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<AtmAccounts>(entity =>
            {
                entity.HasKey(e => new { e.Instabbrev, e.Acctkey });

                entity.ToTable("atm_accounts");

                entity.Property(e => e.Instabbrev)
                    .HasColumnName("INSTABBREV")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Acctkey)
                    .HasColumnName("ACCTKEY")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Accountname)
                    .HasColumnName("ACCOUNTNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Accountno)
                    .HasColumnName("ACCOUNTNO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcode)
                    .HasColumnName("BANKCODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Branchcode)
                    .HasColumnName("BRANCHCODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Atmcutoff>(entity =>
            {
                entity.HasKey(e => new { e.Rptgrp, e.Termid });

                entity.ToTable("ATMCUTOFF");

                entity.Property(e => e.Rptgrp).HasColumnName("RPTGRP");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cutoff).HasColumnName("CUTOFF");
            });

            modelBuilder.Entity<Atmcutoff2>(entity =>
            {
                entity.HasKey(e => new { e.Bin, e.Termid });

                entity.ToTable("ATMCUTOFF2");

                entity.Property(e => e.Bin)
                    .HasColumnName("BIN")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dtfrom)
                    .HasColumnName("DTFROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dtto)
                    .HasColumnName("DTTO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<issuancekeys>(entity =>
            {
                entity.HasKey(e => e.id);

                entity.ToTable("issuancekeys");

                entity.Property(e => e.username)
                    .HasColumnName("username")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.password)
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.instid)
                    .HasColumnName("instid");


                entity.Property(e => e.aeskey)
                 .HasColumnName("aeskey")
                    .HasMaxLength(255);

                entity.Property(e => e.datein)
              .HasColumnName("datein")
              .HasColumnType("datetime");

                entity.Property(e => e.active)
                    .HasColumnName("active")
                   .HasMaxLength(50);

                entity.Property(e => e.publickeypath)
                .HasColumnName("publickeypath")
                   .HasMaxLength(50);

            });

            modelBuilder.Entity<Atmpaynet>(entity =>
            {
                entity.HasKey(e => new { e.Unit, e.Bin });

                entity.ToTable("ATMPAYNET");

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bin)
                    .HasColumnName("BIN")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DtFrom)
                    .HasColumnName("DT_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtTo)
                    .HasColumnName("DT_TO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AtmReloc>(entity =>
            {
                entity.HasKey(e => e.Termid);

                entity.ToTable("atm_reloc");

                entity.Property(e => e.Termid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OldLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldTermid)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RelocDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Atmstatus>(entity =>
            {
                entity.ToTable("atmstatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionTaken)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOfAction).HasColumnType("datetime");

                entity.Property(e => e.TimeReported).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Banks>(entity =>
            {
                entity.HasKey(e => e.Issuer);

                entity.ToTable("banks");

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Bank)
                    .HasColumnName("BANK")
                    .HasMaxLength(50);

                entity.Property(e => e.Countryshortname)
                    .HasColumnName("COUNTRYSHORTNAME")
                    .HasMaxLength(10);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(20);

                entity.Property(e => e.Product)
                    .HasColumnName("PRODUCT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shortname)
                    .HasColumnName("SHORTNAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Batches>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProcGrp, e.StmtDate });

                entity.ToTable("batches");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProcGrp)
                    .HasColumnName("proc_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StmtDate)
                    .HasColumnName("stmt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BinsBackups>(entity =>
            {
                entity.HasKey(e => new { e.Bin, e.InstId });

                entity.ToTable("bins_backups");

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InstId).HasColumnName("inst_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BalRate)
                    .HasColumnName("bal_rate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BillingGrp)
                    .HasColumnName("billing_grp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Binlength).HasColumnName("BINLength");

                entity.Property(e => e.BpEnabled).HasColumnName("bp_enabled");

                entity.Property(e => e.BpRate)
                    .HasColumnName("bp_rate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Cur)
                    .HasColumnName("cur")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cutofftime).HasColumnName("cutofftime");

                entity.Property(e => e.CwdRate)
                    .HasColumnName("cwd_rate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExchRate)
                    .HasColumnName("exch_rate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Holidays)
                    .IsRequired()
                    .HasColumnName("holidays")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IstInstid).HasColumnName("ist_instid");

                entity.Property(e => e.JoinDate)
                    .HasColumnName("join_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeaveDateTime)
                    .HasColumnName("leave_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MigratedToPostilionOn).HasColumnType("datetime");

                entity.Property(e => e.PostilionSinkName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PpEnabled).HasColumnName("pp_enabled");

                entity.Property(e => e.PpRate)
                    .HasColumnName("pp_rate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ProcGrp)
                    .IsRequired()
                    .HasColumnName("proc_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RejRate)
                    .HasColumnName("rej_rate")
                    .HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<BinsPesaconnect>(entity =>
            {
                entity.HasKey(e => new { e.Issuer, e.Acquirer });

                entity.ToTable("bins_pesaconnect");

                entity.Property(e => e.Issuer)
                    .HasColumnName("issuer")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("acquirer")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InstId).HasColumnName("inst_id");
            });

            modelBuilder.Entity<Bpdata>(entity =>
            {
                entity.ToTable("BPDATA");

                entity.Property(e => e.Bpdataid)
                    .HasColumnName("BPDATAID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accountname)
                    .HasColumnName("ACCOUNTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amountdue)
                    .HasColumnName("AMOUNTDUE")
                    .HasColumnType("decimal(23, 6)");

                entity.Property(e => e.Billercode)
                    .HasColumnName("BILLERCODE")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Bpbatchcode)
                    .HasColumnName("BPBATCHCODE")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Duedate)
                    .HasColumnName("DUEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Laststatementamount)
                    .HasColumnName("LASTSTATEMENTAMOUNT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Laststatementdate)
                    .HasColumnName("LASTSTATEMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Minimumamountdue)
                    .HasColumnName("MINIMUMAMOUNTDUE")
                    .HasColumnType("decimal(23, 6)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasColumnName("REFERENCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bppayments>(entity =>
            {
                entity.HasKey(e => new { e.LocalDate, e.TermId, e.Trace });

                entity.ToTable("BPPAYMENTS");

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TermId)
                    .HasColumnName("TERM_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(26, 8)");

                entity.Property(e => e.BeneficiaryId)
                    .HasColumnName("BENEFICIARY_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Custdata1)
                    .HasColumnName("CUSTDATA1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Custdata2)
                    .HasColumnName("CUSTDATA2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fee1)
                    .HasColumnName("FEE1")
                    .HasColumnType("decimal(26, 8)");

                entity.Property(e => e.Fee2)
                    .HasColumnName("FEE2")
                    .HasColumnType("decimal(26, 8)");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasColumnName("REFERENCE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.SettledDate)
                    .HasColumnName("SETTLED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("decimal(38, 0)");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.Dayofyear);

                entity.Property(e => e.Dayofyear)
                    .HasColumnName("dayofyear")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dayname)
                    .HasColumnName("dayname")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Dw).HasColumnName("DW");

                entity.Property(e => e.Fy).HasColumnName("FY");

                entity.Property(e => e.Holname)
                    .HasColumnName("holname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Isholiday).HasColumnName("isholiday");

                entity.Property(e => e.Isweekday).HasColumnName("isweekday");

                entity.Property(e => e.Monthname)
                    .HasColumnName("monthname")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CalendarHoliday>(entity =>
            {
                entity.HasKey(e => e.Dayofyear);

                entity.ToTable("Calendar_holiday");

                entity.Property(e => e.Dayofyear)
                    .HasColumnName("dayofyear")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dayname)
                    .HasColumnName("dayname")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Dw).HasColumnName("DW");

                entity.Property(e => e.Fy).HasColumnName("FY");

                entity.Property(e => e.IsHoliday).HasColumnName("isHoliday");

                entity.Property(e => e.IsWeekday).HasColumnName("isWeekday");

                entity.Property(e => e.Monthname)
                    .HasColumnName("monthname")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChangeLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TabName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CscBins>(entity =>
            {
                entity.HasKey(e => e.Bin);

                entity.ToTable("csc_bins");

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Inst)
                    .HasColumnName("inst")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Csrs>(entity =>
            {
                entity.HasKey(e => e.Csrid);

                entity.ToTable("CSRs");

                entity.Property(e => e.Csrid)
                    .HasColumnName("CSRID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MidName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustStmts>(entity =>
            {
                entity.HasKey(e => new { e.InstId, e.StmtDate });

                entity.ToTable("cust_stmts");

                entity.Property(e => e.InstId).HasColumnName("InstID");

                entity.Property(e => e.StmtDate).HasColumnType("datetime");

                entity.Property(e => e.BalBfw)
                    .HasColumnName("BalBFW")
                    .HasColumnType("money");

                entity.Property(e => e.BalCfw)
                    .HasColumnName("BalCFW")
                    .HasColumnType("money");

                entity.Property(e => e.CashTaken).HasColumnType("money");

                entity.Property(e => e.DepositsSincePrevious).HasColumnType("money");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastDepositAmt).HasColumnType("money");

                entity.Property(e => e.LastDepositDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousCashTaken).HasColumnType("money");

                entity.Property(e => e.PreviousStmtDate).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.TotalDepositAmt).HasColumnType("money");
            });

            modelBuilder.Entity<DailyIssuerStats>(entity =>
            {
                entity.HasKey(e => new { e.LocalDate, e.Institution, e.Issuerabbrev });

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Institution)
                    .HasColumnName("INSTITUTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuerabbrev)
                    .HasColumnName("ISSUERABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Balenqcount).HasColumnName("BALENQCOUNT");

                entity.Property(e => e.CalcDate)
                    .HasColumnName("CALC_DATE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cwdamount)
                    .HasColumnName("CWDAMOUNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cwdcount).HasColumnName("CWDCOUNT");

                entity.Property(e => e.Failedtxns).HasColumnName("FAILEDTXNS");

                entity.Property(e => e.Fundstrfamount).HasColumnName("FUNDSTRFAMOUNT");

                entity.Property(e => e.Fundstrfcount).HasColumnName("FUNDSTRFCOUNT");

                entity.Property(e => e.Ministmtcount).HasColumnName("MINISTMTCOUNT");

                entity.Property(e => e.Ppamount).HasColumnName("PPAMOUNT");

                entity.Property(e => e.Ppcount).HasColumnName("PPCOUNT");

                entity.Property(e => e.Visarejcount).HasColumnName("VISAREJCOUNT");
            });

            modelBuilder.Entity<DailyTxnSummary>(entity =>
            {
                entity.HasKey(e => new { e.TheDate, e.Termid });

                entity.Property(e => e.TheDate).HasColumnType("datetime");

                entity.Property(e => e.Termid).HasColumnName("TERMID");

                entity.Property(e => e.Amtchqdep)
                    .HasColumnName("AMTCHQDEP")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Amtcshdep)
                    .HasColumnName("AMTCSHDEP")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Amtcwd)
                    .HasColumnName("AMTCWD")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Amtcwdpeak)
                    .HasColumnName("AMTCWDPEAK")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Bal).HasColumnName("BAL");

                entity.Property(e => e.Chqdep).HasColumnName("CHQDEP");

                entity.Property(e => e.Cshdep).HasColumnName("CSHDEP");

                entity.Property(e => e.Cwd).HasColumnName("CWD");

                entity.Property(e => e.Fndtrf).HasColumnName("FNDTRF");

                entity.Property(e => e.Mbt).HasColumnName("MBT");

                entity.Property(e => e.Mstmt).HasColumnName("MSTMT");

                entity.Property(e => e.Othertxns).HasColumnName("OTHERTXNS");

                entity.Property(e => e.Peakhr).HasColumnName("PEAKHR");

                entity.Property(e => e.Total).HasColumnName("TOTAL");
            });

            modelBuilder.Entity<DataTransferPackageVariables>(entity =>
            {
                entity.HasKey(e => new { e.Varname, e.Varvalue });

                entity.Property(e => e.Varname)
                    .HasColumnName("varname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varvalue)
                    .HasColumnName("varvalue")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Currtime)
                    .HasColumnName("currtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Pkg)
                    .HasColumnName("pkg")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShclogCnt).HasColumnName("shclog_cnt");

                entity.Property(e => e.ShclogNonPptCnt).HasColumnName("shclog_non_ppt_cnt");
            });

            modelBuilder.Entity<DeleteShclog76>(entity =>
            {
                entity.ToTable("delete_shclog_76");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CopyBatchid)
                    .HasColumnName("COPY_BATCHID")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PanEnc)
                    .HasColumnName("PAN_ENC")
                    .HasMaxLength(128);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<Deposits>(entity =>
            {
                entity.HasKey(e => new { e.InstId, e.DepDate });

                entity.ToTable("deposits");

                entity.Property(e => e.InstId).HasColumnName("inst_id");

                entity.Property(e => e.DepDate)
                    .HasColumnName("dep_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnsettledAmt)
                    .HasColumnName("unsettled_amt")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<DepositUsageMonitor>(entity =>
            {
                entity.HasKey(e => e.InstId);

                entity.Property(e => e.InstId)
                    .HasColumnName("InstID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CashTaken).HasColumnType("money");

                entity.Property(e => e.Deposit).HasColumnType("money");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Institution)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.NextCutoff).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailAccounts>(entity =>
            {
                entity.HasKey(e => e.Accountname);

                entity.ToTable("email_accounts");

                entity.Property(e => e.Accountname)
                    .HasColumnName("accountname")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Authrequired).HasColumnName("authrequired");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smtpserver)
                    .HasColumnName("smtpserver")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailAlerts>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("email_alerts");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Attachment)
                    .HasColumnName("attachment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Emailbcc)
                    .HasColumnName("emailbcc")
                    .HasMaxLength(555)
                    .IsUnicode(false);

                entity.Property(e => e.Emailcc)
                    .HasColumnName("emailcc")
                    .HasMaxLength(555)
                    .IsUnicode(false);

                entity.Property(e => e.Emailto)
                    .IsRequired()
                    .HasColumnName("emailto")
                    .HasMaxLength(555)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(455)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emailoutbox>(entity =>
            {
                entity.ToTable("emailoutbox");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttachmentSql)
                    .HasColumnName("attachment_sql")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Attachments)
                    .HasColumnName("attachments")
                    .HasColumnType("text");

                entity.Property(e => e.Bcc)
                    .HasColumnName("bcc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("text");

                entity.Property(e => e.BodySql)
                    .HasColumnName("body_sql")
                    .HasColumnType("text");

                entity.Property(e => e.BodyTemplate)
                    .HasColumnName("body_template")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasColumnName("cc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recipient)
                    .HasColumnName("recipient")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Senddate)
                    .HasColumnName("senddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sendername)
                    .HasColumnName("sendername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Trials).HasColumnName("trials");
            });

            modelBuilder.Entity<EodLog>(entity =>
            {
                entity.ToTable("EOD_LOG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EodDate)
                    .HasColumnName("EOD_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Erroreps>(entity =>
            {
                entity.ToTable("erroreps");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acquirer)
                    .HasColumnName("acquirer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.AlertGroup)
                    .HasColumnName("alert_group")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bins)
                    .HasColumnName("bins")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BinsExceptions)
                    .HasColumnName("bins_exceptions")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Emailbcc)
                    .HasColumnName("emailbcc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Emailcc)
                    .HasColumnName("emailcc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Emailto)
                    .IsRequired()
                    .HasColumnName("emailto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTimeNonPpt).HasColumnName("local_time_non_ppt");

                entity.Property(e => e.LocalTimePpt).HasColumnName("local_time_ppt");

                entity.Property(e => e.Minutes).HasColumnName("minutes");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("msgtype")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("pcode")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Respcodes)
                    .HasColumnName("respcodes")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RespcodesExceptions)
                    .HasColumnName("respcodes_exceptions")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Saf).HasColumnName("saf");

                entity.Property(e => e.SmsLastSent)
                    .HasColumnName("sms_last_sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.Smsto)
                    .HasColumnName("smsto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Termid)
                    .HasColumnName("termid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactShclog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CopyBatchid)
                    .HasColumnName("COPY_BATCHID")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.OrigAmount)
                    .HasColumnName("ORIG_AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PanEnc)
                    .HasColumnName("PAN_ENC")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txndest).HasColumnName("TXNDEST");

                entity.Property(e => e.Txnsrc).HasColumnName("TXNSRC");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.VsmsId).HasColumnName("vsms_id");
            });

            modelBuilder.Entity<FraudAlertConfigHistoryPrev>(entity =>
            {
                entity.ToTable("FraudAlertConfigHistory_PREV");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acctnum).HasColumnName("ACCTNUM");

                entity.Property(e => e.CurrDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAlertTo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FilterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastTxnTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.SearchBy)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SendSms).HasColumnName("SendSMS");

                entity.Property(e => e.SmsalertTo)
                    .HasColumnName("SMSAlertTo")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FraudAlertFiltersHistoryPrev>(entity =>
            {
                entity.ToTable("FraudAlertFiltersHistory_PREV");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcquirersCsv)
                    .HasColumnName("ACQUIRERsCSV")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrDate).HasColumnType("datetime");

                entity.Property(e => e.EmailSubjectPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilterName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcodesCsv)
                    .HasColumnName("PCODEsCSV")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SendEmailTo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FraudAlertFiltersPrev>(entity =>
            {
                entity.HasKey(e => e.FilterName);

                entity.ToTable("FraudAlertFilters_PREV");

                entity.Property(e => e.FilterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AcquirersCsv)
                    .HasColumnName("ACQUIRERsCSV")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSubjectPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcodesCsv)
                    .HasColumnName("PCODEsCSV")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SendEmailTo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FraudAlertLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlertType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.CurrDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("LOCAL_DATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SentTo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.HasKey(e => e.Dayofyear);

                entity.ToTable("holidays");

                entity.Property(e => e.Dayofyear)
                    .HasColumnName("dayofyear")
                    .HasColumnType("datetime");

                entity.Property(e => e.Holname)
                    .HasColumnName("holname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isholiday).HasColumnName("isholiday");
            });

            modelBuilder.Entity<HourlyWithdrawalsPerInst>(entity =>
            {
                entity.HasKey(e => new { e.WdTermInstId, e.WdYear, e.WdMonth, e.WdDate, e.WdHour });

                entity.Property(e => e.WdTermInstId).HasColumnName("WdTermInstID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.WdAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WdDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Institutions>(entity =>
            {
                entity.ToTable("institutions");

                entity.HasIndex(e => e.Abbrev)
                    .HasName("IX_institutions_backup")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abbrev)
                    .HasColumnName("abbrev")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Acctno)
                    .IsRequired()
                    .HasColumnName("acctno")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detailsemail)
                    .HasColumnName("detailsemail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Isgroup).HasColumnName("isgroup");

                entity.Property(e => e.Joindate)
                    .HasColumnName("joindate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercPpRevenue)
                    .HasColumnName("perc_pp_revenue")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Shortname)
                    .IsRequired()
                    .HasColumnName("shortname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Stmtsemail)
                    .HasColumnName("stmtsemail")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstitutionsBackups>(entity =>
            {
                entity.ToTable("institutions_backups");

                entity.HasIndex(e => e.Abbrev)
                    .HasName("IX_institutions")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abbrev)
                    .HasColumnName("abbrev")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Acctno)
                    .IsRequired()
                    .HasColumnName("acctno")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detailsemail)
                    .HasColumnName("detailsemail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Isgroup).HasColumnName("isgroup");

                entity.Property(e => e.Joindate)
                    .HasColumnName("joindate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercPpRevenue)
                    .HasColumnName("perc_pp_revenue")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Shortname)
                    .IsRequired()
                    .HasColumnName("shortname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Stmtsemail)
                    .HasColumnName("stmtsemail")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KenyaBins>(entity =>
            {
                entity.HasKey(e => e.Bin);

                entity.ToTable("kenya_bins");

                entity.Property(e => e.Bin)
                    .HasColumnName("BIN")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Prod)
                    .HasColumnName("PROD")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LastRunTracking>(entity =>
            {
                entity.HasKey(e => e.Taskname);

                entity.Property(e => e.Taskname)
                    .HasColumnName("taskname")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastSuccRun)
                    .HasColumnName("last_succ_run")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LocalBins>(entity =>
            {
                entity.ToTable("local_bins");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bin1)
                    .HasColumnName("bin1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bin2)
                    .HasColumnName("bin2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cnt)
                    .HasColumnName("cnt")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Digit)
                    .HasColumnName("digit")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Letter)
                    .HasColumnName("letter")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocationMaps>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kilobytes).HasColumnName("kilobytes");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Target)
                    .IsRequired()
                    .HasColumnName("target")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<M9001data>(entity =>
            {
                entity.ToTable("m9001data");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cnt).HasColumnName("CNT");

                entity.Property(e => e.Date1)
                    .HasColumnName("DATE1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Impdate)
                    .HasColumnName("IMPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Respcode).HasColumnName("RESPCODE");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time1)
                    .HasColumnName("TIME1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Worksheet)
                    .HasColumnName("WORKSHEET")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pos).HasColumnName("pos");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Target)
                    .HasColumnName("target")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MonthlyTransactionsPerAcquirer>(entity =>
            {
                entity.HasKey(e => new { e.MonthYear, e.Acquirer });

                entity.Property(e => e.MonthYear).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Acquirer)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Balenqs).HasColumnName("BALENQs");

                entity.Property(e => e.Cwds).HasColumnName("CWDs");
            });

            modelBuilder.Entity<Mpesacommissions>(entity =>
            {
                entity.ToTable("MPESACommissions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Commission).HasColumnType("money");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MpesacommissionsDtb>(entity =>
            {
                entity.ToTable("MPESACommissions_DTB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Commission).HasColumnType("money");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Msgtypes>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("msgtypes");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasColumnName("short_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Msmq>(entity =>
            {
                entity.ToTable("MSMQ");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Emails)
                    .HasColumnName("emails")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Emailspan).HasColumnName("emailspan");

                entity.Property(e => e.Emailssent).HasColumnName("emailssent");

                entity.Property(e => e.Lastemail)
                    .HasColumnName("lastemail")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastsms)
                    .HasColumnName("lastsms")
                    .HasColumnType("datetime");

                entity.Property(e => e.Maxemails).HasColumnName("maxemails");

                entity.Property(e => e.Maxmsg).HasColumnName("maxmsg");

                entity.Property(e => e.Maxsms).HasColumnName("maxsms");

                entity.Property(e => e.Queue)
                    .HasColumnName("queue")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmsNos)
                    .HasColumnName("smsNos")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Smscount).HasColumnName("smscount");

                entity.Property(e => e.Smsspan).HasColumnName("smsspan");
            });

            modelBuilder.Entity<NagiosCassettes>(entity =>
            {
                entity.HasKey(e => new { e.Termid, e.Service });

                entity.ToTable("Nagios_CASSETTES");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Service)
                    .HasColumnName("SERVICE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentStatus)
                    .HasColumnName("CURRENT_STATUS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DowntimeInDays).HasColumnName("DOWNTIME_IN_DAYS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastStatusUpdate)
                    .HasColumnName("LAST_STATUS_UPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastTimeOk)
                    .HasColumnName("LAST_TIME_OK")
                    .HasColumnType("datetime");

                entity.Property(e => e.LatestStatus)
                    .HasColumnName("LATEST_STATUS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LatestStatusTime)
                    .HasColumnName("LATEST_STATUS_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValDenomination).HasColumnName("VAL_DENOMINATION");

                entity.Property(e => e.ValDispToCust).HasColumnName("VAL_DISP_TO_CUST");

                entity.Property(e => e.ValDispensed).HasColumnName("VAL_DISPENSED");

                entity.Property(e => e.ValInitial).HasColumnName("VAL_INITIAL");

                entity.Property(e => e.ValRemaining).HasColumnName("VAL_REMAINING");

                entity.Property(e => e.ValStatus)
                    .HasColumnName("VAL_STATUS")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NoonStats>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cwdamount)
                    .HasColumnName("CWDAMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.Cwdcount).HasColumnName("CWDCOUNT");

                entity.Property(e => e.Endtime)
                    .HasColumnName("ENDTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Procgrp)
                    .HasColumnName("PROCGRP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Starttime)
                    .HasColumnName("STARTTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Targetdate)
                    .HasColumnName("TARGETDATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PastelCsvAtmusage>(entity =>
            {
                entity.ToTable("PASTEL_CSV_ATMUSAGE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountCode).HasColumnName("Account Code");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionCode)
                    .HasColumnName("Transaction Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("Transaction ID")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PastelCsvAtmusageReversals>(entity =>
            {
                entity.ToTable("PASTEL_CSV_ATMUSAGE_REVERSALS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountCode).HasColumnName("Account Code");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionCode)
                    .HasColumnName("Transaction Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("Transaction ID")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaynetContacts>(entity =>
            {
                entity.ToTable("paynet_contacts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pcodes>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("pcodes");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasColumnName("short_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StanchartAbbrev)
                    .HasColumnName("stanchart_abbrev")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PesaConnectExclusions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acquirer)
                    .HasColumnName("acquirer")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstId).HasColumnName("inst_id");

                entity.HasOne(d => d.Inst)
                    .WithMany(p => p.PesaConnectExclusions)
                    .HasForeignKey(d => d.InstId)
                    .HasConstraintName("FK_PesaConnectExclusions_institutions");
            });

            modelBuilder.Entity<PhoneAccounts>(entity =>
            {
                entity.ToTable("phone_accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.HttpApiId)
                    .IsRequired()
                    .HasColumnName("http_api_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HttpRcvEnabled).HasColumnName("http_rcv_enabled");

                entity.Property(e => e.HttpSmsBal).HasColumnName("http_sms_bal");

                entity.Property(e => e.HttpSmsPwd)
                    .HasColumnName("http_sms_pwd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HttpSmsUid)
                    .HasColumnName("http_sms_uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HttpSmsUrl)
                    .HasColumnName("http_sms_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HttpSndEnabled).HasColumnName("http_snd_enabled");

                entity.Property(e => e.Instabbrev)
                    .HasColumnName("instabbrev")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LinkName)
                    .HasColumnName("link_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinHttpBal).HasColumnName("min_http_bal");

                entity.Property(e => e.MinPhoneBal).HasColumnName("min_phone_bal");

                entity.Property(e => e.PhoneBaud).HasColumnName("phone_baud");

                entity.Property(e => e.PhonePort).HasColumnName("phone_port");

                entity.Property(e => e.PhoneRcvEnabled).HasColumnName("phone_rcv_enabled");

                entity.Property(e => e.PhoneSimPin)
                    .HasColumnName("phone_sim_pin")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneSndEnabled).HasColumnName("phone_snd_enabled");

                entity.Property(e => e.ProxyHost)
                    .HasColumnName("proxy_host")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProxyPassword)
                    .HasColumnName("proxy_password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProxyPort).HasColumnName("proxy_port");

                entity.Property(e => e.ProxyUsername)
                    .HasColumnName("proxy_username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmsAccount)
                    .HasColumnName("sms_account")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UseProxy).HasColumnName("use_proxy");
            });

            modelBuilder.Entity<PossibleFraud>(entity =>
            {
                entity.ToTable("possible_fraud");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.AlertSentMultiplecwd).HasColumnName("alert_sent_multiplecwd");

                entity.Property(e => e.AlertSentRunaway).HasColumnName("alert_sent_runaway");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(26, 8)");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Termid)
                    .IsRequired()
                    .HasColumnName("TERMID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("decimal(38, 0)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<PossibleFraud>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_possible_fraud_possible_fraud");
            });

            modelBuilder.Entity<PptBins>(entity =>
            {
                entity.HasKey(e => new { e.Bin, e.InstId });

                entity.ToTable("ppt_bins");

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InstId).HasColumnName("inst_id");

                entity.Property(e => e.Abbrev)
                    .IsRequired()
                    .HasColumnName("abbrev")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Acquiring).HasColumnName("acquiring");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InterconnectJoinDt)
                    .HasColumnName("Interconnect_join_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Issuing).HasColumnName("issuing");

                entity.Property(e => e.Mpesa).HasColumnName("mpesa");

                entity.Property(e => e.Onus).HasColumnName("onus");

                entity.Property(e => e.PesaconnFee).HasColumnName("pesaconn_fee");

                entity.Property(e => e.PesaconnJoinDt)
                    .HasColumnName("pesaconn_join_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.PesaconnPastelAcct)
                    .HasColumnName("pesaconn_pastel_acct")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pesaconnect).HasColumnName("pesaconnect");

                entity.Property(e => e.PostilionSrcnode)
                    .HasColumnName("postilion_srcnode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Visa).HasColumnName("visa");

                entity.Property(e => e.Wagepoint).HasColumnName("wagepoint");

            
            });

            modelBuilder.Entity<PptBinsBackups>(entity =>
            {
                entity.HasKey(e => new { e.Bin, e.InstId });

                entity.ToTable("ppt_bins_backups");

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InstId).HasColumnName("inst_id");

                entity.Property(e => e.Abbrev)
                    .IsRequired()
                    .HasColumnName("abbrev")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Acquiring).HasColumnName("acquiring");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Issuing).HasColumnName("issuing");

                entity.Property(e => e.Mpesa).HasColumnName("mpesa");

                entity.Property(e => e.Onus).HasColumnName("onus");

                entity.Property(e => e.PesaconnFee).HasColumnName("pesaconn_fee");

                entity.Property(e => e.PesaconnJoinDt)
                    .HasColumnName("pesaconn_join_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.PesaconnPastelAcct)
                    .HasColumnName("pesaconn_pastel_acct")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pesaconnect).HasColumnName("pesaconnect");

                entity.Property(e => e.PostilionSrcnode)
                    .HasColumnName("postilion_srcnode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Visa).HasColumnName("visa");

                entity.Property(e => e.Wagepoint).HasColumnName("wagepoint");
            });

            modelBuilder.Entity<Pptcharges>(entity =>
            {
                entity.ToTable("PPTCharges");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bicharge).HasColumnName("BICharge");

                entity.Property(e => e.Bpcharge).HasColumnName("BPCharge");

                entity.Property(e => e.Cwdcharge).HasColumnName("CWDCharge");

                entity.Property(e => e.IssuerBin)
                    .IsRequired()
                    .HasColumnName("IssuerBIN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mstmtcharge).HasColumnName("MSTMTCharge");

                entity.Property(e => e.Ppcharge).HasColumnName("PPCharge");

                entity.Property(e => e.UptoDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PptLog>(entity =>
            {
                entity.ToTable("ppt_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LogCategory)
                    .HasColumnName("log_category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogMsg)
                    .HasColumnName("log_msg")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogTime)
                    .HasColumnName("log_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PptLogCategories>(entity =>
            {
                entity.ToTable("ppt_log_categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogCategory)
                    .HasColumnName("log_category")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PptRevenue>(entity =>
            {
                entity.HasKey(e => new { e.BillingGrp, e.Issuer, e.Termid, e.StmtDate });

                entity.ToTable("PPT_REVENUE");

                entity.Property(e => e.BillingGrp)
                    .HasColumnName("billing_grp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("issuer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Termid)
                    .HasColumnName("termid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StmtDate)
                    .HasColumnName("stmt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TxnCount).HasColumnName("txn_count");

                entity.Property(e => e.TxnFee).HasColumnName("txn_fee");
            });

            modelBuilder.Entity<Ppupload>(entity =>
            {
                entity.ToTable("ppupload");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcGrp)
                    .IsRequired()
                    .HasColumnName("proc_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlselect)
                    .HasColumnName("sqlselect")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<PrimeAccounts>(entity =>
            {
                entity.ToTable("PRIME_ACCOUNTS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acctname)
                    .HasColumnName("ACCTNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .IsRequired()
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Acctype)
                    .HasColumnName("ACCTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnName("BRANCH")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrimeAcctypes>(entity =>
            {
                entity.HasKey(e => e.Acctype);

                entity.ToTable("PRIME_ACCTYPES");

                entity.Property(e => e.Acctype)
                    .HasColumnName("ACCTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrimeTtypes>(entity =>
            {
                entity.HasKey(e => e.Ttype);

                entity.ToTable("PRIME_TTYPES");

                entity.Property(e => e.Ttype)
                    .HasColumnName("TTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrimeTumPostings>(entity =>
            {
                entity.ToTable("PRIME_TUM_POSTINGS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Branch)
                    .HasColumnName("BRANCH")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Calcdate)
                    .HasColumnName("CALCDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descr)
                    .HasColumnName("DESCR")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasColumnName("REFERENCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ttype)
                    .HasColumnName("TTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Txndate)
                    .HasColumnName("TXNDATE")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<ProcessTracking>(entity =>
            {
                entity.HasKey(e => e.Process);

                entity.Property(e => e.Process)
                    .HasColumnName("process")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastRunTime)
                    .HasColumnName("last_run_time")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.ToTable("profiles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AtmbalPageSize).HasColumnName("atmbal_page_size");

                entity.Property(e => e.ShclogPageSize).HasColumnName("shclog_page_size");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("uid")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QueryLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientMachine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndedAt).HasColumnType("datetime");

                entity.Property(e => e.Query).HasColumnType("text");

                entity.Property(e => e.QueryRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasColumnType("text");

                entity.Property(e => e.ServerMachine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartedAt).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.ToTable("regions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.ToTable("reports");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowWeb).HasColumnName("show_web");

                entity.Property(e => e.Targetdbid)
                    .HasColumnName("targetdbid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportsMonths>(entity =>
            {
                entity.HasKey(e => e.MonthNum);

                entity.ToTable("Reports_Months");

                entity.Property(e => e.MonthNum).ValueGeneratedNever();

                entity.Property(e => e.MonthAbbrev)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MonthName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Repparams>(entity =>
            {
                entity.ToTable("repparams");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Paramid).HasColumnName("paramid");

                entity.Property(e => e.Repid).HasColumnName("repid");
            });

            modelBuilder.Entity<Respcodes>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("respcodes");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Revenue>(entity =>
            {
                entity.HasKey(e => new { e.StmtDate, e.Termid });

                entity.ToTable("revenue");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("stmt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("termid")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BalIntnl).HasColumnName("bal_intnl");

                entity.Property(e => e.BalLocal).HasColumnName("bal_local");

                entity.Property(e => e.BalOnus).HasColumnName("bal_onus");

                entity.Property(e => e.CwdIntnl).HasColumnName("cwd_intnl");

                entity.Property(e => e.CwdLocal).HasColumnName("cwd_local");

                entity.Property(e => e.CwdOnus).HasColumnName("cwd_onus");

                entity.Property(e => e.RejIntnl).HasColumnName("rej_intnl");

                entity.Property(e => e.RejLocal).HasColumnName("rej_local");

                entity.Property(e => e.RejOnus).HasColumnName("rej_onus");
            });

            modelBuilder.Entity<Reversals>(entity =>
            {
                entity.HasKey(e => new { e.StmtDate, e.Bin });

                entity.ToTable("reversals");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("stmt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.ProcGrp)
                    .IsRequired()
                    .HasColumnName("proc_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrxnCount).HasColumnName("trxn_count");
            });

            modelBuilder.Entity<SettlementProcGrps>(entity =>
            {
                entity.HasKey(e => e.ProcGrp);

                entity.ToTable("settlement_proc_grps");

                entity.Property(e => e.ProcGrp)
                    .HasColumnName("proc_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cutofftime).HasColumnName("cutofftime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RunOnHolidays).HasColumnName("run_on_holidays");

                entity.Property(e => e.Rundaysofweek)
                    .HasColumnName("rundaysofweek")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SettlementProcLog>(entity =>
            {
                entity.HasKey(e => new { e.ProcGrp, e.StmtDate });

                entity.ToTable("settlement_proc_log");

                entity.Property(e => e.ProcGrp)
                    .HasColumnName("proc_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StmtDate)
                    .HasColumnName("stmt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cutofftime).HasColumnName("cutofftime");

                entity.Property(e => e.Due).HasColumnName("due");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Qdate)
                    .HasColumnName("qdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rundate)
                    .HasColumnName("rundate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SettlStatementData>(entity =>
            {
                entity.HasKey(e => e.Uqid);

                entity.ToTable("settl_statement_data");

                entity.Property(e => e.Uqid).HasColumnName("uqid");

                entity.Property(e => e.Acctno)
                    .HasColumnName("acctno")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("money");

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BinDescr)
                    .HasColumnName("bin_descr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Credits)
                    .HasColumnName("credits")
                    .HasColumnType("money");

                entity.Property(e => e.Debits)
                    .HasColumnName("debits")
                    .HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenTime)
                    .HasColumnName("gen_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InstId).HasColumnName("inst_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RepGrp).HasColumnName("rep_grp");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("stmt_date")
                    .HasColumnType("date");

                entity.Property(e => e.TrxnCode)
                    .HasColumnName("trxn_code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TrxnCount).HasColumnName("trxn_count");

                entity.Property(e => e.TrxnRate)
                    .HasColumnName("trxn_rate")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ShcdataIntegrity>(entity =>
            {
                entity.ToTable("shcdata_integrity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.Livecount).HasColumnName("livecount");

                entity.Property(e => e.Offsitecount).HasColumnName("offsitecount");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Shclog>(entity =>
            {
                entity.ToTable("shclog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CopyBatchid)
                    .HasColumnName("COPY_BATCHID")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.OrigAmount)
                    .HasColumnName("ORIG_AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PanEnc)
                    .HasColumnName("PAN_ENC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txndest).HasColumnName("TXNDEST");

                entity.Property(e => e.Txnsrc).HasColumnName("TXNSRC");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<Shclog732Vs76>(entity =>
            {
                entity.HasKey(e => new { e.Shctable, e.Shcid });

                entity.ToTable("shclog_732_vs_76");

                entity.Property(e => e.Shctable)
                    .HasColumnName("shctable")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shcid).HasColumnName("shcid");

                entity.Property(e => e.Respcode732)
                    .HasColumnName("respcode_732")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Respcode76)
                    .HasColumnName("respcode_76")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ShclogAudit>(entity =>
            {
                entity.ToTable("shclog_audit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<ShclogBackup>(entity =>
            {
                entity.ToTable("shclog_backup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<ShclogDev>(entity =>
            {
                entity.ToTable("shclog_dev");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<ShclogNonPpt>(entity =>
            {
                entity.ToTable("shclog_non_ppt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CopyBatchid)
                    .HasColumnName("COPY_BATCHID")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.OrigAmount)
                    .HasColumnName("ORIG_AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PanEnc)
                    .HasColumnName("PAN_ENC")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txndest).HasColumnName("TXNDEST");

                entity.Property(e => e.Txnsrc).HasColumnName("TXNSRC");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.VsmsId).HasColumnName("vsms_id");
            });

            modelBuilder.Entity<ShclogNonPptDumps>(entity =>
            {
                entity.ToTable("shclog_non_ppt_dumps");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CopyBatchid)
                    .HasColumnName("COPY_BATCHID")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.OrigAmount)
                    .HasColumnName("ORIG_AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PanEnc)
                    .HasColumnName("PAN_ENC")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txndest).HasColumnName("TXNDEST");

                entity.Property(e => e.Txnsrc).HasColumnName("TXNSRC");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.VsmsId).HasColumnName("vsms_id");
            });

            modelBuilder.Entity<ShclogNonPptExt>(entity =>
            {
                entity.ToTable("shclog_non_ppt_ext");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoRevTime).HasColumnType("datetime");

                entity.Property(e => e.IsOnus).HasColumnName("IsONUS");

                entity.Property(e => e.IsVisa).HasColumnName("IsVISA");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShclogNonPptOld>(entity =>
            {
                entity.ToTable("shclog_non_ppt_old");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<ShclogNonPptTest>(entity =>
            {
                entity.ToTable("shclog_non_ppt_test");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CopyBatchid)
                    .HasColumnName("COPY_BATCHID")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PanEnc)
                    .HasColumnName("PAN_ENC")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<ShclogPastelDataDailySummary>(entity =>
            {
                entity.ToTable("shclog_pastel_data_daily_summary");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Msgtype).HasColumnName("MSGTYPE");

                entity.Property(e => e.Pcode).HasColumnName("PCODE");

                entity.Property(e => e.Respcode).HasColumnName("RESPCODE");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Txncount).HasColumnName("TXNCOUNT");
            });

            modelBuilder.Entity<ShclogPostilion>(entity =>
            {
                entity.ToTable("shclog_postilion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CopyBatchid)
                    .HasColumnName("COPY_BATCHID")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .IsRequired()
                    .HasColumnName("ISSUER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PanEnc)
                    .HasColumnName("PAN_ENC")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txndest).HasColumnName("TXNDEST");

                entity.Property(e => e.Txnsrc).HasColumnName("TXNSRC");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<ShclogRevaudit>(entity =>
            {
                entity.HasKey(e => new { e.ShclogId, e.ShclogName });

                entity.ToTable("shclog_revaudit");

                entity.Property(e => e.ShclogId).HasColumnName("shclog_id");

                entity.Property(e => e.ShclogName)
                    .HasColumnName("shclog_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RevType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReversedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReversedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShclogRoutedToVisa>(entity =>
            {
                entity.HasKey(e => new { e.ShclogId, e.ShclogName });

                entity.ToTable("shclog_routed_to_visa");

                entity.Property(e => e.ShclogId).HasColumnName("shclog_id");

                entity.Property(e => e.ShclogName)
                    .HasColumnName("shclog_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ShclogTest>(entity =>
            {
                entity.ToTable("shclog_test");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceptorname)
                    .HasColumnName("ACCEPTORNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Acctnum)
                    .HasColumnName("ACCTNUM")
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Acquirer)
                    .HasColumnName("ACQUIRER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Authnum)
                    .HasColumnName("AUTHNUM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Billing)
                    .HasColumnName("billing")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CopyBatchid)
                    .HasColumnName("COPY_BATCHID")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("DATEADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpDate)
                    .HasColumnName("IMP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstAbbrev)
                    .HasColumnName("INST_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("ISSUER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerAbbrev)
                    .HasColumnName("ISSUER_ABBREV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDate)
                    .HasColumnName("LOCAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime)
                    .HasColumnName("local_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalDateValidity).HasColumnName("local_date_validity");

                entity.Property(e => e.LocalTime)
                    .HasColumnName("LOCAL_TIME")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Merchant).HasColumnName("MERCHANT");

                entity.Property(e => e.Msgtype)
                    .HasColumnName("MSGTYPE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Origdate)
                    .HasColumnName("ORIGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Origmsg).HasColumnName("ORIGMSG");

                entity.Property(e => e.Origtime).HasColumnName("ORIGTIME");

                entity.Property(e => e.Origtrace).HasColumnName("ORIGTRACE");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PanEnc)
                    .HasColumnName("PAN_ENC")
                    .HasMaxLength(128);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Refnum)
                    .HasColumnName("REFNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .HasColumnName("RESPCODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RevAmount)
                    .HasColumnName("REV_AMOUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevAmt)
                    .HasColumnName("REV_AMT")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.RevDate)
                    .HasColumnName("REV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevMsgtype)
                    .HasColumnName("REV_MSGTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RevRespcode)
                    .HasColumnName("REV_RESPCODE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Revcode)
                    .HasColumnName("REVCODE")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.Rowid)
                    .HasColumnName("ROWID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Saf)
                    .HasColumnName("SAF")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("STMT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StmtDate2)
                    .HasColumnName("stmt_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Termid)
                    .HasColumnName("TERMID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Termloc)
                    .HasColumnName("TERMLOC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("TRACE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<SmsAccounts>(entity =>
            {
                entity.ToTable("sms_accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.HttpRcvEnabled).HasColumnName("http_rcv_enabled");

                entity.Property(e => e.HttpSmsBal).HasColumnName("http_sms_bal");

                entity.Property(e => e.HttpSndEnabled).HasColumnName("http_snd_enabled");

                entity.Property(e => e.LinkName)
                    .HasColumnName("link_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinHttpBal).HasColumnName("min_http_bal");

                entity.Property(e => e.MinPhoneBal).HasColumnName("min_phone_bal");

                entity.Property(e => e.PhoneBaud).HasColumnName("phone_baud");

                entity.Property(e => e.PhonePort).HasColumnName("phone_port");

                entity.Property(e => e.PhoneRcvEnabled).HasColumnName("phone_rcv_enabled");

                entity.Property(e => e.PhoneSimPin)
                    .HasColumnName("phone_sim_pin")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneSndEnabled).HasColumnName("phone_snd_enabled");

                entity.Property(e => e.ProxyHost)
                    .HasColumnName("proxy_host")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProxyPassword)
                    .HasColumnName("proxy_password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProxyPort).HasColumnName("proxy_port");

                entity.Property(e => e.ProxyUsername)
                    .HasColumnName("proxy_username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmsAccount)
                    .HasColumnName("sms_account")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UseProxy).HasColumnName("use_proxy");
            });

            modelBuilder.Entity<SmsAlerts>(entity =>
            {
                entity.ToTable("sms_alerts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnName("number")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smscharges>(entity =>
            {
                entity.HasKey(e => new { e.SmslinkTypeId, e.InstAbbrev });

                entity.ToTable("SMSCharges");

                entity.Property(e => e.SmslinkTypeId).HasColumnName("SMSLinkTypeID");

                entity.Property(e => e.InstAbbrev)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.SmslinkType)
                    .WithMany(p => p.Smscharges)
                    .HasForeignKey(d => d.SmslinkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSCharges_SMSLinkTypes");
            });

            modelBuilder.Entity<SmsFiles>(entity =>
            {
                entity.ToTable("sms_files");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(26, 8)");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.Matched)
                    .HasColumnName("matched")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Msgtype)
                    .HasColumnName("msgtype")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Pan)
                    .HasColumnName("pan")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("pcode")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RepDate)
                    .HasColumnName("rep_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Respcode)
                    .HasColumnName("respcode")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RetRefNum).HasColumnName("ret_ref_num");

                entity.Property(e => e.SelfId).HasColumnName("self_id");

                entity.Property(e => e.SmsDate)
                    .HasColumnName("sms_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SmsDateTime)
                    .HasColumnName("sms_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SmsTime).HasColumnName("sms_time");

                entity.Property(e => e.Termid)
                    .HasColumnName("termid")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Trace)
                    .HasColumnName("trace")
                    .HasColumnType("numeric(38, 0)");
            });

            modelBuilder.Entity<Smsgatewaystatus>(entity =>
            {
                entity.ToTable("smsgatewaystatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentMachbalance).HasColumnName("CurrentMACHBalance");

                entity.Property(e => e.DtStartupTime).HasColumnType("datetime");

                entity.Property(e => e.FailedMachattempts).HasColumnName("FailedMACHAttempts");

                entity.Property(e => e.LastErrorMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastFailedClickatellSendTime).HasColumnType("datetime");

                entity.Property(e => e.LastFailedMachsendTime)
                    .HasColumnName("LastFailedMACHSendTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastFailedPhone1SendTime).HasColumnType("datetime");

                entity.Property(e => e.LastFailedRecvTime).HasColumnType("datetime");

                entity.Property(e => e.LastFailedRoute)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastFailedSendTime).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulClickatellSendTime).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulMachsendTime)
                    .HasColumnName("LastSuccessfulMACHSendTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulPhone1SendTime).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulRecvTime).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulRoute)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.LinkId)
                    .HasColumnName("LinkID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachbalWarningSent).HasColumnName("MACHBalWarningSent");

                entity.Property(e => e.ShutdownTime).HasColumnType("datetime");

                entity.Property(e => e.SuccessfulMachattempts).HasColumnName("SuccessfulMACHAttempts");
            });

            modelBuilder.Entity<SmsgatewaystatusOld>(entity =>
            {
                entity.HasKey(e => e.StartupTime);

                entity.ToTable("smsgatewaystatus_old");

                entity.Property(e => e.StartupTime).ValueGeneratedNever();

                entity.Property(e => e.DtStartupTime).HasColumnType("datetime");

                entity.Property(e => e.LastErrorMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastFailedBernsoftSendTime).HasColumnType("datetime");

                entity.Property(e => e.LastFailedPhone1SendTime).HasColumnType("datetime");

                entity.Property(e => e.LastFailedRecvTime).HasColumnType("datetime");

                entity.Property(e => e.LastFailedRoute)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastFailedSendTime).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulBernsoftSendTime).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulPhone1SendTime).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulRecvTime).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulRoute)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.LinkId)
                    .HasColumnName("LinkID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShutdownTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SmsgwayUsers>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("SMSGwayUsers");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowedIps)
                    .HasColumnName("AllowedIPs")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AllowedSenderIds)
                    .HasColumnName("AllowedSenderIDs")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastAccessAt).HasColumnType("datetime");

                entity.Property(e => e.LastAccessFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastAppName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastSuccessfulAccessAt).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessfulAccessFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PasswordHsh).HasMaxLength(8000);

                entity.Property(e => e.Smscount).HasColumnName("SMSCount");
            });

            modelBuilder.Entity<SmsHttplinkExceptions>(entity =>
            {
                entity.HasKey(e => e.MobileNoPrefix);

                entity.ToTable("sms_httplink_exceptions");

                entity.Property(e => e.MobileNoPrefix)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smsinbox>(entity =>
            {
                entity.ToTable("smsinbox");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cli)
                    .IsRequired()
                    .HasColumnName("cli")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Crmcaseid)
                    .HasColumnName("crmcaseid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datesent)
                    .HasColumnName("datesent")
                    .HasColumnType("datetime");

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .HasColumnName("msg")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Msgid)
                    .HasColumnName("msgid")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SmsAccount)
                    .HasColumnName("sms_account")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmslinkTypes>(entity =>
            {
                entity.ToTable("SMSLinkTypes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AvailableBalance).HasColumnType("money");

                entity.Property(e => e.CreditAvailableFlag)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LastBalUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LastOkcreditAlertTime)
                    .HasColumnName("LastOKCreditAlertTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastZerocreditAlertTime)
                    .HasColumnName("LastZEROCreditAlertTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LowBalAlertSentAt).HasColumnType("datetime");

                entity.Property(e => e.LowBalEmailAlert)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LowBalSmsalert)
                    .HasColumnName("LowBalSMSAlert")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LowBalThreshold).HasColumnType("money");

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smsoutbox>(entity =>
            {
                entity.ToTable("smsoutbox");

                entity.HasIndex(e => e.CsMsg);

                entity.HasIndex(e => e.Da)
                    .HasName("IX_smsoutbox_4");

                entity.HasIndex(e => e.Dateadded)
                    .HasName("IX_smsoutbox_7");

                entity.HasIndex(e => e.Datesent)
                    .HasName("IX_smsoutbox");

                entity.HasIndex(e => e.DelivLastChk)
                    .HasName("IX_smsoutbox_10");

                entity.HasIndex(e => e.Sendresult);

                entity.HasIndex(e => e.Sentby)
                    .HasName("IX_smsout_sentby");

                entity.HasIndex(e => e.SrcRef)
                    .HasName("IX_smsoutbox_8");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_smsout_status");

                entity.HasIndex(e => new { e.Datesent, e.Sentby })
                    .HasName("NonClusteredIndex-20170204-222906");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CsMsg).HasColumnName("cs_msg");

                entity.Property(e => e.Da)
                    .IsRequired()
                    .HasColumnName("da")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datesent)
                    .HasColumnName("datesent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelivChkCnt).HasColumnName("deliv_chk_cnt");

                entity.Property(e => e.DelivDetails)
                    .HasColumnName("deliv_details")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DelivLastChk)
                    .HasColumnName("deliv_last_chk")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delivered).HasColumnName("delivered");

                entity.Property(e => e.HttpStatus).HasColumnName("http_status");

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .HasColumnName("msg")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Msgid)
                    .HasColumnName("msgid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.RetryCnt).HasColumnName("retry_cnt");

                entity.Property(e => e.Route)
                    .HasColumnName("route")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RouteUsed)
                    .HasColumnName("route_used")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SendDurationMs)
                    .HasColumnName("send_duration_ms")
                    .HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Sendcount).HasColumnName("sendcount");

                entity.Property(e => e.Sendresult)
                    .HasColumnName("sendresult")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sentby)
                    .HasColumnName("sentby")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SmsAccount)
                    .HasColumnName("sms_account")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SmsCount).HasColumnName("sms_count");

                entity.Property(e => e.SrcRef)
                    .HasColumnName("src_ref")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsQueues>(entity =>
            {
                entity.HasKey(e => e.Qid);

                entity.ToTable("sms_queues");

                entity.Property(e => e.Qid).HasColumnName("qid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DrainerStartTime)
                    .HasColumnName("drainer_start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hostname)
                    .HasColumnName("hostname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qname)
                    .HasColumnName("qname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qpath)
                    .HasColumnName("qpath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Txnal).HasColumnName("txnal");
            });

            modelBuilder.Entity<SmsRouting>(entity =>
            {
                entity.HasKey(e => new { e.SenderId, e.MobileNoPrefix });

                entity.ToTable("sms_routing");

                entity.Property(e => e.SenderId)
                    .HasColumnName("SenderID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNoPrefix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastChangedAt).HasColumnType("datetime");

                entity.Property(e => e.LastChangedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangedFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RouteSeq)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmssenderIds>(entity =>
            {
                entity.ToTable("SMSSenderIDs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SenderId)
                    .HasColumnName("SenderID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TranslateTo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsStatusChanges>(entity =>
            {
                entity.ToTable("sms_status_changes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Currdate)
                    .HasColumnName("currdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Newstatus)
                    .HasColumnName("newstatus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Origstatus)
                    .HasColumnName("origstatus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SmsId).HasColumnName("sms_id");

                entity.Property(e => e.Smstable)
                    .IsRequired()
                    .HasColumnName("smstable")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Statements>(entity =>
            {
                entity.HasKey(e => new { e.BatchId, e.Bin, e.TrxnCode });

                entity.ToTable("statements");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrxnCode)
                    .HasColumnName("trxn_code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Credits)
                    .HasColumnName("credits")
                    .HasColumnType("money");

                entity.Property(e => e.Debits)
                    .HasColumnName("debits")
                    .HasColumnType("money");

                entity.Property(e => e.Repgrp)
                    .IsRequired()
                    .HasColumnName("repgrp")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TrxnCount).HasColumnName("trxn_count");

                entity.Property(e => e.TrxnRate)
                    .HasColumnName("trxn_rate")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Taskreps>(entity =>
            {
                entity.ToTable("taskreps");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Cntqry)
                    .HasColumnName("cntqry")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fileext)
                    .HasColumnName("fileext")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pgpencrypt).HasColumnName("PGPEncrypt");

                entity.Property(e => e.Repid).HasColumnName("repid");

                entity.Property(e => e.Targetdbid)
                    .HasColumnName("targetdbid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Taskid).HasColumnName("taskid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.Taskreps)
                    .HasForeignKey(d => d.Repid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_taskreps_reports");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.Taskreps)
                    .HasForeignKey(d => d.Taskid)
                    .HasConstraintName("FK_taskreps_tasks");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.ToTable("tasks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFromAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFromName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Emailbcc)
                    .HasColumnName("emailbcc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Emailbody)
                    .HasColumnName("emailbody")
                    .HasColumnType("text");

                entity.Property(e => e.Emailcc)
                    .HasColumnName("emailcc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Emailto)
                    .HasColumnName("emailto")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InstId).HasColumnName("InstID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Pgpkey)
                    .HasColumnName("PGPKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProcGrp)
                    .HasColumnName("proc_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SchedTime)
                    .HasColumnName("sched_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThresholdAlerts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmailLowerSentAt).HasColumnType("datetime");

                entity.Property(e => e.EmailTo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailUpperSentAt).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateAt).HasColumnType("datetime");

                entity.Property(e => e.LowerThreshold).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SmslowerSentAt)
                    .HasColumnName("SMSLowerSentAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Smsto)
                    .HasColumnName("SMSTo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SmsupperSentAt)
                    .HasColumnName("SMSUpperSentAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpperThreshold).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TkReversals>(entity =>
            {
                entity.ToTable("tk_reversals");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RevBy)
                    .HasColumnName("rev_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevDatetime)
                    .HasColumnName("rev_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Revcode).HasColumnName("revcode");

                entity.Property(e => e.Shcid).HasColumnName("shcid");

                entity.Property(e => e.TkResponse)
                    .HasColumnName("tk_response")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrxnTypes>(entity =>
            {
                entity.HasKey(e => e.TrxnCode);

                entity.ToTable("trxn_types");

                entity.Property(e => e.TrxnCode)
                    .HasColumnName("trxn_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchRate)
                    .HasColumnName("exch_rate")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<UptimeLog>(entity =>
            {
                entity.HasKey(e => new { e.LogfileStart, e.AtmId, e.ObjectName });

                entity.ToTable("uptime_log");

                entity.Property(e => e.LogfileStart)
                    .HasColumnName("Logfile_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.AtmId)
                    .HasColumnName("ATM_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.AtmLocation)
                    .HasColumnName("ATM_Location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentState).HasColumnName("Current_State");

                entity.Property(e => e.DowntimeNarrative)
                    .HasColumnName("Downtime_narrative")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DowntimeStartDatetime)
                    .HasColumnName("Downtime_start_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DowntimeStopDatetime)
                    .HasColumnName("Downtime_stop_datetime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UserAllowedSenderIds>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("user_AllowedSenderIDs");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowedSenderIdsCsv)
                    .HasColumnName("AllowedSenderIDsCSV")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("users");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Authcode)
                    .HasColumnName("authcode")
                    .HasMaxLength(200);

                entity.Property(e => e.Authcodeissdt)
                    .HasColumnName("authcodeissdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Authcodeissuer)
                    .HasColumnName("authcodeissuer")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Authcodestatus)
                    .HasColumnName("authcodestatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Authcodeusdt)
                    .HasColumnName("authcodeusdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Homepage)
                    .HasColumnName("homepage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastloginapp)
                    .HasColumnName("lastloginapp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastloginmachine)
                    .HasColumnName("lastloginmachine")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadData)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Loginfailures).HasColumnName("loginfailures");

                entity.Property(e => e.Menucode)
                    .HasColumnName("menucode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Roles).HasColumnName("roles");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WgpStmts>(entity =>
            {
                entity.HasKey(e => new { e.StmtDate, e.InstId });

                entity.ToTable("wgp_stmts");

                entity.Property(e => e.StmtDate)
                    .HasColumnName("stmt_date")
                    .HasColumnType("date");

                entity.Property(e => e.InstId).HasColumnName("inst_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpeningBal)
                    .HasColumnName("opening_bal")
                    .HasColumnType("money");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Wservices>(entity =>
            {
                entity.HasKey(e => new { e.CfgMachineName, e.CfgServiceName, e.CfgMonitorMachineName });

                entity.ToTable("wservices");

                entity.Property(e => e.CfgMachineName)
                    .HasColumnName("cfgMachineName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CfgServiceName)
                    .HasColumnName("cfgServiceName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CfgMonitorMachineName)
                    .HasColumnName("cfgMonitorMachineName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CfgActive).HasColumnName("cfgActive");

                entity.Property(e => e.CfgEmailIfDown)
                    .HasColumnName("cfgEmailIfDown")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CfgProcessImageName)
                    .HasColumnName("cfgProcessImageName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CfgShowWeb).HasColumnName("cfgShowWeb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StsEmailsSent).HasColumnName("stsEmailsSent");

                entity.Property(e => e.StsLastCheck)
                    .HasColumnName("stsLastCheck")
                    .HasColumnType("datetime");

                entity.Property(e => e.StsLastCheckMachineName)
                    .HasColumnName("stsLastCheckMachineName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StsLastStatus).HasColumnName("stsLastStatus");

                entity.Property(e => e.StsLastStatusCheckError)
                    .HasColumnName("stsLastStatusCheckError")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StsUserComment)
                    .HasColumnName("stsUserComment")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });
        }
    }
}
