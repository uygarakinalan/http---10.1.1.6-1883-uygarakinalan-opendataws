using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace opendataws.data.Models
{
    public partial class GikomContext : DbContext
    {
        public GikomContext()
        {
        }

        public GikomContext(DbContextOptions<GikomContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityReadLog> ActivityReadLogs { get; set; } = null!;
        public virtual DbSet<AksBagimsizBolum> AksBagimsizBolums { get; set; } = null!;
        public virtual DbSet<AksBina> AksBinas { get; set; } = null!;
        public virtual DbSet<Announcement> Announcements { get; set; } = null!;
        public virtual DbSet<AnnouncementReport> AnnouncementReports { get; set; } = null!;
        public virtual DbSet<ArkSignerAuthLog> ArkSignerAuthLogs { get; set; } = null!;
        public virtual DbSet<ArkSignerLog> ArkSignerLogs { get; set; } = null!;
        public virtual DbSet<ArventoRegionAlarmLog> ArventoRegionAlarmLogs { get; set; } = null!;
        public virtual DbSet<Audit> Audits { get; set; } = null!;
        public virtual DbSet<AutomatedIncidentAnalysisReport> AutomatedIncidentAnalysisReports { get; set; } = null!;
        public virtual DbSet<AutomatedIncidentAnalysisReportLog> AutomatedIncidentAnalysisReportLogs { get; set; } = null!;
        public virtual DbSet<AutomaticCallLog> AutomaticCallLogs { get; set; } = null!;
        public virtual DbSet<AutomaticCallPlan> AutomaticCallPlans { get; set; } = null!;
        public virtual DbSet<AutomaticCallPlanExcelLog> AutomaticCallPlanExcelLogs { get; set; } = null!;
        public virtual DbSet<AutomaticCallPlanTarget> AutomaticCallPlanTargets { get; set; } = null!;
        public virtual DbSet<Baskent153Incident> Baskent153Incidents { get; set; } = null!;
        public virtual DbSet<BeyazwebLog> BeyazwebLogs { get; set; } = null!;
        public virtual DbSet<BirikimAuthToken> BirikimAuthTokens { get; set; } = null!;
        public virtual DbSet<CalendarEvent> CalendarEvents { get; set; } = null!;
        public virtual DbSet<CalendarEventAnonymousGuest> CalendarEventAnonymousGuests { get; set; } = null!;
        public virtual DbSet<CalendarEventCreationRequest> CalendarEventCreationRequests { get; set; } = null!;
        public virtual DbSet<CalendarEventCreationRequestAction> CalendarEventCreationRequestActions { get; set; } = null!;
        public virtual DbSet<CalendarEventGuest> CalendarEventGuests { get; set; } = null!;
        public virtual DbSet<CalendarEventGuestNotification> CalendarEventGuestNotifications { get; set; } = null!;
        public virtual DbSet<CalendarEventReminderNotification> CalendarEventReminderNotifications { get; set; } = null!;
        public virtual DbSet<CalendarLabel> CalendarLabels { get; set; } = null!;
        public virtual DbSet<CallCenterAnnouncement> CallCenterAnnouncements { get; set; } = null!;
        public virtual DbSet<CallCenterCallDisposition> CallCenterCallDispositions { get; set; } = null!;
        public virtual DbSet<CallCenterRecordLog> CallCenterRecordLogs { get; set; } = null!;
        public virtual DbSet<CallCenterReturnedCall> CallCenterReturnedCalls { get; set; } = null!;
        public virtual DbSet<CallCenterSetting> CallCenterSettings { get; set; } = null!;
        public virtual DbSet<CallDispositionCode> CallDispositionCodes { get; set; } = null!;
        public virtual DbSet<CdrBulkDownloadLog> CdrBulkDownloadLogs { get; set; } = null!;
        public virtual DbSet<CimerIncident> CimerIncidents { get; set; } = null!;
        public virtual DbSet<CimerLog> CimerLogs { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<ContactInfo> ContactInfos { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerAction> CustomerActions { get; set; } = null!;
        public virtual DbSet<CustomerActionNote> CustomerActionNotes { get; set; } = null!;
        public virtual DbSet<CustomerActivity> CustomerActivities { get; set; } = null!;
        public virtual DbSet<CustomerActivityAction> CustomerActivityActions { get; set; } = null!;
        public virtual DbSet<CustomerActivityBulkDownload> CustomerActivityBulkDownloads { get; set; } = null!;
        public virtual DbSet<CustomerActivityResponsibleUserLog> CustomerActivityResponsibleUserLogs { get; set; } = null!;
        public virtual DbSet<CustomerBulkDownload> CustomerBulkDownloads { get; set; } = null!;
        public virtual DbSet<CustomerCallMeRequest> CustomerCallMeRequests { get; set; } = null!;
        public virtual DbSet<CustomerFailedOutboundCall> CustomerFailedOutboundCalls { get; set; } = null!;
        public virtual DbSet<CustomerForm> CustomerForms { get; set; } = null!;
        public virtual DbSet<CustomerIsActiveLog> CustomerIsActiveLogs { get; set; } = null!;
        public virtual DbSet<CustomerJob> CustomerJobs { get; set; } = null!;
        public virtual DbSet<CustomerNotificationSetting> CustomerNotificationSettings { get; set; } = null!;
        public virtual DbSet<CustomerPayment> CustomerPayments { get; set; } = null!;
        public virtual DbSet<CustomerProject> CustomerProjects { get; set; } = null!;
        public virtual DbSet<CustomerProjectAction> CustomerProjectActions { get; set; } = null!;
        public virtual DbSet<CustomerProjectFile> CustomerProjectFiles { get; set; } = null!;
        public virtual DbSet<CustomerProjectFileDownloadLog> CustomerProjectFileDownloadLogs { get; set; } = null!;
        public virtual DbSet<CustomerProjectGuarantor> CustomerProjectGuarantors { get; set; } = null!;
        public virtual DbSet<CustomerProjectInfo> CustomerProjectInfos { get; set; } = null!;
        public virtual DbSet<CustomerProjectLeaf> CustomerProjectLeaves { get; set; } = null!;
        public virtual DbSet<CustomerProjectRevisionLog> CustomerProjectRevisionLogs { get; set; } = null!;
        public virtual DbSet<CustomerSetting> CustomerSettings { get; set; } = null!;
        public virtual DbSet<CustomerSource> CustomerSources { get; set; } = null!;
        public virtual DbSet<CustomerTasarrufProjectCalculation> CustomerTasarrufProjectCalculations { get; set; } = null!;
        public virtual DbSet<CustomerTransferLog> CustomerTransferLogs { get; set; } = null!;
        public virtual DbSet<CustomsAccount> CustomsAccounts { get; set; } = null!;
        public virtual DbSet<CustomsAutoMessage> CustomsAutoMessages { get; set; } = null!;
        public virtual DbSet<CustomsIncidentRelation> CustomsIncidentRelations { get; set; } = null!;
        public virtual DbSet<CustomsIntegration> CustomsIntegrations { get; set; } = null!;
        public virtual DbSet<CustomsMessage> CustomsMessages { get; set; } = null!;
        public virtual DbSet<CustomsMessageUserAction> CustomsMessageUserActions { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DirectSmsLog> DirectSmsLogs { get; set; } = null!;
        public virtual DbSet<EDevletAuthLog> EDevletAuthLogs { get; set; } = null!;
        public virtual DbSet<EdevletIncidentFaxis> EdevletIncidentFaxes { get; set; } = null!;
        public virtual DbSet<EmailLog> EmailLogs { get; set; } = null!;
        public virtual DbSet<EmailPublicToken> EmailPublicTokens { get; set; } = null!;
        public virtual DbSet<EscapeCallBulkDownload> EscapeCallBulkDownloads { get; set; } = null!;
        public virtual DbSet<FacebookLead> FacebookLeads { get; set; } = null!;
        public virtual DbSet<FacebookLog> FacebookLogs { get; set; } = null!;
        public virtual DbSet<FailedJob> FailedJobs { get; set; } = null!;
        public virtual DbSet<FaxInbox> FaxInboxes { get; set; } = null!;
        public virtual DbSet<FaxNotificationSetting> FaxNotificationSettings { get; set; } = null!;
        public virtual DbSet<FaxOutbox> FaxOutboxes { get; set; } = null!;
        public virtual DbSet<FcmLog> FcmLogs { get; set; } = null!;
        public virtual DbSet<FrequentlyAskedQuestion> FrequentlyAskedQuestions { get; set; } = null!;
        public virtual DbSet<GbbContact> GbbContacts { get; set; } = null!;
        public virtual DbSet<GoogleApiLog> GoogleApiLogs { get; set; } = null!;
        public virtual DbSet<GoogleDriveFile> GoogleDriveFiles { get; set; } = null!;
        public virtual DbSet<HesCodeLog> HesCodeLogs { get; set; } = null!;
        public virtual DbSet<HospitalAppointment> HospitalAppointments { get; set; } = null!;
        public virtual DbSet<HospitalBlackListItem> HospitalBlackListItems { get; set; } = null!;
        public virtual DbSet<HospitalDepartment> HospitalDepartments { get; set; } = null!;
        public virtual DbSet<HospitalDoctor> HospitalDoctors { get; set; } = null!;
        public virtual DbSet<HospitalPatient> HospitalPatients { get; set; } = null!;
        public virtual DbSet<HospitalPatientAppointment> HospitalPatientAppointments { get; set; } = null!;
        public virtual DbSet<HospitalPatientCall> HospitalPatientCalls { get; set; } = null!;
        public virtual DbSet<HospitalPatientCallLog> HospitalPatientCallLogs { get; set; } = null!;
        public virtual DbSet<HospitalSetting> HospitalSettings { get; set; } = null!;
        public virtual DbSet<HospitalVideoCallAppointment> HospitalVideoCallAppointments { get; set; } = null!;
        public virtual DbSet<Html2Pdf> Html2Pdfs { get; set; } = null!;
        public virtual DbSet<HtmlTemplate> HtmlTemplates { get; set; } = null!;
        public virtual DbSet<IbbIncident> IbbIncidents { get; set; } = null!;
        public virtual DbSet<IbbIncidentLog> IbbIncidentLogs { get; set; } = null!;
        public virtual DbSet<Ilce> Ilces { get; set; } = null!;
        public virtual DbSet<Incident> Incidents { get; set; } = null!;
        public virtual DbSet<IncidentAction> IncidentActions { get; set; } = null!;
        public virtual DbSet<IncidentActionApprovalRule> IncidentActionApprovalRules { get; set; } = null!;
        public virtual DbSet<IncidentActionAttachment> IncidentActionAttachments { get; set; } = null!;
        public virtual DbSet<IncidentActionCustomField> IncidentActionCustomFields { get; set; } = null!;
        public virtual DbSet<IncidentActionInfo> IncidentActionInfos { get; set; } = null!;
        public virtual DbSet<IncidentActionTransfer> IncidentActionTransfers { get; set; } = null!;
        public virtual DbSet<IncidentApprovalTime> IncidentApprovalTimes { get; set; } = null!;
        public virtual DbSet<IncidentAutomaticCall> IncidentAutomaticCalls { get; set; } = null!;
        public virtual DbSet<IncidentBulkDownload> IncidentBulkDownloads { get; set; } = null!;
        public virtual DbSet<IncidentCallRecord> IncidentCallRecords { get; set; } = null!;
        public virtual DbSet<IncidentCompletionReason> IncidentCompletionReasons { get; set; } = null!;
        public virtual DbSet<IncidentCompletionSurveyLog> IncidentCompletionSurveyLogs { get; set; } = null!;
        public virtual DbSet<IncidentCustomField> IncidentCustomFields { get; set; } = null!;
        public virtual DbSet<IncidentEducationStatus> IncidentEducationStatuses { get; set; } = null!;
        public virtual DbSet<IncidentFollower> IncidentFollowers { get; set; } = null!;
        public virtual DbSet<IncidentInternalReturn> IncidentInternalReturns { get; set; } = null!;
        public virtual DbSet<IncidentLog> IncidentLogs { get; set; } = null!;
        public virtual DbSet<IncidentNotification> IncidentNotifications { get; set; } = null!;
        public virtual DbSet<IncidentNotificationSetting> IncidentNotificationSettings { get; set; } = null!;
        public virtual DbSet<IncidentPublicActionValidation> IncidentPublicActionValidations { get; set; } = null!;
        public virtual DbSet<IncidentReadLog> IncidentReadLogs { get; set; } = null!;
        public virtual DbSet<IncidentResponsibleUser> IncidentResponsibleUsers { get; set; } = null!;
        public virtual DbSet<IncidentScheduledAtNotificationLog> IncidentScheduledAtNotificationLogs { get; set; } = null!;
        public virtual DbSet<IncidentShortUrl> IncidentShortUrls { get; set; } = null!;
        public virtual DbSet<IncidentShowLog> IncidentShowLogs { get; set; } = null!;
        public virtual DbSet<IncidentSource> IncidentSources { get; set; } = null!;
        public virtual DbSet<IncidentSurvey> IncidentSurveys { get; set; } = null!;
        public virtual DbSet<IncidentSurveyAnswer> IncidentSurveyAnswers { get; set; } = null!;
        public virtual DbSet<IncidentSurveyBulkDownload> IncidentSurveyBulkDownloads { get; set; } = null!;
        public virtual DbSet<IncidentTimeout> IncidentTimeouts { get; set; } = null!;
        public virtual DbSet<IncidentTimeoutFlow> IncidentTimeoutFlows { get; set; } = null!;
        public virtual DbSet<IncidentTimeoutFlowStage> IncidentTimeoutFlowStages { get; set; } = null!;
        public virtual DbSet<IncidentTimeoutNotification> IncidentTimeoutNotifications { get; set; } = null!;
        public virtual DbSet<IncidentTimeoutReportNotificationSetting> IncidentTimeoutReportNotificationSettings { get; set; } = null!;
        public virtual DbSet<IncidentTimeoutTime> IncidentTimeoutTimes { get; set; } = null!;
        public virtual DbSet<IncidentTopic> IncidentTopics { get; set; } = null!;
        public virtual DbSet<IncidentTopicGroup> IncidentTopicGroups { get; set; } = null!;
        public virtual DbSet<IncidentType> IncidentTypes { get; set; } = null!;
        public virtual DbSet<IncidentWaitingApprovalAction> IncidentWaitingApprovalActions { get; set; } = null!;
        public virtual DbSet<IncidentWorkTime> IncidentWorkTimes { get; set; } = null!;
        public virtual DbSet<InstagramLog> InstagramLogs { get; set; } = null!;
        public virtual DbSet<InternalApiLog> InternalApiLogs { get; set; } = null!;
        public virtual DbSet<IvrTag> IvrTags { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<KpsRequestLog> KpsRequestLogs { get; set; } = null!;
        public virtual DbSet<Localization> Localizations { get; set; } = null!;
        public virtual DbSet<LoginLog> LoginLogs { get; set; } = null!;
        public virtual DbSet<Mahalle> Mahalles { get; set; } = null!;
        public virtual DbSet<MedDataAppointmentLog> MedDataAppointmentLogs { get; set; } = null!;
        public virtual DbSet<MedDataCallerNote> MedDataCallerNotes { get; set; } = null!;
        public virtual DbSet<MedDataReceteLog> MedDataReceteLogs { get; set; } = null!;
        public virtual DbSet<MedDataSetting> MedDataSettings { get; set; } = null!;
        public virtual DbSet<Migration> Migrations { get; set; } = null!;
        public virtual DbSet<Next4BizIssueLog> Next4BizIssueLogs { get; set; } = null!;
        public virtual DbSet<Nobetciler> Nobetcilers { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<NotificationSetting> NotificationSettings { get; set; } = null!;
        public virtual DbSet<OmisLog> OmisLogs { get; set; } = null!;
        public virtual DbSet<OutOfWorkCallLog> OutOfWorkCallLogs { get; set; } = null!;
        public virtual DbSet<Pano> Panos { get; set; } = null!;
        public virtual DbSet<PasswordReset> PasswordResets { get; set; } = null!;
        public virtual DbSet<PasswordReset1> PasswordResets1 { get; set; } = null!;
        public virtual DbSet<PhoneDirectoryGroup> PhoneDirectoryGroups { get; set; } = null!;
        public virtual DbSet<PhoneDirectoryUser> PhoneDirectoryUsers { get; set; } = null!;
        public virtual DbSet<PhoneDirectoryUserImportLog> PhoneDirectoryUserImportLogs { get; set; } = null!;
        public virtual DbSet<PreviewCallList> PreviewCallLists { get; set; } = null!;
        public virtual DbSet<ProAktifLog> ProAktifLogs { get; set; } = null!;
        public virtual DbSet<PublicUser> PublicUsers { get; set; } = null!;
        public virtual DbSet<QmComputedForm> QmComputedForms { get; set; } = null!;
        public virtual DbSet<QmComputedFormObjection> QmComputedFormObjections { get; set; } = null!;
        public virtual DbSet<QmComputedFormTime> QmComputedFormTimes { get; set; } = null!;
        public virtual DbSet<QmForm> QmForms { get; set; } = null!;
        public virtual DbSet<QmFormQuestion> QmFormQuestions { get; set; } = null!;
        public virtual DbSet<QmOption> QmOptions { get; set; } = null!;
        public virtual DbSet<QueueLiveCallsBulkDownload> QueueLiveCallsBulkDownloads { get; set; } = null!;
        public virtual DbSet<ScheduledIncident> ScheduledIncidents { get; set; } = null!;
        public virtual DbSet<ScheduledIncidentLog> ScheduledIncidentLogs { get; set; } = null!;
        public virtual DbSet<Sehir> Sehirs { get; set; } = null!;
        public virtual DbSet<ServerRecord> ServerRecords { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<SmartResponseFlow> SmartResponseFlows { get; set; } = null!;
        public virtual DbSet<SmartResponseFlowSetting> SmartResponseFlowSettings { get; set; } = null!;
        public virtual DbSet<SmartResponseNumberSession> SmartResponseNumberSessions { get; set; } = null!;
        public virtual DbSet<SmartResponseNumberStage> SmartResponseNumberStages { get; set; } = null!;
        public virtual DbSet<SmsLog> SmsLogs { get; set; } = null!;
        public virtual DbSet<SoforDurum> SoforDurums { get; set; } = null!;
        public virtual DbSet<SokakCadde> SokakCaddes { get; set; } = null!;
        public virtual DbSet<SupervisorOperatorStatusChangeLog> SupervisorOperatorStatusChangeLogs { get; set; } = null!;
        public virtual DbSet<TarnetCustomer> TarnetCustomers { get; set; } = null!;
        public virtual DbSet<TarnetCustomerInfo> TarnetCustomerInfos { get; set; } = null!;
        public virtual DbSet<TarnetLog> TarnetLogs { get; set; } = null!;
        public virtual DbSet<TasarrufDepartmentHinterland> TasarrufDepartmentHinterlands { get; set; } = null!;
        public virtual DbSet<TasarrufFeeRateRule> TasarrufFeeRateRules { get; set; } = null!;
        public virtual DbSet<TasarrufGroup> TasarrufGroups { get; set; } = null!;
        public virtual DbSet<TasarrufJobrouterIncidentLog> TasarrufJobrouterIncidentLogs { get; set; } = null!;
        public virtual DbSet<TasarrufLogoLog> TasarrufLogoLogs { get; set; } = null!;
        public virtual DbSet<TasarrufPlan> TasarrufPlans { get; set; } = null!;
        public virtual DbSet<TasarrufPlanGroup> TasarrufPlanGroups { get; set; } = null!;
        public virtual DbSet<TelewebBreakOption> TelewebBreakOptions { get; set; } = null!;
        public virtual DbSet<TelewebBreakRequest> TelewebBreakRequests { get; set; } = null!;
        public virtual DbSet<TelewebCallAction> TelewebCallActions { get; set; } = null!;
        public virtual DbSet<TelewebChannelJoinLog> TelewebChannelJoinLogs { get; set; } = null!;
        public virtual DbSet<TelewebDoCallLog> TelewebDoCallLogs { get; set; } = null!;
        public virtual DbSet<TelewebInternalLog> TelewebInternalLogs { get; set; } = null!;
        public virtual DbSet<TelewebQueueStatusLog> TelewebQueueStatusLogs { get; set; } = null!;
        public virtual DbSet<TimeCondition> TimeConditions { get; set; } = null!;
        public virtual DbSet<TimeConditionGroup> TimeConditionGroups { get; set; } = null!;
        public virtual DbSet<TiskiIndIncidentLog> TiskiIndIncidentLogs { get; set; } = null!;
        public virtual DbSet<TweetLog> TweetLogs { get; set; } = null!;
        public virtual DbSet<TwitterDmLog> TwitterDmLogs { get; set; } = null!;
        public virtual DbSet<TwitterImageOption> TwitterImageOptions { get; set; } = null!;
        public virtual DbSet<TwitterUserInfo> TwitterUserInfos { get; set; } = null!;
        public virtual DbSet<UlakbelIncident> UlakbelIncidents { get; set; } = null!;
        public virtual DbSet<UlakbelIncidentLog> UlakbelIncidentLogs { get; set; } = null!;
        public virtual DbSet<UlakfonNotificationLog> UlakfonNotificationLogs { get; set; } = null!;
        public virtual DbSet<UniversalIncidentLog> UniversalIncidentLogs { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserApiToken> UserApiTokens { get; set; } = null!;
        public virtual DbSet<UserFastAnswer> UserFastAnswers { get; set; } = null!;
        public virtual DbSet<UserFaxInbox> UserFaxInboxes { get; set; } = null!;
        public virtual DbSet<UserFcmToken> UserFcmTokens { get; set; } = null!;
        public virtual DbSet<UserFeedback> UserFeedbacks { get; set; } = null!;
        public virtual DbSet<UserGroup> UserGroups { get; set; } = null!;
        public virtual DbSet<UserGroupRelation> UserGroupRelations { get; set; } = null!;
        public virtual DbSet<UserImportLog> UserImportLogs { get; set; } = null!;
        public virtual DbSet<UserOption> UserOptions { get; set; } = null!;
        public virtual DbSet<UserPermission> UserPermissions { get; set; } = null!;
        public virtual DbSet<UserRRMemory> UserRRMemories { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UserSmsCode> UserSmsCodes { get; set; } = null!;
        public virtual DbSet<UserTitle> UserTitles { get; set; } = null!;
        public virtual DbSet<VideoCallOperatorStatus> VideoCallOperatorStatuses { get; set; } = null!;
        public virtual DbSet<WebForm> WebForms { get; set; } = null!;
        public virtual DbSet<WebFormCustomField> WebFormCustomFields { get; set; } = null!;
        public virtual DbSet<WebFormCustomFieldOption> WebFormCustomFieldOptions { get; set; } = null!;
        public virtual DbSet<WebFormCustomTable> WebFormCustomTables { get; set; } = null!;
        public virtual DbSet<WebFormFlowChart> WebFormFlowCharts { get; set; } = null!;
        public virtual DbSet<WebFormObject> WebFormObjects { get; set; } = null!;
        public virtual DbSet<WebFormObjectElement> WebFormObjectElements { get; set; } = null!;
        public virtual DbSet<WhatsappLog> WhatsappLogs { get; set; } = null!;
        public virtual DbSet<WhatsappPing> WhatsappPings { get; set; } = null!;
        public virtual DbSet<WhereCustomerHear> WhereCustomerHears { get; set; } = null!;
        public virtual DbSet<WorkFlow> WorkFlows { get; set; } = null!;
        public virtual DbSet<YoncaLog> YoncaLogs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=10.1.1.47;database=ulakbel;user id=gbbuser;password=qDr3LocKwCnQh7QC", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.12-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");

            modelBuilder.Entity<ActivityReadLog>(entity =>
            {
                entity.ToTable("activity_read_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ActivityId, "activity_read_logs_activity_id_index");

                entity.HasIndex(e => e.UserId, "activity_read_logs_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActivityId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("activity_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<AksBagimsizBolum>(entity =>
            {
                entity.ToTable("aks_bagimsiz_bolum");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AdresNo, "aks_bagimsiz_bolum_adres_no_index");

                entity.HasIndex(e => e.BinaNo, "aks_bagimsiz_bolum_bina_no_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AdresNo)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("adres_no");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.BinaNo)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("bina_no");

                entity.Property(e => e.IcKapiNo)
                    .HasMaxLength(40)
                    .HasColumnName("ic_kapi_no");

                entity.Property(e => e.Kod)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("kod");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AksBina>(entity =>
            {
                entity.ToTable("aks_bina");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.BinaNo, "aks_bina_bina_no_index");

                entity.HasIndex(e => e.CsbmKodu, "aks_bina_csbm_kodu_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.BinaDurum)
                    .HasMaxLength(50)
                    .HasColumnName("bina_durum");

                entity.Property(e => e.BinaNo)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("bina_no");

                entity.Property(e => e.BinaNumarajTipi)
                    .HasMaxLength(50)
                    .HasColumnName("bina_numaraj_tipi");

                entity.Property(e => e.BinaYapiTipi)
                    .HasMaxLength(50)
                    .HasColumnName("bina_yapi_tipi");

                entity.Property(e => e.BlokAdi)
                    .HasMaxLength(255)
                    .HasColumnName("blok_adi");

                entity.Property(e => e.Boylam)
                    .HasMaxLength(30)
                    .HasColumnName("boylam");

                entity.Property(e => e.ControlledAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("controlled_at");

                entity.Property(e => e.CsbmKodu)
                    .HasColumnType("int(11)")
                    .HasColumnName("csbm_kodu");

                entity.Property(e => e.DisKapiNo)
                    .HasMaxLength(40)
                    .HasColumnName("dis_kapi_no");

                entity.Property(e => e.Enlem)
                    .HasMaxLength(30)
                    .HasColumnName("enlem");

                entity.Property(e => e.Kod)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("kod");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.ToTable("announcements");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BackgroundColor)
                    .HasMaxLength(7)
                    .HasColumnName("background_color");

                entity.Property(e => e.Color)
                    .HasMaxLength(8)
                    .HasColumnName("color");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.DepartmentIds)
                    .HasColumnType("text")
                    .HasColumnName("department_ids");

                entity.Property(e => e.Files)
                    .HasColumnType("text")
                    .HasColumnName("files");

                entity.Property(e => e.FinishDateTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("finish_date_time");

                entity.Property(e => e.IsShouldBeAnswered)
                    .IsRequired()
                    .HasColumnName("is_should_be_answered")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsShouldBeSendSms).HasColumnName("is_should_be_send_sms");

                entity.Property(e => e.Position)
                    .HasColumnType("enum('leftTop','leftCenter','leftBottom','rightTop','rightCenter','rightBottom','centerTop','centerCenter','centerBottom')")
                    .HasColumnName("position");

                entity.Property(e => e.Size)
                    .HasColumnType("enum('large','medium','small')")
                    .HasColumnName("size")
                    .HasDefaultValueSql("'medium'");

                entity.Property(e => e.StartDateTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_date_time");

                entity.Property(e => e.Target)
                    .HasMaxLength(20)
                    .HasColumnName("target");

                entity.Property(e => e.TargetUsers)
                    .HasColumnType("text")
                    .HasColumnName("target_users");

                entity.Property(e => e.Text)
                    .HasColumnType("mediumtext")
                    .HasColumnName("text");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserRoleIds)
                    .HasColumnType("text")
                    .HasColumnName("user_role_ids");
            });

            modelBuilder.Entity<AnnouncementReport>(entity =>
            {
                entity.ToTable("announcement_reports");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AnnouncementId, "announcement_reports_announcement_id");

                entity.HasIndex(e => e.UserId, "announcement_reports_user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AnnouncementId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("announcement_id");

                entity.Property(e => e.AppearedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("appeared_at");

                entity.Property(e => e.ReadAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("read_at");

                entity.Property(e => e.Response)
                    .HasMaxLength(255)
                    .HasColumnName("response");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ArkSignerAuthLog>(entity =>
            {
                entity.ToTable("ark_signer_auth_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccessToken)
                    .HasColumnType("text")
                    .HasColumnName("access_token");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Error)
                    .HasMaxLength(255)
                    .HasColumnName("error");

                entity.Property(e => e.Stage)
                    .HasMaxLength(255)
                    .HasColumnName("stage");

                entity.Property(e => e.State)
                    .HasMaxLength(64)
                    .HasColumnName("state");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(1000)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");

                entity.Property(e => e.UserReference)
                    .HasMaxLength(255)
                    .HasColumnName("user_reference");
            });

            modelBuilder.Entity<ArkSignerLog>(entity =>
            {
                entity.ToTable("ark_signer_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AttachmentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("attachment_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DocumentUuid)
                    .HasMaxLength(255)
                    .HasColumnName("document_uuid");

                entity.Property(e => e.IdentificationNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("identification_number");

                entity.Property(e => e.IsSigned).HasColumnName("is_signed");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ArventoRegionAlarmLog>(entity =>
            {
                entity.ToTable("arvento_region_alarm_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AlarmCreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("alarm_created_at");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.JobPerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("job_performed_at");

                entity.Property(e => e.NodeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("node_id");

                entity.Property(e => e.RegionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("region_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.ToTable("audits");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.AuditableId, e.AuditableType }, "audits_auditable_id_auditable_type_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AuditableId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("auditable_id");

                entity.Property(e => e.AuditableType).HasColumnName("auditable_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Event)
                    .HasMaxLength(255)
                    .HasColumnName("event");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.NewValues)
                    .HasColumnType("text")
                    .HasColumnName("new_values");

                entity.Property(e => e.OldValues)
                    .HasColumnType("text")
                    .HasColumnName("old_values");

                entity.Property(e => e.Tags)
                    .HasMaxLength(255)
                    .HasColumnName("tags");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Url)
                    .HasColumnType("text")
                    .HasColumnName("url");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<AutomatedIncidentAnalysisReport>(entity =>
            {
                entity.ToTable("automated_incident_analysis_reports");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Period)
                    .HasColumnType("enum('daily','weekly','monthly')")
                    .HasColumnName("period");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(255)
                    .HasColumnName("report_name");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<AutomatedIncidentAnalysisReportLog>(entity =>
            {
                entity.ToTable("automated_incident_analysis_report_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AutomatedIncidentAnalysisReportId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("automated_incident_analysis_report_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .HasColumnName("file_path");

                entity.Property(e => e.JobPerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("job_performed_at");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<AutomaticCallLog>(entity =>
            {
                entity.ToTable("automatic_call_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Extension)
                    .HasColumnType("int(11)")
                    .HasColumnName("extension");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('konusuyor','araniyor','cevapsiz','mesgul','cevaplandi','ulasildi')")
                    .HasColumnName("status");

                entity.Property(e => e.TargetTableId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("target_table_id");

                entity.Property(e => e.TargetType)
                    .HasMaxLength(255)
                    .HasColumnName("target_type");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AutomaticCallPlan>(entity =>
            {
                entity.ToTable("automatic_call_plans");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(20)
                    .HasColumnName("action")
                    .HasDefaultValueSql("'dial'");

                entity.Property(e => e.ApiSecret)
                    .HasMaxLength(32)
                    .HasColumnName("api_secret");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.FinishedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("finished_at");

                entity.Property(e => e.IsConstant).HasColumnName("is_constant");

                entity.Property(e => e.IsJobPlanned).HasColumnName("is_job_planned");

                entity.Property(e => e.JobRunRequired)
                    .IsRequired()
                    .HasColumnName("job_run_required")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Method)
                    .HasColumnType("enum('predictive','progessive')")
                    .HasColumnName("method");

                entity.Property(e => e.OutboundCid)
                    .HasMaxLength(20)
                    .HasColumnName("outbound_cid");

                entity.Property(e => e.PausedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("paused_at");

                entity.Property(e => e.PhoneDirectoryGroupIds)
                    .HasColumnType("text")
                    .HasColumnName("phone_directory_group_ids");

                entity.Property(e => e.Settings)
                    .HasColumnType("text")
                    .HasColumnName("settings");

                entity.Property(e => e.StartAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_at");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.Property(e => e.TelewebQueue)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("teleweb_queue");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<AutomaticCallPlanExcelLog>(entity =>
            {
                entity.ToTable("automatic_call_plan_excel_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AutomaticCallPlanId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("automatic_call_plan_id");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<AutomaticCallPlanTarget>(entity =>
            {
                entity.ToTable("automatic_call_plan_targets");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AutomaticCallLogId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("automatic_call_log_id");

                entity.Property(e => e.AutomaticCallPlanId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("automatic_call_plan_id");

                entity.Property(e => e.CallCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("call_count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Extra)
                    .HasColumnType("text")
                    .HasColumnName("extra");

                entity.Property(e => e.PhoneDirectoryUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("phone_directory_user_id");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('aranmayi_bekliyor','araniyor','konusuyor','cevaplandi','ulasildi','ulasilamadi')")
                    .HasColumnName("status");

                entity.Property(e => e.SurveyScore)
                    .HasMaxLength(20)
                    .HasColumnName("survey_score");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Baskent153Incident>(entity =>
            {
                entity.ToTable("baskent153_incidents");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentPublicToken, "baskent153_incidents_incident_public_token_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentPublicToken)
                    .HasMaxLength(41)
                    .HasColumnName("incident_public_token");

                entity.Property(e => e.OriginalId)
                    .HasMaxLength(255)
                    .HasColumnName("original_id");
            });

            modelBuilder.Entity<BeyazwebLog>(entity =>
            {
                entity.ToTable("beyazweb_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");
            });

            modelBuilder.Entity<BirikimAuthToken>(entity =>
            {
                entity.ToTable("birikim_auth_tokens");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActiveDirectoryUsername)
                    .HasMaxLength(100)
                    .HasColumnName("active_directory_username");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Token)
                    .HasMaxLength(128)
                    .HasColumnName("token");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<CalendarEvent>(entity =>
            {
                entity.ToTable("calendar_events");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AdresNo)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("adres_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attachments)
                    .HasColumnType("text")
                    .HasColumnName("attachments");

                entity.Property(e => e.BinaNo)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bina_no")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("end_date");

                entity.Property(e => e.GeogrophicCoordinate)
                    .HasMaxLength(255)
                    .HasColumnName("geogrophic_coordinate");

                entity.Property(e => e.IlceId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ilce_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LabelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("label_id");

                entity.Property(e => e.MahalleId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mahalle_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MainEventId)
                    .HasMaxLength(50)
                    .HasColumnName("main_event_id");

                entity.Property(e => e.Priority)
                    .HasColumnType("enum('low','normal','high','critical')")
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'normal'");

                entity.Property(e => e.RepeatEndDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("repeat_end_date");

                entity.Property(e => e.RepeatSetting)
                    .HasMaxLength(50)
                    .HasColumnName("repeat_setting")
                    .HasDefaultValueSql("'unrepeatable'");

                entity.Property(e => e.RepetitionDays)
                    .HasMaxLength(255)
                    .HasColumnName("repetition_days");

                entity.Property(e => e.SokakId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("sokak_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_date");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CalendarEventAnonymousGuest>(entity =>
            {
                entity.ToTable("calendar_event_anonymous_guests");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .HasColumnName("last_name");

                entity.Property(e => e.MobilePhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CalendarEventCreationRequest>(entity =>
            {
                entity.ToTable("calendar_event_creation_requests");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CalendarUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("calendar_user_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.RequestModel)
                    .HasColumnType("text")
                    .HasColumnName("request_model");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CalendarEventCreationRequestAction>(entity =>
            {
                entity.ToTable("calendar_event_creation_request_actions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .HasColumnName("action");

                entity.Property(e => e.CalendarEventCreationRequestId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("calendar_event_creation_request_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CalendarEventGuest>(entity =>
            {
                entity.ToTable("calendar_event_guests");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CalendarEventAnonymousGuestId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("calendar_event_anonymous_guest_id");

                entity.Property(e => e.CalendarEventId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("calendar_event_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.NotificationMethods)
                    .HasMaxLength(50)
                    .HasColumnName("notification_methods");

                entity.Property(e => e.PhoneDirectoryUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("phone_directory_user_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'pending'");

                entity.Property(e => e.Token)
                    .HasMaxLength(128)
                    .HasColumnName("token");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CalendarEventGuestNotification>(entity =>
            {
                entity.ToTable("calendar_event_guest_notifications");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnType("enum('create','edit','delete')")
                    .HasColumnName("action");

                entity.Property(e => e.CalendarEventGuestId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("calendar_event_guest_id");

                entity.Property(e => e.CalendarEventId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("calendar_event_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.NotificationMethod)
                    .HasColumnType("enum('sms','email','call')")
                    .HasColumnName("notification_method");
            });

            modelBuilder.Entity<CalendarEventReminderNotification>(entity =>
            {
                entity.ToTable("calendar_event_reminder_notifications");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CalendarEventId, "calendar_event_reminder_notifications_calendar_event_id_index");

                entity.HasIndex(e => e.UserId, "calendar_event_reminder_notifications_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CalendarEventId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("calendar_event_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.NotificationMethods)
                    .HasMaxLength(50)
                    .HasColumnName("notification_methods");

                entity.Property(e => e.NotificationTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("notification_time");

                entity.Property(e => e.TimeType)
                    .HasColumnType("enum('minute','day','week')")
                    .HasColumnName("time_type");

                entity.Property(e => e.TimeValue)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time_value");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CalendarLabel>(entity =>
            {
                entity.ToTable("calendar_labels");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BackgroundColor)
                    .HasMaxLength(30)
                    .HasColumnName("background_color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.TextColor)
                    .HasMaxLength(30)
                    .HasColumnName("text_color");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CallCenterAnnouncement>(entity =>
            {
                entity.ToTable("call_center_announcements");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.FinishDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("finish_date");

                entity.Property(e => e.FinishHour)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("finish_hour");

                entity.Property(e => e.SoundFile)
                    .HasMaxLength(255)
                    .HasColumnName("sound_file");

                entity.Property(e => e.SoundSource)
                    .HasColumnType("enum('tts','file')")
                    .HasColumnName("sound_source");

                entity.Property(e => e.SoundText)
                    .HasMaxLength(255)
                    .HasColumnName("sound_text");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_date");

                entity.Property(e => e.StartHour)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_hour");

                entity.Property(e => e.WhenActive)
                    .HasColumnType("enum('constant','between_dates','between_hours')")
                    .HasColumnName("when_active");
            });

            modelBuilder.Entity<CallCenterCallDisposition>(entity =>
            {
                entity.ToTable("call_center_call_dispositions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CallDispositionCodeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("call_disposition_code_id");

                entity.Property(e => e.CallType)
                    .HasMaxLength(32)
                    .HasColumnName("call_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CallCenterRecordLog>(entity =>
            {
                entity.ToTable("call_center_record_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.FromPage)
                    .HasMaxLength(30)
                    .HasColumnName("from_page");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.RecordUsageType)
                    .HasMaxLength(255)
                    .HasColumnName("record_usage_type");

                entity.Property(e => e.ReferenceId)
                    .HasMaxLength(255)
                    .HasColumnName("reference_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .HasColumnName("source");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CallCenterReturnedCall>(entity =>
            {
                entity.ToTable("call_center_returned_calls");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.CallDate, e.PhoneNumber }, "call_center_returned_calls_call_date_phone_number_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CallCount)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("call_count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CallDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("call_date");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");

                entity.Property(e => e.Queue)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("queue");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid");
            });

            modelBuilder.Entity<CallCenterSetting>(entity =>
            {
                entity.ToTable("call_center_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Setting)
                    .HasMaxLength(255)
                    .HasColumnName("setting");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<CallDispositionCode>(entity =>
            {
                entity.ToTable("call_disposition_codes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ParentCodeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_code_id");

                entity.Property(e => e.ParentPriority)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_priority")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CdrBulkDownloadLog>(entity =>
            {
                entity.ToTable("cdr_bulk_download_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EndTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("end_time");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.RequestObject)
                    .HasColumnType("text")
                    .HasColumnName("request_object");

                entity.Property(e => e.StartTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_time");

                entity.Property(e => e.TotalCount)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("total_count");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CimerIncident>(entity =>
            {
                entity.ToTable("cimer_incidents");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.BasvuruSayisi, e.BasvuruId, e.SevkId }, "cimer_incidents_basvuru_sayisi_basvuru_id_sevk_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BasvuruId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("basvuru_id");

                entity.Property(e => e.BasvuruSayisi)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("basvuru_sayisi");

                entity.Property(e => e.CreatedIncidentNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_incident_number");

                entity.Property(e => e.Data)
                    .HasColumnType("mediumtext")
                    .HasColumnName("data");

                entity.Property(e => e.Files)
                    .HasColumnType("text")
                    .HasColumnName("files");

                entity.Property(e => e.ImportedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("imported_at");

                entity.Property(e => e.Info)
                    .HasColumnType("text")
                    .HasColumnName("info");

                entity.Property(e => e.IsAnswered).HasColumnName("is_answered");

                entity.Property(e => e.IsApproved).HasColumnName("is_approved");

                entity.Property(e => e.IsCompleted).HasColumnName("is_completed");

                entity.Property(e => e.IsHeld).HasColumnName("is_held");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.IsUrlChecked).HasColumnName("is_url_checked");

                entity.Property(e => e.SevkId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("sevk_id");
            });

            modelBuilder.Entity<CimerLog>(entity =>
            {
                entity.ToTable("cimer_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CimerIncidentId, "cimer_logs_cimer_incident_id_index");

                entity.HasIndex(e => e.IncidentActionId, "cimer_logs_incident_action_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnType("enum('create','transfer','return','reopen','forward','approve','approval_reject','process','comment','internal_return','complete','delete','spam','upload','ask')")
                    .HasColumnName("action")
                    .HasDefaultValueSql("'complete'");

                entity.Property(e => e.CimerIncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("cimer_incident_id");

                entity.Property(e => e.CompletionType)
                    .HasMaxLength(255)
                    .HasColumnName("completion_type");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IsAnswered).HasColumnName("is_answered");

                entity.Property(e => e.IsApproved).HasColumnName("is_approved");

                entity.Property(e => e.IsCompleted).HasColumnName("is_completed");

                entity.Property(e => e.IsHeld)
                    .HasMaxLength(255)
                    .HasColumnName("is_held");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.Options)
                    .HasMaxLength(2000)
                    .HasColumnName("options");

                entity.Property(e => e.Response)
                    .HasColumnType("mediumtext")
                    .HasColumnName("response");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contacts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IdentificationNumber, "contacts_identification_number_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.AdresNo)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("adres_no");

                entity.Property(e => e.AllowSurveyCalls)
                    .IsRequired()
                    .HasColumnName("allow_survey_calls")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BinaNo)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("bina_no");

                entity.Property(e => e.BirthDay)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("birth_day");

                entity.Property(e => e.BirthMonth)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("birth_month");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(255)
                    .HasColumnName("birth_place");

                entity.Property(e => e.BirthYear)
                    .HasColumnType("year(4)")
                    .HasColumnName("birth_year")
                    .HasDefaultValueSql("'2000'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CsbmKodu)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("csbm_kodu");

                entity.Property(e => e.DisKapiNo)
                    .HasMaxLength(30)
                    .HasColumnName("dis_kapi_no");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(16)
                    .HasColumnName("document_no");

                entity.Property(e => e.EducationStatusId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("education_status_id");

                entity.Property(e => e.FathersName)
                    .HasMaxLength(255)
                    .HasColumnName("fathers_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Gender)
                    .HasColumnType("enum('Erkek','Kadın')")
                    .HasColumnName("gender");

                entity.Property(e => e.IcKapiNo)
                    .HasMaxLength(30)
                    .HasColumnName("ic_kapi_no");

                entity.Property(e => e.IdentificationNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("identification_number");

                entity.Property(e => e.IlKodu)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("il_kodu");

                entity.Property(e => e.IlceKodu)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ilce_kodu");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MahalleKodu)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mahalle_kodu");

                entity.Property(e => e.MothersName)
                    .HasMaxLength(255)
                    .HasColumnName("mothers_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.ToTable("contact_infos");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Value, "contact_info_value_index");

                entity.HasIndex(e => e.ContactId, "contact_infos_contact_id_index");

                entity.HasIndex(e => e.IntValue, "contact_infos_int_value_index");

                entity.HasIndex(e => new { e.Key, e.Value }, "contact_infos_key_value_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ContactId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("contact_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IntValue)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("int_value");

                entity.Property(e => e.Key)
                    .HasColumnType("enum('mobile_phone','work_phone','home_phone','email','twitter','instagram','address','note','fax')")
                    .HasColumnName("key");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AdPermission, "customers_ad_permission_index");

                entity.HasIndex(e => e.CreatorUserId, "customers_creator_user_id_index");

                entity.HasIndex(e => e.CustomerType, "customers_customer_type_index");

                entity.HasIndex(e => e.DeletedAt, "customers_deleted_at_index");

                entity.HasIndex(e => e.HomePhone, "customers_home_phone_index");

                entity.HasIndex(e => e.IdentificationNumber, "customers_identification_number_index")
                    .IsUnique();

                entity.HasIndex(e => e.IlId, "customers_il_id_index");

                entity.HasIndex(e => e.IlceId, "customers_ilce_id_index");

                entity.HasIndex(e => e.IsUser, "customers_is_user_index");

                entity.HasIndex(e => e.LastName, "customers_last_name_index");

                entity.HasIndex(e => e.LastUpdatedUserId, "customers_last_updated_user_id_index");

                entity.HasIndex(e => e.MobilePhone2, "customers_mobile_phone_2_index");

                entity.HasIndex(e => e.MobilePhone, "customers_mobile_phone_index");

                entity.HasIndex(e => e.Name, "customers_name_index");

                entity.HasIndex(e => e.Number, "customers_number_index");

                entity.HasIndex(e => e.ResponsibleDepartmentId, "customers_responsible_department_id_index");

                entity.HasIndex(e => e.ResponsibleUserId, "customers_responsible_user_id_index");

                entity.HasIndex(e => e.Source, "customers_source_index");

                entity.HasIndex(e => e.TasarrufRepresentetive, "customers_tasarruf_representetive_index");

                entity.HasIndex(e => e.WhereCustomerHearId, "customers_where_customer_hear_id_index");

                entity.HasIndex(e => new { e.ResponsibleUserId, e.ResponsibleDepartmentId }, "user_department_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AdPermission)
                    .IsRequired()
                    .HasColumnName("ad_permission")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AdPermissionValue)
                    .HasMaxLength(255)
                    .HasColumnName("ad_permission_value");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("birthdate");

                entity.Property(e => e.CompanyTitle)
                    .HasMaxLength(255)
                    .HasColumnName("company_title");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.CustomerType)
                    .HasColumnType("enum('registered_customer','candidate_customer','passive_customer','new_customer')")
                    .HasColumnName("customer_type");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.ForeignIdentificationNumber)
                    .HasMaxLength(255)
                    .HasColumnName("foreign_identification_number");

                entity.Property(e => e.Gender)
                    .HasColumnType("enum('man','woman')")
                    .HasColumnName("gender");

                entity.Property(e => e.HomePhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("home_phone");

                entity.Property(e => e.IdentificationNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("identification_number");

                entity.Property(e => e.IlId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("il_id");

                entity.Property(e => e.IlceId)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("ilce_id");

                entity.Property(e => e.IsUser).HasColumnName("is_user");

                entity.Property(e => e.LastName).HasColumnName("last_name");

                entity.Property(e => e.LastProjectNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("last_project_number")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LastUpdatedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("last_updated_user_id");

                entity.Property(e => e.MahalleId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mahalle_id");

                entity.Property(e => e.MaritialStatus)
                    .HasColumnType("enum('single','married','widow')")
                    .HasColumnName("maritial_status");

                entity.Property(e => e.MobilePhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.MobilePhone2)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("mobile_phone_2");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Number)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("number");

                entity.Property(e => e.PersonType)
                    .HasColumnType("enum('real','legal','foreign')")
                    .HasColumnName("person_type")
                    .HasDefaultValueSql("'real'");

                entity.Property(e => e.Profession)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("profession");

                entity.Property(e => e.ProjectNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("project_number");

                entity.Property(e => e.ReferencedCustomerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("referenced_customer_id");

                entity.Property(e => e.ResponsibleDepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("responsible_department_id");

                entity.Property(e => e.ResponsibleUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("responsible_user_id");

                entity.Property(e => e.SokakId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("sokak_id");

                entity.Property(e => e.Source)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("source");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'fresh'");

                entity.Property(e => e.TasarrufRepresentetive).HasColumnName("tasarruf_representetive");

                entity.Property(e => e.TaxNumber)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tax_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.WhereCustomerHearId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("where_customer_hear_id");

                entity.Property(e => e.WorkPhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("work_phone");
            });

            modelBuilder.Entity<CustomerAction>(entity =>
            {
                entity.ToTable("customer_actions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Action, "customer_actions_action_index");

                entity.HasIndex(e => e.ActivityId, "customer_actions_activity_id_index");

                entity.HasIndex(e => e.CustomerId, "customer_actions_customer_id_index");

                entity.HasIndex(e => e.PerformedAt, "customer_actions_performed_at_index");

                entity.HasIndex(e => e.Status, "customer_actions_status_index");

                entity.HasIndex(e => e.UserId, "customer_actions_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnType("enum('create','comment','data_change','activity')")
                    .HasColumnName("action");

                entity.Property(e => e.ActivityId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("activity_id");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Extra)
                    .HasColumnType("text")
                    .HasColumnName("extra");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerActionNote>(entity =>
            {
                entity.ToTable("customer_action_notes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ActionId, "customer_action_notes_action_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.Text)
                    .HasMaxLength(150)
                    .HasColumnName("text");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerActivity>(entity =>
            {
                entity.ToTable("customer_activities");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Activity, "customer_activities_activity_index");

                entity.HasIndex(e => e.ActivityType, "customer_activities_activity_type_index");

                entity.HasIndex(e => e.CompleterUser, "customer_activities_completer_user_index");

                entity.HasIndex(e => e.CompletionType, "customer_activities_completion_type_index");

                entity.HasIndex(e => e.CustomerId, "customer_activities_customer_id_index");

                entity.HasIndex(e => e.DeletedAt, "customer_activities_deleted_at_index");

                entity.HasIndex(e => e.DepartmentId, "customer_activities_department_id_index");

                entity.HasIndex(e => e.IsRead, "customer_activities_is_read_index");

                entity.HasIndex(e => e.ResponsibleUserId, "customer_activities_responsible_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Activity).HasColumnName("activity");

                entity.Property(e => e.ActivityDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("activity_date");

                entity.Property(e => e.ActivityLocation)
                    .HasColumnType("enum('sube','ziyaret')")
                    .HasColumnName("activity_location");

                entity.Property(e => e.ActivityType)
                    .HasColumnType("enum('phone','appointment')")
                    .HasColumnName("activity_type");

                entity.Property(e => e.CompleterUser)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completer_user");

                entity.Property(e => e.CompletionDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completion_date");

                entity.Property(e => e.CompletionText)
                    .HasColumnType("text")
                    .HasColumnName("completion_text");

                entity.Property(e => e.CompletionType).HasColumnName("completion_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.ResponsibleUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("responsible_user_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.TopicId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("topic_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CustomerActivityAction>(entity =>
            {
                entity.ToTable("customer_activity_actions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Action, "customer_activity_actions_action_index");

                entity.HasIndex(e => e.CustomerActivityId, "customer_activity_actions_customer_activity_id_index");

                entity.HasIndex(e => e.UserId, "customer_activity_actions_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.CustomerActivityId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_activity_id");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerActivityBulkDownload>(entity =>
            {
                entity.ToTable("customer_activity_bulk_downloads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DataFetchedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("data_fetched_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.FileCreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("file_created_at");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.RequestObject)
                    .HasColumnType("text")
                    .HasColumnName("request_object");

                entity.Property(e => e.RowsCount)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rows_count");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerActivityResponsibleUserLog>(entity =>
            {
                entity.ToTable("customer_activity_responsible_user_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ActivityId, "customer_activity_responsible_user_logs_activity_id_index");

                entity.HasIndex(e => e.Source, "customer_activity_responsible_user_logs_source_index");

                entity.HasIndex(e => e.UserId, "customer_activity_responsible_user_logs_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActivityId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("activity_id");

                entity.Property(e => e.SetCustomerRespId).HasColumnName("set_customer_resp_id");

                entity.Property(e => e.Source)
                    .HasColumnType("enum('user','RR')")
                    .HasColumnName("source");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerBulkDownload>(entity =>
            {
                entity.ToTable("customer_bulk_downloads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DataFetchedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("data_fetched_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.FileCreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("file_created_at");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.RequestObject)
                    .HasColumnType("text")
                    .HasColumnName("request_object");

                entity.Property(e => e.RowsCount)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rows_count");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerCallMeRequest>(entity =>
            {
                entity.ToTable("customer_call_me_requests");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CreatedAt, "customer_call_me_requests_created_at_index");

                entity.HasIndex(e => e.CustomerId, "customer_call_me_requests_customer_id_index");

                entity.HasIndex(e => e.DepartmentId, "customer_call_me_requests_department_id_index");

                entity.HasIndex(e => e.FacebookAdName, "customer_call_me_requests_facebook_ad_name_index");

                entity.HasIndex(e => e.FacebookAdsetName, "customer_call_me_requests_facebook_adset_name_index");

                entity.HasIndex(e => e.FacebookCampaignName, "customer_call_me_requests_facebook_campaign_name_index");

                entity.HasIndex(e => e.FacebookFormName, "customer_call_me_requests_facebook_form_name_index");

                entity.HasIndex(e => e.LastName, "customer_call_me_requests_last_name_index");

                entity.HasIndex(e => e.Name, "customer_call_me_requests_name_index");

                entity.HasIndex(e => e.PhoneNumber, "customer_call_me_requests_phone_number_index");

                entity.HasIndex(e => e.ResponsibleUserId, "customer_call_me_requests_responsible_user_id_index");

                entity.HasIndex(e => e.Source, "customer_call_me_requests_source_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomerActivityId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_activity_id");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("department_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(255)
                    .HasColumnName("email_address");

                entity.Property(e => e.FacebookAdId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("facebook_ad_id");

                entity.Property(e => e.FacebookAdName).HasColumnName("facebook_ad_name");

                entity.Property(e => e.FacebookAdsetId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("facebook_adset_id");

                entity.Property(e => e.FacebookAdsetName).HasColumnName("facebook_adset_name");

                entity.Property(e => e.FacebookCampaignId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("facebook_campaign_id");

                entity.Property(e => e.FacebookCampaignName).HasColumnName("facebook_campaign_name");

                entity.Property(e => e.FacebookFormId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("facebook_form_id");

                entity.Property(e => e.FacebookFormName).HasColumnName("facebook_form_name");

                entity.Property(e => e.FacebookLeadgenId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("facebook_leadgen_id");

                entity.Property(e => e.FacebookLeadgenTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("facebook_leadgen_time");

                entity.Property(e => e.Igclid)
                    .HasMaxLength(255)
                    .HasColumnName("IGCLID");

                entity.Property(e => e.Ilandpage)
                    .HasMaxLength(255)
                    .HasColumnName("ILANDPAGE");

                entity.Property(e => e.Ireferrer)
                    .HasMaxLength(255)
                    .HasColumnName("IREFERRER");

                entity.Property(e => e.IsCustomerExists).HasColumnName("is_customer_exists");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.LastName).HasColumnName("last_name");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");

                entity.Property(e => e.ResponsibleUserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("responsible_user_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Source)
                    .HasColumnType("enum('web_page','facebook')")
                    .HasColumnName("source");

                entity.Property(e => e.Ucampaign)
                    .HasMaxLength(255)
                    .HasColumnName("UCAMPAIGN");

                entity.Property(e => e.Umedium)
                    .HasMaxLength(255)
                    .HasColumnName("UMEDIUM");

                entity.Property(e => e.Usource)
                    .HasMaxLength(255)
                    .HasColumnName("USOURCE");
            });

            modelBuilder.Entity<CustomerFailedOutboundCall>(entity =>
            {
                entity.ToTable("customer_failed_outbound_calls");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CallerDepartment, "customer_failed_outbound_calls_caller_department_index");

                entity.HasIndex(e => e.CallerId, "customer_failed_outbound_calls_caller_id_index");

                entity.HasIndex(e => e.CreatedAt, "customer_failed_outbound_calls_created_at_index");

                entity.HasIndex(e => e.DeletedAt, "customer_failed_outbound_calls_deleted_at_index");

                entity.HasIndex(e => e.PhoneNumber, "customer_failed_outbound_calls_phone_number_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CallerDepartment)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("caller_department");

                entity.Property(e => e.CallerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("caller_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IsRead)
                    .HasColumnName("is_read")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('busy','cant_reach','unanswered')")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<CustomerForm>(entity =>
            {
                entity.ToTable("customer_forms");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DefaultFields)
                    .HasColumnType("text")
                    .HasColumnName("default_fields");
            });

            modelBuilder.Entity<CustomerIsActiveLog>(entity =>
            {
                entity.ToTable("customer_is_active_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CustomerProjectRevisionId, "customer_is_active_logs_customer_project_revision_id_index");

                entity.HasIndex(e => e.IsActive, "customer_is_active_logs_is_active_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomerProjectRevisionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_project_revision_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<CustomerJob>(entity =>
            {
                entity.ToTable("customer_jobs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.JobName, "customer_jobs_job_name_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.JobName).HasColumnName("job_name");
            });

            modelBuilder.Entity<CustomerNotificationSetting>(entity =>
            {
                entity.ToTable("customer_notification_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Active, "customer_notification_settings_active_index");

                entity.HasIndex(e => e.CustomerAction, "customer_notification_settings_customer_action_index");

                entity.HasIndex(e => e.Target, "customer_notification_settings_target_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CustomerAction).HasColumnName("customer_action");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Target).HasColumnName("target");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<CustomerPayment>(entity =>
            {
                entity.ToTable("customer_payments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.PaymentStatus, "customer_payments_payment_status_index");

                entity.HasIndex(e => e.PaymentType, "customer_payments_payment_type_index");

                entity.HasIndex(e => e.ProjectId, "customer_payments_project_id_index");

                entity.HasIndex(e => e.ResponsibleUserId, "customer_payments_responsible_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasPrecision(10, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.AmountPaid)
                    .HasPrecision(10, 2)
                    .HasColumnName("amount_paid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DueDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("due_date");

                entity.Property(e => e.Number)
                    .HasColumnType("int(11)")
                    .HasColumnName("number");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("payment_date");

                entity.Property(e => e.PaymentStatus)
                    .HasColumnType("enum('paid','un_paid','due')")
                    .HasColumnName("payment_status");

                entity.Property(e => e.PaymentType)
                    .HasColumnType("enum('main_debt','system_amount','mid_payment')")
                    .HasColumnName("payment_type");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.ResponsibleUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("responsible_user_id");
            });

            modelBuilder.Entity<CustomerProject>(entity =>
            {
                entity.ToTable("customer_projects");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AbsoluteDeliveryMonth, "customer_projects_absolute_delivery_month_index");

                entity.HasIndex(e => e.ApprovedDate, "customer_projects_approved_date_index");

                entity.HasIndex(e => e.CustomerId, "customer_projects_customer_id_index");

                entity.HasIndex(e => e.DeliveryMonth, "customer_projects_delivery_month_index");

                entity.HasIndex(e => e.EarlyDeliveryMonth, "customer_projects_early_delivery_month_index");

                entity.HasIndex(e => e.FeeType, "customer_projects_fee_type_index");

                entity.HasIndex(e => e.PaymentType, "customer_projects_payment_type_index");

                entity.HasIndex(e => e.PlanId, "customer_projects_plan_id_index");

                entity.HasIndex(e => e.SalesDepartmentId, "customer_projects_sales_department_id_index");

                entity.HasIndex(e => e.SalesUserId, "customer_projects_sales_user_id_index");

                entity.HasIndex(e => e.Status, "customer_projects_status_index");

                entity.HasIndex(e => e.TotalMonth, "customer_projects_total_month_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AbsoluteDeliveryMonth)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("absolute_delivery_month");

                entity.Property(e => e.AmountForCustomer)
                    .HasPrecision(12, 2)
                    .HasColumnName("amount_for_customer")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.AmountOfPayment)
                    .HasPrecision(10, 2)
                    .HasColumnName("amount_of_payment");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("approved_date");

                entity.Property(e => e.ApprovedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("approved_user_id");

                entity.Property(e => e.ContractType)
                    .HasColumnType("enum('SRKT_MILK','BIR_TAS_PLANI','GRUP_TAS_PLANI')")
                    .HasColumnName("contract_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CurrencyUnit)
                    .HasMaxLength(10)
                    .HasColumnName("currency_unit")
                    .HasDefaultValueSql("'tl'");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("delivery_date");

                entity.Property(e => e.DeliveryDay)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("delivery_day");

                entity.Property(e => e.DeliveryMonth)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("delivery_month");

                entity.Property(e => e.DeliveryPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("delivery_percentage");

                entity.Property(e => e.DeprecatedReason)
                    .HasColumnType("text")
                    .HasColumnName("deprecated_reason");

                entity.Property(e => e.EarlyDeliveryMonth)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("early_delivery_month");

                entity.Property(e => e.FeeRate)
                    .HasPrecision(8, 2)
                    .HasColumnName("fee_rate");

                entity.Property(e => e.FeeType)
                    .HasColumnType("enum('in_advance','installment')")
                    .HasColumnName("fee_type");

                entity.Property(e => e.FrontPayment)
                    .HasPrecision(10, 2)
                    .HasColumnName("front_payment");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("group_id");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsLeft)
                    .HasColumnName("is_left")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsTheRefundPaid)
                    .HasColumnName("is_the_refund_paid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MonthlyPayment)
                    .HasPrecision(10, 2)
                    .HasColumnName("monthly_payment");

                entity.Property(e => e.MonthlyPaymentAfterDelivery)
                    .HasPrecision(10, 2)
                    .HasColumnName("monthly_payment_after_delivery");

                entity.Property(e => e.Number)
                    .HasMaxLength(10)
                    .HasColumnName("number");

                entity.Property(e => e.OriginalServiceCostInstallment)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("original_service_cost_installment");

                entity.Property(e => e.PartOfFeeOnly)
                    .HasMaxLength(255)
                    .HasColumnName("part_of_fee_only");

                entity.Property(e => e.PaymentType)
                    .HasColumnType("enum('constant','increase_after_delivery','increase_after_delivery_and_periodically','increase_periodically')")
                    .HasColumnName("payment_type");

                entity.Property(e => e.PercentageOfWithoutCampaignServiceAmount)
                    .HasPrecision(6, 3)
                    .HasColumnName("percentage_of_without_campaign_service_amount");

                entity.Property(e => e.PlanDetails)
                    .HasColumnType("text")
                    .HasColumnName("plan_details");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("plan_id");

                entity.Property(e => e.ProjectFee)
                    .HasPrecision(10, 2)
                    .HasColumnName("project_fee");

                entity.Property(e => e.ProjectTotalPayment)
                    .HasPrecision(10, 2)
                    .HasColumnName("project_total_payment");

                entity.Property(e => e.ProjectType)
                    .HasColumnType("enum('real_estate','vehicle')")
                    .HasColumnName("project_type");

                entity.Property(e => e.RemainingFeeAmount)
                    .HasPrecision(8, 2)
                    .HasColumnName("remaining_fee_amount")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.RevisionDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("revision_date");

                entity.Property(e => e.RevisionedBefore)
                    .HasColumnName("revisioned_before")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SalesDepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sales_department_id");

                entity.Property(e => e.SalesUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sales_user_id");

                entity.Property(e => e.ServiceCostAdvancePayment)
                    .HasPrecision(10, 2)
                    .HasColumnName("service_cost_advance_payment")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ServiceCostInstallment)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("service_cost_installment");

                entity.Property(e => e.ServiceCostType)
                    .HasColumnType("enum('installment','installment_credit_card','cash')")
                    .HasColumnName("service_cost_type");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('pending','waiting_for_approval','waiting_for_digital_signature','approved','deprecated','left','passive')")
                    .HasColumnName("status");

                entity.Property(e => e.SystemAmount)
                    .HasPrecision(10, 2)
                    .HasColumnName("system_amount");

                entity.Property(e => e.SystemAmountWithCampaign)
                    .HasPrecision(10, 2)
                    .HasColumnName("system_amount_with_campaign")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.SystemAmountWithoutCampaign)
                    .HasPrecision(10, 3)
                    .HasColumnName("system_amount_without_campaign");

                entity.Property(e => e.TotalInitialPayment)
                    .HasColumnType("text")
                    .HasColumnName("total_initial_payment");

                entity.Property(e => e.TotalMonth)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_month");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CustomerProjectAction>(entity =>
            {
                entity.ToTable("customer_project_actions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Action, "customer_project_actions_action_index");

                entity.HasIndex(e => e.UserId, "customer_project_actions_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnType("enum('waiting_for_approval','deprecated','waiting_for_digital_signature','approved','left','passive')")
                    .HasColumnName("action");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(255)
                    .HasColumnName("action_type")
                    .HasDefaultValueSql("'status'");

                entity.Property(e => e.Extra)
                    .HasColumnType("text")
                    .HasColumnName("extra");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerProjectFile>(entity =>
            {
                entity.ToTable("customer_project_files");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CreatorUserId, "customer_project_files_creator_user_id_index");

                entity.HasIndex(e => e.CustomerProjectId, "customer_project_files_customer_project_id_index");

                entity.HasIndex(e => e.Type, "customer_project_files_type_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.CustomerProjectId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customer_project_id");

                entity.Property(e => e.CustomerTasarrufProjectCalculationId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_tasarruf_project_calculation_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.RealName)
                    .HasMaxLength(255)
                    .HasColumnName("real_name");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('project_info','contract')")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CustomerProjectFileDownloadLog>(entity =>
            {
                entity.ToTable("customer_project_file_download_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CreatedAt, "customer_project_file_download_logs_created_at_index");

                entity.HasIndex(e => e.IsPermitted, "customer_project_file_download_logs_is_permitted_index");

                entity.HasIndex(e => e.UserId, "customer_project_file_download_logs_user_id_index");

                entity.HasIndex(e => e.CustomerProjectFileId, "file_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomerProjectFileId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_project_file_id");

                entity.Property(e => e.IsPermitted).HasColumnName("is_permitted");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<CustomerProjectGuarantor>(entity =>
            {
                entity.ToTable("customer_project_guarantors");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ProjectId, "customer_project_guarantors_project_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.IdentificationNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("identification_number")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MobilePhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.Revenues)
                    .HasMaxLength(255)
                    .HasColumnName("revenues");
            });

            modelBuilder.Entity<CustomerProjectInfo>(entity =>
            {
                entity.ToTable("customer_project_infos");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Key)
                    .HasMaxLength(255)
                    .HasColumnName("key");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<CustomerProjectLeaf>(entity =>
            {
                entity.ToTable("customer_project_leaves");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccountInfo)
                    .HasMaxLength(255)
                    .HasColumnName("account_info");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomerProjectActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_project_action_id");

                entity.Property(e => e.DeductionAmount)
                    .HasPrecision(10, 2)
                    .HasColumnName("deduction_amount");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.LeaveDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("leave_date");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.RefundAmount)
                    .HasPrecision(10, 2)
                    .HasColumnName("refund_amount");

                entity.Property(e => e.RefundDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("refund_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CustomerProjectRevisionLog>(entity =>
            {
                entity.ToTable("customer_project_revision_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.EarlyDeliveryMonth)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("early_delivery_month");

                entity.Property(e => e.NewCalculation)
                    .HasColumnType("mediumtext")
                    .HasColumnName("new_calculation")
                    .HasComment(" ");

                entity.Property(e => e.OldCalculation)
                    .HasColumnType("mediumtext")
                    .HasColumnName("old_calculation")
                    .HasComment(" ");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<CustomerSetting>(entity =>
            {
                entity.ToTable("customer_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Setting)
                    .HasMaxLength(255)
                    .HasColumnName("setting");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<CustomerSource>(entity =>
            {
                entity.ToTable("customer_sources");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ImportToken, "customer_sources_import_token_index");

                entity.HasIndex(e => e.Title, "customer_sources_title_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ImportToken).HasColumnName("import_token");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<CustomerTasarrufProjectCalculation>(entity =>
            {
                entity.ToTable("customer_tasarruf_project_calculations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CreatedAt, "customer_tasarruf_project_calculations_created_at_index");

                entity.HasIndex(e => e.PublicToken, "customer_tasarruf_project_calculations_public_token_index");

                entity.HasIndex(e => e.SavedAt, "customer_tasarruf_project_calculations_saved_at_index");

                entity.HasIndex(e => e.SelectedPlanToken, "customer_tasarruf_project_calculations_selected_plan_token_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerProjectId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customer_project_id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("group_id");

                entity.Property(e => e.PlanSelectedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("plan_selected_at");

                entity.Property(e => e.PublicToken)
                    .HasMaxLength(41)
                    .HasColumnName("public_token");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("mediumtext")
                    .HasColumnName("response");

                entity.Property(e => e.SavedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("saved_at");

                entity.Property(e => e.SelectedPlanId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("selected_plan_id");

                entity.Property(e => e.SelectedPlanToken)
                    .HasMaxLength(41)
                    .HasColumnName("selected_plan_token");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerTransferLog>(entity =>
            {
                entity.ToTable("customer_transfer_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.FinishTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("finish_time");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("mediumtext")
                    .HasColumnName("response");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomsAccount>(entity =>
            {
                entity.ToTable("customs_accounts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ConnectionInfo)
                    .HasColumnType("text")
                    .HasColumnName("connection_info");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IncidentSourceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_source_id");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LastImportedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("last_imported_at");

                entity.Property(e => e.Options)
                    .HasColumnType("text")
                    .HasColumnName("options");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .HasColumnName("source");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<CustomsAutoMessage>(entity =>
            {
                entity.ToTable("customs_auto_messages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.RemoteId, "customs_auto_messages_remote_id_unique")
                    .IsUnique();

                entity.HasIndex(e => e.RemoteUserName, "customs_auto_messages_remote_user_name_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Attachments)
                    .HasColumnType("text")
                    .HasColumnName("attachments");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.Extra)
                    .HasColumnType("mediumtext")
                    .HasColumnName("extra");

                entity.Property(e => e.ImportTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("import_time");

                entity.Property(e => e.IncidentPublicToken)
                    .HasMaxLength(255)
                    .HasColumnName("incident_public_token");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsOrigin).HasColumnName("is_origin");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.IsReplyTo)
                    .IsRequired()
                    .HasColumnName("is_reply_to")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsSpam).HasColumnName("is_spam");

                entity.Property(e => e.Operation).HasColumnName("operation");

                entity.Property(e => e.Owner).HasColumnName("owner");

                entity.Property(e => e.ParentRemoteId)
                    .HasMaxLength(255)
                    .HasColumnName("parent_remote_id");

                entity.Property(e => e.RealTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("real_time");

                entity.Property(e => e.Recipient)
                    .HasMaxLength(255)
                    .HasColumnName("recipient");

                entity.Property(e => e.RemoteId).HasColumnName("remote_id");

                entity.Property(e => e.RemoteName)
                    .HasMaxLength(255)
                    .HasColumnName("remote_name");

                entity.Property(e => e.RemoteUserId)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_id");

                entity.Property(e => e.RemoteUserName)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("remote_user_name");

                entity.Property(e => e.RemoteUserPic)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_pic");

                entity.Property(e => e.Source)
                    .HasColumnType("enum('twitter','email','sms','facebook','twitter_dm','facebook_messenger','instagram','instagram_dm','whatsapp','fax')")
                    .HasColumnName("source");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomsIncidentRelation>(entity =>
            {
                entity.ToTable("customs_incident_relations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "customs_incident_relations_incident_id_index");

                entity.HasIndex(e => e.LastCustomsMessageId, "customs_incident_relations_last_customs_message_id_index");

                entity.HasIndex(e => e.SelectedMessageId, "customs_incident_relations_selected_message_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CustomsMessageIds)
                    .HasColumnType("text")
                    .HasColumnName("customs_message_ids");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.LastCustomsMessageId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("last_customs_message_id");

                entity.Property(e => e.SelectedMessageId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("selected_message_id");
            });

            modelBuilder.Entity<CustomsIntegration>(entity =>
            {
                entity.ToTable("customs_integrations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IncidentSourceId)
                    .HasMaxLength(255)
                    .HasColumnName("incident_source_id");

                entity.Property(e => e.IntegrationSource)
                    .HasMaxLength(255)
                    .HasColumnName("integration_source");

                entity.Property(e => e.IntegrationTitle)
                    .HasMaxLength(255)
                    .HasColumnName("integration_title");

                entity.Property(e => e.IsReadonly).HasColumnName("is_readonly");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Token)
                    .HasMaxLength(255)
                    .HasColumnName("token");
            });

            modelBuilder.Entity<CustomsMessage>(entity =>
            {
                entity.ToTable("customs_messages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CustomsAccountId, "customs_account_id_index");

                entity.HasIndex(e => new { e.CustomsAccountId, e.IsOrigin, e.Owner, e.IsDeleted }, "customs_messages_customs_account_id_is_deleted_index");

                entity.HasIndex(e => new { e.CustomsAccountId, e.IsOrigin, e.Owner, e.IsRead }, "customs_messages_customs_account_id_is_read_index");

                entity.HasIndex(e => new { e.CustomsAccountId, e.IsOrigin, e.Owner, e.IsSpam }, "customs_messages_customs_account_id_is_spam_index");

                entity.HasIndex(e => new { e.CustomsAccountId, e.IsOrigin, e.Owner, e.Operation }, "customs_messages_customs_account_id_operation_index");

                entity.HasIndex(e => e.ImportTime, "customs_messages_import_time_index");

                entity.HasIndex(e => e.IsDeleted, "customs_messages_is_deleted_index");

                entity.HasIndex(e => e.IsOrigin, "customs_messages_is_origin_index");

                entity.HasIndex(e => e.IsRead, "customs_messages_is_read_index");

                entity.HasIndex(e => e.IsSpam, "customs_messages_is_spam_index");

                entity.HasIndex(e => e.Operation, "customs_messages_operation_index");

                entity.HasIndex(e => e.Owner, "customs_messages_owner_index");

                entity.HasIndex(e => e.ParentRemoteId, "customs_messages_parent_remote_id_index");

                entity.HasIndex(e => e.RealTime, "customs_messages_real_time_index");

                entity.HasIndex(e => e.RemoteId, "customs_messages_remote_id_unique")
                    .IsUnique();

                entity.HasIndex(e => e.RemoteName, "customs_messages_remote_name_index");

                entity.HasIndex(e => e.RemoteUserName, "customs_messages_remote_user_name_index");

                entity.HasIndex(e => e.Source, "customs_messages_source_index");

                entity.HasIndex(e => e.UpdatedAt, "customs_messages_updated_at_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Attachments)
                    .HasColumnType("text")
                    .HasColumnName("attachments");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.Extra)
                    .HasColumnType("mediumtext")
                    .HasColumnName("extra");

                entity.Property(e => e.Favorite).HasColumnName("favorite");

                entity.Property(e => e.ImportTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("import_time");

                entity.Property(e => e.IncidentPublicToken)
                    .HasMaxLength(255)
                    .HasColumnName("incident_public_token");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsOrigin).HasColumnName("is_origin");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.IsReplyTo)
                    .IsRequired()
                    .HasColumnName("is_reply_to")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsSpam).HasColumnName("is_spam");

                entity.Property(e => e.LastMessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("last_message_id");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Operation).HasColumnName("operation");

                entity.Property(e => e.Owner).HasColumnName("owner");

                entity.Property(e => e.ParentRemoteId).HasColumnName("parent_remote_id");

                entity.Property(e => e.RealTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("real_time");

                entity.Property(e => e.Recipient)
                    .HasMaxLength(255)
                    .HasColumnName("recipient");

                entity.Property(e => e.RemoteId).HasColumnName("remote_id");

                entity.Property(e => e.RemoteName).HasColumnName("remote_name");

                entity.Property(e => e.RemoteUserId)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_id");

                entity.Property(e => e.RemoteUserName).HasColumnName("remote_user_name");

                entity.Property(e => e.RemoteUserPic)
                    .HasMaxLength(550)
                    .HasColumnName("remote_user_pic");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .HasColumnName("source");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomsMessageUserAction>(entity =>
            {
                entity.ToTable("customs_message_user_actions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(100)
                    .HasColumnName("action");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomsMessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_message_id");

                entity.Property(e => e.IncidentNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_number");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("departments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.TelewebQueue, "departments_teleweb_queue_unique")
                    .IsUnique();

                entity.HasIndex(e => e.ParentDepartmentId, "parent_department_id_index");

                entity.HasIndex(e => e.ParentPriority, "parent_priority_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasColumnName("address");

                entity.Property(e => e.AllowPostponed)
                    .HasColumnName("allow_postponed")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AllowTransfer)
                    .IsRequired()
                    .HasColumnName("allow_transfer")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AllowTransferIfEmpty)
                    .IsRequired()
                    .HasColumnName("allow_transfer_if_empty")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BaskanYardimciligi)
                    .HasMaxLength(255)
                    .HasColumnName("baskan_yardimciligi");

                entity.Property(e => e.BreakOptions)
                    .HasMaxLength(255)
                    .HasColumnName("break_options");

                entity.Property(e => e.BreakTime)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("break_time");

                entity.Property(e => e.CallWelcomeScreenFields)
                    .HasMaxLength(1000)
                    .HasColumnName("call_welcome_screen_fields");

                entity.Property(e => e.DaireBaskanligi)
                    .HasMaxLength(255)
                    .HasColumnName("daire_baskanligi");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DifferentWebforms)
                    .HasColumnType("text")
                    .HasColumnName("different_webforms");

                entity.Property(e => e.DispositionCodeTimeout)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("disposition_code_timeout");

                entity.Property(e => e.DispositionCodeTimeoutSeconds)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("disposition_code_timeout_seconds");

                entity.Property(e => e.IlId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("il_id");

                entity.Property(e => e.InternalReturnTarget)
                    .HasMaxLength(255)
                    .HasColumnName("internal_return_target");

                entity.Property(e => e.KuyruktaBekleyenKisiSayisiMolaSiniri)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("kuyrukta_bekleyen_kisi_sayisi_mola_siniri");

                entity.Property(e => e.LastWasInWrapUpSecond)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("last_was_in_wrap_up_second");

                entity.Property(e => e.LogoIsyeriKodu)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("logo_isyeri_kodu");

                entity.Property(e => e.MoladakiKisiSayisiMolaSiniri)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("moladaki_kisi_sayisi_mola_siniri");

                entity.Property(e => e.MolayiSinirla)
                    .HasColumnName("molayi_sinirla")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mudurluk)
                    .HasMaxLength(255)
                    .HasColumnName("mudurluk");

                entity.Property(e => e.NewTabUrl)
                    .HasMaxLength(255)
                    .HasColumnName("new_tab_url");

                entity.Property(e => e.OpenDifferentWebforms).HasColumnName("open_different_webforms");

                entity.Property(e => e.OutboundCid)
                    .HasMaxLength(20)
                    .HasColumnName("outbound_cid");

                entity.Property(e => e.ParentDepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("parent_department_id");

                entity.Property(e => e.ParentPriority)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("parent_priority")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PhoneDirectoryGroupIds)
                    .HasColumnType("text")
                    .HasColumnName("phone_directory_group_ids");

                entity.Property(e => e.Private).HasColumnName("private");

                entity.Property(e => e.PublicToken)
                    .HasMaxLength(15)
                    .HasColumnName("public_token");

                entity.Property(e => e.ReturnEscapeCall).HasColumnName("return_escape_call");

                entity.Property(e => e.ReturnEscapeCallAnonsId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("return_escape_call_anons_id");

                entity.Property(e => e.ReturnOffTimeAnonsId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("return_off_time_anons_id");

                entity.Property(e => e.ReturnOffTimeCall).HasColumnName("return_off_time_call");

                entity.Property(e => e.ServiceLevelSeconds)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("service_level_seconds")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShowDashboardConvertToPercent)
                    .HasColumnName("show_dashboard_convert_to_percent")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TakeBreakIfDispositionCodeIsNotSelected)
                    .HasColumnName("take_break_if_disposition_code_is_not_selected")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TelewebDashboardIncidentSourceId)
                    .HasColumnType("text")
                    .HasColumnName("teleweb_dashboard_incident_source_id");

                entity.Property(e => e.TelewebIncidentSourceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("teleweb_incident_source_id");

                entity.Property(e => e.TelewebIncomingCallAction)
                    .HasMaxLength(255)
                    .HasColumnName("teleweb_incoming_call_action");

                entity.Property(e => e.TelewebIncomingTone).HasColumnName("teleweb_incoming_tone");

                entity.Property(e => e.TelewebQueue)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("teleweb_queue");

                entity.Property(e => e.TelewebShortcuts)
                    .HasColumnType("text")
                    .HasColumnName("teleweb_shortcuts");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.TransferAllowedIncidentSourceIds)
                    .HasColumnType("text")
                    .HasColumnName("transfer_allowed_incident_source_ids");

                entity.Property(e => e.WorkingTimeoutSeconds)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("working_timeout_seconds");
            });

            modelBuilder.Entity<DirectSmsLog>(entity =>
            {
                entity.ToTable("direct_sms_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");

                entity.Property(e => e.Response)
                    .HasMaxLength(255)
                    .HasColumnName("response")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Source)
                    .HasMaxLength(30)
                    .HasColumnName("source");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<EDevletAuthLog>(entity =>
            {
                entity.ToTable("e_devlet_auth_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccessToken)
                    .HasMaxLength(300)
                    .HasColumnName("access_token");

                entity.Property(e => e.Code)
                    .HasMaxLength(300)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IdentificationNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("identification_number");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.LogType)
                    .HasMaxLength(64)
                    .HasColumnName("log_type");

                entity.Property(e => e.SourceTableId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("source_table_id");

                entity.Property(e => e.State)
                    .HasMaxLength(64)
                    .HasColumnName("state");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(1000)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<EdevletIncidentFaxis>(entity =>
            {
                entity.ToTable("edevlet_incident_faxes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .HasColumnName("fax");

                entity.Property(e => e.IncidentNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_number");
            });

            modelBuilder.Entity<EmailLog>(entity =>
            {
                entity.ToTable("email_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentActionId, "email_log_incident_action_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.Recipient)
                    .HasColumnType("text")
                    .HasColumnName("recipient");

                entity.Property(e => e.Response)
                    .HasMaxLength(255)
                    .HasColumnName("response");

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .HasColumnName("subject")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.View)
                    .HasMaxLength(255)
                    .HasColumnName("view")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EmailPublicToken>(entity =>
            {
                entity.ToTable("email_public_tokens");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Token, "email_public_tokens_token_index");

                entity.HasIndex(e => new { e.Type, e.TypeId }, "email_public_tokens_type_type_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Token)
                    .HasMaxLength(9)
                    .HasColumnName("token");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('customs','incident')")
                    .HasColumnName("type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<EscapeCallBulkDownload>(entity =>
            {
                entity.ToTable("escape_call_bulk_downloads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CurrentPage)
                    .HasColumnType("int(11)")
                    .HasColumnName("current_page");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EndTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("end_time");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.RequestObject)
                    .HasColumnType("text")
                    .HasColumnName("request_object");

                entity.Property(e => e.StartTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_time");

                entity.Property(e => e.TotalCount)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("total_count");

                entity.Property(e => e.TotalPage)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_page");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<FacebookLead>(entity =>
            {
                entity.ToTable("facebook_leads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AdId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ad_id");

                entity.Property(e => e.AdName)
                    .HasMaxLength(255)
                    .HasColumnName("ad_name");

                entity.Property(e => e.AdsetId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("adset_id");

                entity.Property(e => e.AdsetName)
                    .HasMaxLength(255)
                    .HasColumnName("adset_name");

                entity.Property(e => e.CampaignId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("campaign_id");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(255)
                    .HasColumnName("campaign_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.FieldData)
                    .HasMaxLength(5000)
                    .HasColumnName("field_data");

                entity.Property(e => e.FormId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("form_id");

                entity.Property(e => e.FormName)
                    .HasMaxLength(255)
                    .HasColumnName("form_name");

                entity.Property(e => e.LeadId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("lead_id");

                entity.Property(e => e.LeadTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("lead_time");

                entity.Property(e => e.Platform)
                    .HasMaxLength(255)
                    .HasColumnName("platform");
            });

            modelBuilder.Entity<FacebookLog>(entity =>
            {
                entity.ToTable("facebook_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.CustomsIncidentRelationId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customs_incident_relation_id");

                entity.Property(e => e.CustomsMessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_message_id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.RemoteUserId)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_id");

                entity.Property(e => e.RemoteUserName)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_name");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");
            });

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Connection)
                    .HasColumnType("text")
                    .HasColumnName("connection");

                entity.Property(e => e.Exception).HasColumnName("exception");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Payload).HasColumnName("payload");

                entity.Property(e => e.Queue)
                    .HasColumnType("text")
                    .HasColumnName("queue");
            });

            modelBuilder.Entity<FaxInbox>(entity =>
            {
                entity.ToTable("fax_inbox");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.Extra)
                    .HasColumnType("text")
                    .HasColumnName("extra");

                entity.Property(e => e.FaxId)
                    .HasMaxLength(255)
                    .HasColumnName("fax_id");

                entity.Property(e => e.File)
                    .HasColumnType("text")
                    .HasColumnName("file");

                entity.Property(e => e.ImportedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("imported_at");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.Page)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("page");

                entity.Property(e => e.ReceivedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("received_at");

                entity.Property(e => e.Recipient)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("recipient");

                entity.Property(e => e.Sender)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("sender");
            });

            modelBuilder.Entity<FaxNotificationSetting>(entity =>
            {
                entity.ToTable("fax_notification_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(30)
                    .HasColumnName("action");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.SendFile).HasColumnName("send_file");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<FaxOutbox>(entity =>
            {
                entity.ToTable("fax_outbox");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CustomsAccountId, "fax_outbox_customs_account_id_index");

                entity.HasIndex(e => e.DepartmentId, "fax_outbox_department_id_index");

                entity.HasIndex(e => e.FaxId, "fax_outbox_fax_id_index");

                entity.HasIndex(e => e.Status, "fax_outbox_status_index");

                entity.HasIndex(e => e.UserId, "fax_outbox_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.Extra)
                    .HasColumnType("text")
                    .HasColumnName("extra");

                entity.Property(e => e.FaxId)
                    .HasMaxLength(38)
                    .HasColumnName("fax_id");

                entity.Property(e => e.Page)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("page");

                entity.Property(e => e.Provider)
                    .HasMaxLength(255)
                    .HasColumnName("provider");

                entity.Property(e => e.RealFaxFile)
                    .HasColumnType("text")
                    .HasColumnName("real_fax_file");

                entity.Property(e => e.Recipient)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("recipient");

                entity.Property(e => e.SendAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("send_at");

                entity.Property(e => e.SendFiles)
                    .HasColumnType("text")
                    .HasColumnName("send_files");

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .HasColumnName("source");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('sending','fail','send')")
                    .HasColumnName("status");

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .HasColumnName("subject");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<FcmLog>(entity =>
            {
                entity.ToTable("fcm_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.Payload)
                    .HasColumnType("text")
                    .HasColumnName("payload");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.UserFcmTokenIds)
                    .HasColumnType("text")
                    .HasColumnName("user_fcm_token_ids");
            });

            modelBuilder.Entity<FrequentlyAskedQuestion>(entity =>
            {
                entity.ToTable("frequently_asked_questions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasColumnType("text")
                    .HasColumnName("answer");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.File)
                    .HasColumnType("text")
                    .HasColumnName("file");

                entity.Property(e => e.IsPublic).HasColumnName("isPublic");

                entity.Property(e => e.Question)
                    .HasColumnType("text")
                    .HasColumnName("question");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<GbbContact>(entity =>
            {
                entity.ToTable("gbb_contacts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_turkish_ci");

                entity.HasIndex(e => e.CepTelefonu, "TELEFON_ARAMA");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AdiSoyadi)
                    .HasMaxLength(255)
                    .HasColumnName("ADI_SOYADI")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CepTelefonu)
                    .HasColumnType("bigint(15) unsigned")
                    .HasColumnName("CEP_TELEFONU");

                entity.Property(e => e.TcNo)
                    .HasColumnType("bigint(11) unsigned")
                    .HasColumnName("TC_NO");
            });

            modelBuilder.Entity<GoogleApiLog>(entity =>
            {
                entity.ToTable("google_api_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.CustomsIncidentRelationId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customs_incident_relation_id");

                entity.Property(e => e.CustomsMessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_message_id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.RemoteUserId)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_id");

                entity.Property(e => e.RemoteUserName)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_name");

                entity.Property(e => e.Response)
                    .HasMaxLength(255)
                    .HasColumnName("response");
            });

            modelBuilder.Entity<GoogleDriveFile>(entity =>
            {
                entity.ToTable("google_drive_files");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Title, "google_drive_files_title_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Folder)
                    .HasColumnType("enum('daily','weekly','hourly','monthly')")
                    .HasColumnName("folder");

                entity.Property(e => e.RemoteId)
                    .HasMaxLength(255)
                    .HasColumnName("remote_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('folder','file')")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<HesCodeLog>(entity =>
            {
                entity.ToTable("hes_code_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("expiration_date");

                entity.Property(e => e.HesCode)
                    .HasMaxLength(12)
                    .HasColumnName("hes_code");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.MaskedFirstname)
                    .HasMaxLength(255)
                    .HasColumnName("masked_firstname");

                entity.Property(e => e.MaskedIdentityNumber)
                    .HasMaxLength(255)
                    .HasColumnName("masked_identity_number");

                entity.Property(e => e.MaskedLastname)
                    .HasMaxLength(255)
                    .HasColumnName("masked_lastname");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('RISKLESS','RISKY','ERROR')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'ERROR'");
            });

            modelBuilder.Entity<HospitalAppointment>(entity =>
            {
                entity.ToTable("hospital_appointments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.HbysAppointmentId, "hospital_appointments_hbys_appointment_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.HbysAppointmentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("hbys_appointment_id");

                entity.Property(e => e.HbysDepartmentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("hbys_department_id");

                entity.Property(e => e.HbysDoctorId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("hbys_doctor_id");

                entity.Property(e => e.Time)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("time");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<HospitalBlackListItem>(entity =>
            {
                entity.ToTable("hospital_black_list_items");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.ExcludedFromAppointment).HasColumnName("excluded_from_appointment");

                entity.Property(e => e.ExcludedFromEvaluation).HasColumnName("excluded_from_evaluation");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<HospitalDepartment>(entity =>
            {
                entity.ToTable("hospital_departments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.HbysDepartmentId, "hospital_departments_hbys_department_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.HbysDepartmentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("hbys_department_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<HospitalDoctor>(entity =>
            {
                entity.ToTable("hospital_doctors");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.HbysDoctorId, "hospital_doctors_hbys_doctor_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AppointmentReminder)
                    .IsRequired()
                    .HasColumnName("appointment_reminder")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EvaluationReminder)
                    .IsRequired()
                    .HasColumnName("evaluation_reminder")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");

                entity.Property(e => e.HbysDoctorId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("hbys_doctor_id");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<HospitalPatient>(entity =>
            {
                entity.ToTable("hospital_patients");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");

                entity.Property(e => e.OriginalPatientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("original_patient_id");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<HospitalPatientAppointment>(entity =>
            {
                entity.ToTable("hospital_patient_appointment");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AppointmentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("appointment_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.PatientId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("patient_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<HospitalPatientCall>(entity =>
            {
                entity.ToTable("hospital_patient_calls");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CallCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("call_count");

                entity.Property(e => e.CallRecord)
                    .HasMaxLength(255)
                    .HasColumnName("call_record");

                entity.Property(e => e.CallResult)
                    .HasColumnType("enum('tuslanmadi','gelecek','gelmeyecek','1','2','3','4','5')")
                    .HasColumnName("call_result");

                entity.Property(e => e.CallStatus)
                    .HasColumnType("enum('aranmayi_bekliyor','araniyor','ulasildi','ulasilamadi')")
                    .HasColumnName("call_status")
                    .HasDefaultValueSql("'aranmayi_bekliyor'");

                entity.Property(e => e.CallType)
                    .HasColumnType("enum('appointment','evaluation')")
                    .HasColumnName("call_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.HbysAppointmentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("hbys_appointment_id");

                entity.Property(e => e.HospitalPatientId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("hospital_patient_id");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.TelewebDoCallLogId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("teleweb_do_call_log_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<HospitalPatientCallLog>(entity =>
            {
                entity.ToTable("hospital_patient_call_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CentralLogId)
                    .HasMaxLength(255)
                    .HasColumnName("central_log_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.PatientCallId)
                    .HasMaxLength(255)
                    .HasColumnName("patient_call_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<HospitalSetting>(entity =>
            {
                entity.ToTable("hospital_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Setting)
                    .HasMaxLength(255)
                    .HasColumnName("setting");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<HospitalVideoCallAppointment>(entity =>
            {
                entity.ToTable("hospital_video_call_appointments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("appointment_date");

                entity.Property(e => e.AppointmentInfo)
                    .HasMaxLength(50)
                    .HasColumnName("appointment_info");

                entity.Property(e => e.DoctorCallResult)
                    .HasMaxLength(50)
                    .HasColumnName("doctor_call_result");

                entity.Property(e => e.DoctorPhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("doctor_phone_number");

                entity.Property(e => e.DoctorStatus)
                    .HasMaxLength(50)
                    .HasColumnName("doctor_status");

                entity.Property(e => e.DoctorToken)
                    .HasMaxLength(50)
                    .HasColumnName("doctor_token");

                entity.Property(e => e.PatientCallResult)
                    .HasMaxLength(50)
                    .HasColumnName("patient_call_result");

                entity.Property(e => e.PatientPhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("patient_phone_number");

                entity.Property(e => e.PatientStatus)
                    .HasMaxLength(50)
                    .HasColumnName("patient_status");

                entity.Property(e => e.PatientToken)
                    .HasMaxLength(50)
                    .HasColumnName("patient_token");

                entity.Property(e => e.VideoCallStatus)
                    .HasMaxLength(50)
                    .HasColumnName("video_call_status");
            });

            modelBuilder.Entity<Html2Pdf>(entity =>
            {
                entity.ToTable("html2_pdfs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .HasColumnName("filename");

                entity.Property(e => e.Hash)
                    .HasMaxLength(40)
                    .HasColumnName("hash");

                entity.Property(e => e.Html)
                    .HasColumnType("mediumtext")
                    .HasColumnName("html");

                entity.Property(e => e.IpAddr)
                    .HasMaxLength(15)
                    .HasColumnName("ip_addr");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<HtmlTemplate>(entity =>
            {
                entity.ToTable("html_templates");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Html)
                    .HasColumnType("mediumtext")
                    .HasColumnName("html");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IbbIncident>(entity =>
            {
                entity.ToTable("ibb_incidents");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("incident_number");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("is_completed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsTransferred)
                    .HasColumnName("is_transferred")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OriginalId)
                    .HasMaxLength(255)
                    .HasColumnName("original_id");

                entity.Property(e => e.SecurityNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("security_number");

                entity.Property(e => e.SrId)
                    .HasMaxLength(40)
                    .HasColumnName("sr_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IbbIncidentLog>(entity =>
            {
                entity.ToTable("ibb_incident_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(30)
                    .HasColumnName("action");

                entity.Property(e => e.CompletionType)
                    .HasMaxLength(255)
                    .HasColumnName("completion_type");

                entity.Property(e => e.IbbIncidentNumber)
                    .HasMaxLength(50)
                    .HasColumnName("ibb_incident_number");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IsCompleted)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_completed");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.Request).HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<Ilce>(entity =>
            {
                entity.ToTable("ilce");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_turkish_ci");

                entity.HasIndex(e => e.IlceKey, "ilce_ilce_key_index");

                entity.Property(e => e.IlceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ilce_id");

                entity.Property(e => e.ControlledAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("controlled_at");

                entity.Property(e => e.IlceKey)
                    .HasColumnType("int(11)")
                    .HasColumnName("ilce_key");

                entity.Property(e => e.IlceSehirkey)
                    .HasColumnType("int(11)")
                    .HasColumnName("ilce_sehirkey");

                entity.Property(e => e.IlceTitle)
                    .HasMaxLength(255)
                    .HasColumnName("ilce_title");
            });

            modelBuilder.Entity<Incident>(entity =>
            {
                entity.ToTable("incidents");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Email, "ci_email_index");

                entity.HasIndex(e => e.HomePhone, "ci_home_phone_index");

                entity.HasIndex(e => e.IdentificationNumber, "ci_identification_number_index");

                entity.HasIndex(e => e.MobilePhone, "ci_mobile_phone_index");

                entity.HasIndex(e => e.Name, "ci_name_index");

                entity.HasIndex(e => e.LastName, "ci_surname_index");

                entity.HasIndex(e => e.WorkPhone, "ci_work_phone_index");

                entity.HasIndex(e => e.CompletionType, "completion_type_index");

                entity.HasIndex(e => e.CreatedAt, "created_at_index");

                entity.HasIndex(e => e.DepartmentId, "department_id");

                entity.HasIndex(e => e.IlceId, "incident_adres12_index");

                entity.HasIndex(e => e.MahalleId, "incident_adres13_index");

                entity.HasIndex(e => e.SokakId, "incident_adres14_index");

                entity.HasIndex(e => e.CaddeId, "incident_adres15_index");

                entity.HasIndex(e => e.DisKapiNo, "incident_adres16_index");

                entity.HasIndex(e => e.IcKapiNo, "incident_adres17_index");

                entity.HasIndex(e => e.GeogrophicCoordinate, "incident_adres18_index");

                entity.HasIndex(e => e.IlId, "incident_adres1_index");

                entity.HasIndex(e => e.Number, "incident_number_index");

                entity.HasIndex(e => e.Priority, "incident_priority_index");

                entity.HasIndex(e => e.IncidentSourceId, "incident_source_id_index");

                entity.HasIndex(e => e.IncidentType, "incident_type_index");

                entity.HasIndex(e => e.AdresNo, "incidents_adres_no_index");

                entity.HasIndex(e => e.BinaNo, "incidents_bina_no_index");

                entity.HasIndex(e => e.ClosedAt, "incidents_closed_at_index");

                entity.HasIndex(e => e.CompletionSurveyIncidentId, "incidents_completion_survey_incident_id_index");

                entity.HasIndex(e => e.CreatorDepartmentId, "incidents_creator_department_id_index");

                entity.HasIndex(e => e.DidTopicTimeout, "incidents_did_topic_timeout_index");

                entity.HasIndex(e => e.EducationStatusId, "incidents_education_status_id_index");

                entity.HasIndex(e => e.Gender, "incidents_gender_index");

                entity.HasIndex(e => e.HideContactInfo, "incidents_hide_contact_info_index");

                entity.HasIndex(e => e.IncidentTypeId, "incidents_incident_type_id_index");

                entity.HasIndex(e => e.IsAnonymous, "incidents_is_anonymous_index");

                entity.HasIndex(e => e.ScheduledAt, "incidents_scheduled_at_index");

                entity.HasIndex(e => e.MasterIncidentId, "master_incident_id_index");

                entity.HasIndex(e => e.OriginalId, "original_id_index");

                entity.HasIndex(e => e.PublicToken, "public_token_index");

                entity.HasIndex(e => e.ResponsibleUserId, "responsible_user_id_index");

                entity.HasIndex(e => e.Status, "status_index");

                entity.HasIndex(e => e.TopicId, "topic_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AdresNo)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("adres_no");

                entity.Property(e => e.AnswerTypes)
                    .HasMaxLength(255)
                    .HasColumnName("answer_types");

                entity.Property(e => e.ApprovalRequiredActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("approval_required_action_id");

                entity.Property(e => e.BinaNo)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bina_no");

                entity.Property(e => e.BirthDate).HasColumnName("birth_date");

                entity.Property(e => e.CaddeId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("cadde_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CanProcessWhenTopicTimeout).HasColumnName("can_process_when_topic_timeout");

                entity.Property(e => e.ClosedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("closed_at");

                entity.Property(e => e.CompleteDepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("complete_department_id");

                entity.Property(e => e.CompletePercentage)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("complete_percentage");

                entity.Property(e => e.CompleteUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("complete_user_id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CompleterUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("completer_user_id");

                entity.Property(e => e.CompletionReasonId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("completion_reason_id");

                entity.Property(e => e.CompletionSurveyIncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("completion_survey_incident_id");

                entity.Property(e => e.CompletionSurveyStatus)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("completion_survey_status");

                entity.Property(e => e.CompletionSurveyUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("completion_survey_user_id");

                entity.Property(e => e.CompletionText)
                    .HasColumnType("text")
                    .HasColumnName("completion_text");

                entity.Property(e => e.CompletionType)
                    .HasColumnType("enum('favorable','unfavorable','refusal','forward')")
                    .HasColumnName("completion_type");

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(255)
                    .HasColumnName("contact_address")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreationDuration)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("creation_duration")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatorDepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_department_id");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.DidTopicTimeout).HasColumnName("did_topic_timeout");

                entity.Property(e => e.DisKapiNo)
                    .HasMaxLength(16)
                    .HasColumnName("dis_kapi_no")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EducationStatusId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("education_status_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExceptSeconds)
                    .HasColumnType("bigint(10) unsigned")
                    .HasColumnName("except_seconds");

                entity.Property(e => e.Gender)
                    .HasColumnType("enum('male','female')")
                    .HasColumnName("gender");

                entity.Property(e => e.GeogrophicCoordinate)
                    .HasColumnName("geogrophic_coordinate")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HasCallRecord).HasColumnName("has_call_record");

                entity.Property(e => e.HideContactInfo).HasColumnName("hide_contact_info");

                entity.Property(e => e.HomePhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("home_phone");

                entity.Property(e => e.IcKapiNo)
                    .HasMaxLength(16)
                    .HasColumnName("ic_kapi_no")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IdentificationNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("identification_number");

                entity.Property(e => e.IgnoreOwnerNotifications).HasColumnName("ignore_owner_notifications");

                entity.Property(e => e.IlId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("il_id");

                entity.Property(e => e.IlceId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ilce_id");

                entity.Property(e => e.IncidentSourceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_source_id");

                entity.Property(e => e.IncidentType)
                    .HasColumnType("enum('demand','complaint','thank','project','information','notice')")
                    .HasColumnName("incident_type");

                entity.Property(e => e.IncidentTypeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_type_id");

                entity.Property(e => e.IsAnonymous).HasColumnName("is_anonymous");

                entity.Property(e => e.IsAutoClosed).HasColumnName("is_auto_closed");

                entity.Property(e => e.IsDivided).HasColumnName("isDivided");

                entity.Property(e => e.IsMessageCombine).HasColumnName("isMessageCombine");

                entity.Property(e => e.IsMutedCompletionSurvey)
                    .HasColumnName("is_muted_completion_survey")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsOtherDepartmentShow).HasColumnName("isOtherDepartmentShow");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MahalleId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mahalle_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MasterIncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("master_incident_id");

                entity.Property(e => e.MobilePhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Number)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("number");

                entity.Property(e => e.OriginalId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("original_id");

                entity.Property(e => e.PendingSequentialApproval).HasColumnName("pending_sequential_approval");

                entity.Property(e => e.PostponedTo)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("postponed_to");

                entity.Property(e => e.Priority)
                    .HasColumnType("enum('low','normal','high','critical')")
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'normal'");

                entity.Property(e => e.PublicToken)
                    .HasMaxLength(41)
                    .HasColumnName("public_token")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReopenCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("reopen_count");

                entity.Property(e => e.ResponsibleUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("responsible_user_id");

                entity.Property(e => e.SaveTransferredAt).HasColumnName("save_transferred_at");

                entity.Property(e => e.ScheduledAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("scheduled_at");

                entity.Property(e => e.SokakId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("sokak_id");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('new','pending','in_process','completed','reopened','forwarded','waiting_for_approval','approval_rejected','internal_returned','deleted','spam','returned','divided','postponed')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'new'");

                entity.Property(e => e.SurveyScore)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("survey_score");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.TopicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("topic_id");

                entity.Property(e => e.TransferredAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("transferred_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.WorkPhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("work_phone");

                entity.Property(e => e.WorkTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("work_time");
            });

            modelBuilder.Entity<IncidentAction>(entity =>
            {
                entity.ToTable("incident_actions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Action, "action_index");

                entity.HasIndex(e => e.IncidentId, "actions_incident_id_index");

                entity.HasIndex(e => e.UserId, "actions_user_id_index");

                entity.HasIndex(e => e.Source, "incident_actions_source_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnType("enum('create','transfer','return','reopen','forward','approve','approval_reject','process','comment','internal_return','complete','delete','spam','upload','ask','divide','postponed','answered')")
                    .HasColumnName("action");

                entity.Property(e => e.ApprovalRequired).HasColumnName("approval_required");

                entity.Property(e => e.HtmlText)
                    .HasColumnType("text")
                    .HasColumnName("html_text");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.IsMuted).HasColumnName("is_muted");

                entity.Property(e => e.OldResponsibleUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("old_responsible_user_id");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.Source)
                    .HasColumnType("enum('mobile','web','other','customs')")
                    .HasColumnName("source");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentActionApprovalRule>(entity =>
            {
                entity.ToTable("incident_action_approval_rules");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentActionId, "incident_action_approval_rules_incident_action_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ApprovalRules)
                    .HasMaxLength(2000)
                    .HasColumnName("approval_rules");

                entity.Property(e => e.CurrentOrder)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("current_order");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.OldResponsibleDepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("old_responsible_department_id");

                entity.Property(e => e.OldResponsibleUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("old_responsible_user_id");

                entity.Property(e => e.WorkFlowId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("work_flow_id");
            });

            modelBuilder.Entity<IncidentActionAttachment>(entity =>
            {
                entity.ToTable("incident_action_attachments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentActionId, "attachment_incident_action_id_index");

                entity.HasIndex(e => e.LocalName, "incident_action_attachments_local_name_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.GeogrophicCoordinate)
                    .HasMaxLength(255)
                    .HasColumnName("geogrophic_coordinate");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.LocalName).HasColumnName("local_name");

                entity.Property(e => e.RealName)
                    .HasMaxLength(255)
                    .HasColumnName("real_name");
            });

            modelBuilder.Entity<IncidentActionCustomField>(entity =>
            {
                entity.ToTable("incident_action_custom_fields");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CustomFieldId, "incident_action_custom_fields_custom_field_id_index");

                entity.HasIndex(e => e.IncidentActionId, "incident_action_custom_fields_incident_action_id_index");

                entity.HasIndex(e => e.IncidentId, "incident_action_custom_fields_incident_id_index");

                entity.HasIndex(e => e.ReportsNotInclude, "incident_action_custom_fields_reports_not_include_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Reference)
                    .HasColumnType("enum('web_form_object','web_form')")
                    .HasColumnName("reference")
                    .HasDefaultValueSql("'web_form'");

                entity.Property(e => e.ReferenceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reference_id");

                entity.Property(e => e.ReportsNotInclude).HasColumnName("reports_not_include");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<IncidentActionInfo>(entity =>
            {
                entity.ToTable("incident_action_infos");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IsPublic).HasColumnName("is_public");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserApiTokenId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_api_token_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<IncidentActionTransfer>(entity =>
            {
                entity.ToTable("incident_action_transfers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentActionId, "transfer_incident_action_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("group_id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IsInternalReturned).HasColumnName("is_internal_returned");

                entity.Property(e => e.OldDepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("old_department_id");

                entity.Property(e => e.OldResponsibleUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("old_responsible_user_id");

                entity.Property(e => e.OldTopicId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("old_topic_id");

                entity.Property(e => e.Target)
                    .HasColumnType("enum('user','group','department','topic','recursive')")
                    .HasColumnName("target");

                entity.Property(e => e.TopicId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("topic_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentApprovalTime>(entity =>
            {
                entity.ToTable("incident_approval_times");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.PassedTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("passed_time");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentAutomaticCall>(entity =>
            {
                entity.ToTable("incident_automatic_calls");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AutomaticCallLogId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("automatic_call_log_id");

                entity.Property(e => e.CallerNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("caller_number");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.TargetNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("target_number");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('ara_bagla','vatandasa_sun')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'ara_bagla'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentBulkDownload>(entity =>
            {
                entity.ToTable("incident_bulk_downloads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Cancel)
                    .HasColumnName("cancel")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DownloadPercentage)
                    .HasColumnType("double(8,2)")
                    .HasColumnName("download_percentage");

                entity.Property(e => e.IncidentCount)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_count");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.RequestObject)
                    .HasColumnType("text")
                    .HasColumnName("request_object");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentCallRecord>(entity =>
            {
                entity.ToTable("incident_call_records");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CallId)
                    .HasMaxLength(255)
                    .HasColumnName("call_id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid");
            });

            modelBuilder.Entity<IncidentCompletionReason>(entity =>
            {
                entity.ToTable("incident_completion_reasons");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletionType)
                    .HasColumnType("enum('favorable','unfavorable')")
                    .HasColumnName("completion_type");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<IncidentCompletionSurveyLog>(entity =>
            {
                entity.ToTable("incident_completion_survey_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CompletionSurveyIncidentId, "completion_survey");

                entity.HasIndex(e => e.CreatedAt, "incident_completion_survey_logs_created_at_index");

                entity.HasIndex(e => e.IncidentActionId, "incident_completion_survey_logs_incident_action_id_index");

                entity.HasIndex(e => e.IncidentId, "incident_completion_survey_logs_incident_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletionSurveyIncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("completion_survey_incident_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.IncidentSurveyId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_survey_id");

                entity.Property(e => e.WebformId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("webform_id");
            });

            modelBuilder.Entity<IncidentCustomField>(entity =>
            {
                entity.ToTable("incident_custom_fields");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "customf_incident_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CustomFieldId)
                    .HasMaxLength(255)
                    .HasColumnName("custom_field_id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IncidentEducationStatus>(entity =>
            {
                entity.ToTable("incident_education_statuses");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Title, "incident_education_statuses_title_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<IncidentFollower>(entity =>
            {
                entity.ToTable("incident_followers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "followers_incident_id_index");

                entity.HasIndex(e => e.UserId, "followers_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AddingUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("adding_user_id");

                entity.Property(e => e.FollowedAt)
                    .HasColumnType("int(11)")
                    .HasColumnName("followed_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.UnfollowedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("unfollowed_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentInternalReturn>(entity =>
            {
                entity.ToTable("incident_internal_returns");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentLog>(entity =>
            {
                entity.ToTable("incident_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Attribute)
                    .HasMaxLength(255)
                    .HasColumnName("attribute");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.NewValue)
                    .HasColumnType("text")
                    .HasColumnName("new_value");

                entity.Property(e => e.OldValue)
                    .HasColumnType("text")
                    .HasColumnName("old_value");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentNotification>(entity =>
            {
                entity.ToTable("incident_notifications");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.Target)
                    .HasMaxLength(50)
                    .HasColumnName("target");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentNotificationSetting>(entity =>
            {
                entity.ToTable("incident_notification_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentAction, "notifset_incident_action");

                entity.HasIndex(e => e.IncidentSourceId, "notifset_incident_source_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Conditions)
                    .HasColumnType("text")
                    .HasColumnName("conditions");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IncidentAction).HasColumnName("incident_action");

                entity.Property(e => e.IncidentSourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("incident_source_id");

                entity.Property(e => e.Options)
                    .HasMaxLength(1000)
                    .HasColumnName("options");

                entity.Property(e => e.Target)
                    .HasMaxLength(255)
                    .HasColumnName("target");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<IncidentPublicActionValidation>(entity =>
            {
                entity.ToTable("incident_public_action_validations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.UserToken, "public_users_user_token_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentPublicToken)
                    .HasMaxLength(255)
                    .HasColumnName("incident_public_token");

                entity.Property(e => e.IsValid).HasColumnName("is_valid");

                entity.Property(e => e.LastAttemptedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("last_attempted_at");

                entity.Property(e => e.MobilePhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");

                entity.Property(e => e.UserToken)
                    .HasMaxLength(128)
                    .HasColumnName("user_token");

                entity.Property(e => e.ValidationAttemptCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("validation_attempt_count");

                entity.Property(e => e.ValidationCode)
                    .HasMaxLength(6)
                    .HasColumnName("validation_code");
            });

            modelBuilder.Entity<IncidentReadLog>(entity =>
            {
                entity.ToTable("incident_read_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "incident_read_logs_incident_id_index");

                entity.HasIndex(e => new { e.UserId, e.IncidentId }, "incident_read_logs_user_id_incident_id_unique")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "incident_read_logs_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentResponsibleUser>(entity =>
            {
                entity.ToTable("incident_responsible_users");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "iru_incident_id");

                entity.HasIndex(e => e.UserId, "iru_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentScheduledAtNotificationLog>(entity =>
            {
                entity.ToTable("incident_scheduled_at_notification_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.ScheduledAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("scheduled_at");
            });

            modelBuilder.Entity<IncidentShortUrl>(entity =>
            {
                entity.ToTable("incident_short_urls");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "incidentshorturl_incident_id_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.ShortUrl)
                    .HasMaxLength(255)
                    .HasColumnName("short_url");
            });

            modelBuilder.Entity<IncidentShowLog>(entity =>
            {
                entity.ToTable("incident_show_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "incident_show_logs_incident_id_index");

                entity.HasIndex(e => e.ShowAt, "incident_show_logs_show_at_index");

                entity.HasIndex(e => e.UserId, "incident_show_logs_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.ShowAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("show_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentSource>(entity =>
            {
                entity.ToTable("incident_sources");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActionsCanBeViewedPublic)
                    .HasMaxLength(400)
                    .HasColumnName("actions_can_be_viewed_public");

                entity.Property(e => e.AllowFileUpload)
                    .IsRequired()
                    .HasColumnName("allow_file_upload")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AllowReopenInDays)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("allow_reopen_in_days")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.AnswerOptions)
                    .HasMaxLength(100)
                    .HasColumnName("answer_options");

                entity.Property(e => e.AutoCompleteDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("auto_complete_days");

                entity.Property(e => e.AutoCompleteIfWaitingForApproval)
                    .HasColumnName("auto_complete_if_waiting_for_approval")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CanBeCommented).HasColumnName("can_be_commented");

                entity.Property(e => e.CanBeDeleted)
                    .IsRequired()
                    .HasColumnName("can_be_deleted")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CanBeDivided).HasColumnName("can_be_divided");

                entity.Property(e => e.CanBeReopened)
                    .IsRequired()
                    .HasColumnName("can_be_reopened")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CanBeReturned).HasColumnName("can_be_returned");

                entity.Property(e => e.ConnectWithUlakbel)
                    .HasColumnName("connect_with_ulakbel")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Custom)
                    .HasColumnType("text")
                    .HasColumnName("custom");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DivideOptions)
                    .HasColumnType("text")
                    .HasColumnName("divide_options");

                entity.Property(e => e.ExactlyResponsibleUserOnly).HasColumnName("exactly_responsible_user_only");

                entity.Property(e => e.ForceSendCriticalNotifications)
                    .HasColumnName("force_send_critical_notifications")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HideIncidentActionsFromCreator)
                    .HasColumnName("hide_incident_actions_from_creator")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HomeIcon)
                    .HasMaxLength(255)
                    .HasColumnName("home_icon");

                entity.Property(e => e.HomePanel)
                    .HasColumnType("enum('default','primary','success','info','warning','danger','other')")
                    .HasColumnName("home_panel")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.HomePanelCustomColor)
                    .HasMaxLength(7)
                    .HasColumnName("home_panel_custom_color")
                    .HasDefaultValueSql("'#337ab7'");

                entity.Property(e => e.HomePanelCustomTextColor)
                    .HasMaxLength(7)
                    .HasColumnName("home_panel_custom_text_color")
                    .HasDefaultValueSql("'#ffffff'");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .HasColumnName("icon")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IncidentActionInfos)
                    .HasColumnType("text")
                    .HasColumnName("incident_action_infos");

                entity.Property(e => e.IncidentInfoFieldsCanBeViewedPublic)
                    .HasMaxLength(400)
                    .HasColumnName("incident_info_fields_can_be_viewed_public");

                entity.Property(e => e.IsWebForm).HasColumnName("is_web_form");

                entity.Property(e => e.NumbersOfReopen)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("numbers_of_reopen")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.OrderPriority)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("order_priority");

                entity.Property(e => e.PublicIncidentShowSmsVerification)
                    .HasColumnName("public_incident_show_sms_verification")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StaffOnly)
                    .IsRequired()
                    .HasColumnName("staff_only")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UlakbelAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ulakbel_address");

                entity.Property(e => e.UlakbelApiToken)
                    .HasMaxLength(255)
                    .HasColumnName("ulakbel_api_token");
            });

            modelBuilder.Entity<IncidentSurvey>(entity =>
            {
                entity.ToTable("incident_surveys");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "incident_surveys_incident_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.WebformId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("webform_id");
            });

            modelBuilder.Entity<IncidentSurveyAnswer>(entity =>
            {
                entity.ToTable("incident_survey_answers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentSurveyId, "incident_survey_answers_incident_survey_id_index");

                entity.HasIndex(e => e.WebformFieldKey, "incident_survey_answers_webform_field_key_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentSurveyId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_survey_id");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");

                entity.Property(e => e.WebformFieldKey)
                    .HasMaxLength(21)
                    .HasColumnName("webform_field_key");
            });

            modelBuilder.Entity<IncidentSurveyBulkDownload>(entity =>
            {
                entity.ToTable("incident_survey_bulk_downloads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.RequestObject)
                    .HasColumnType("text")
                    .HasColumnName("request_object");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentTimeout>(entity =>
            {
                entity.ToTable("incident_timeouts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ModelId, "incident_timeouts_model_id_index");

                entity.HasIndex(e => e.Model, "incident_timeouts_model_index");

                entity.HasIndex(e => new { e.Model, e.ModelId }, "incident_timeouts_model_model_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Model)
                    .HasColumnType("enum('department','incident_topic','incident_source')")
                    .HasColumnName("model");

                entity.Property(e => e.ModelId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("model_id");

                entity.Property(e => e.Seconds)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("seconds");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('minutes','hours','days')")
                    .HasColumnName("type");

                entity.Property(e => e.Value)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<IncidentTimeoutFlow>(entity =>
            {
                entity.ToTable("incident_timeout_flows");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Targets)
                    .HasColumnType("text")
                    .HasColumnName("targets");

                entity.Property(e => e.TopicIds)
                    .HasMaxLength(255)
                    .HasColumnName("topic_ids");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<IncidentTimeoutFlowStage>(entity =>
            {
                entity.ToTable("incident_timeout_flow_stages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_action_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.IncidentTimeoutFlowId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_timeout_flow_id");

                entity.Property(e => e.Order)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("order");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.TimeType)
                    .HasMaxLength(255)
                    .HasColumnName("time_type")
                    .HasDefaultValueSql("'hours'");

                entity.Property(e => e.TimeValue)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("time_value");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentTimeoutNotification>(entity =>
            {
                entity.ToTable("incident_timeout_notifications");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentNumber, "incident_timeout_notifications_incident_number_index");

                entity.HasIndex(e => e.UserId, "incident_timeout_notifications_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_number");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.PublicToken)
                    .HasMaxLength(41)
                    .HasColumnName("public_token");

                entity.Property(e => e.TimeoutSecond)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("timeout_second");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentTimeoutReportNotificationSetting>(entity =>
            {
                entity.ToTable("incident_timeout_report_notification_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentSources)
                    .HasMaxLength(255)
                    .HasColumnName("incident_sources");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RepetitionDays)
                    .HasMaxLength(255)
                    .HasColumnName("repetition_days");

                entity.Property(e => e.RepetitionFrequencyType)
                    .HasColumnType("enum('day','week','month','year','first_day_of_the_month','last_day_of_the_month')")
                    .HasColumnName("repetition_frequency_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WorkTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("work_time");
            });

            modelBuilder.Entity<IncidentTimeoutTime>(entity =>
            {
                entity.ToTable("incident_timeout_times");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .HasColumnName("model");

                entity.Property(e => e.ModelId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("model_id");

                entity.Property(e => e.TimeoutSeconds)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("timeout_seconds");
            });

            modelBuilder.Entity<IncidentTopic>(entity =>
            {
                entity.ToTable("incident_topics");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DefaultIncidentPriority, "default_incident_priority_index");

                entity.HasIndex(e => e.StaffOnly, "incident_topics_staff_only_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.DefaultIncidentPriority)
                    .HasColumnType("enum('low','normal','high','critical')")
                    .HasColumnName("default_incident_priority");

                entity.Property(e => e.DefaultIncidentTypeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("default_incident_type_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ResponsibleUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("responsible_user_id");

                entity.Property(e => e.StaffOnly).HasColumnName("staff_only");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.TopicGroupId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("topic_group_id");

                entity.Property(e => e.TopicType)
                    .HasColumnType("enum('all','staff','citizen','info')")
                    .HasColumnName("topic_type")
                    .HasDefaultValueSql("'all'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.WebFormFlowChartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("web_form_flow_chart_id");
            });

            modelBuilder.Entity<IncidentTopicGroup>(entity =>
            {
                entity.ToTable("incident_topic_groups");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<IncidentType>(entity =>
            {
                entity.ToTable("incident_types");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<IncidentWaitingApprovalAction>(entity =>
            {
                entity.ToTable("incident_waiting_approval_actions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "incident_waiting_approval_actions_incident_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .HasColumnName("action");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<IncidentWorkTime>(entity =>
            {
                entity.ToTable("incident_work_times");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.EndTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("end_time");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.StartTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("start_time");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<InstagramLog>(entity =>
            {
                entity.ToTable("instagram_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.CustomsIncidentRelationId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customs_incident_relation_id");

                entity.Property(e => e.CustomsMessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_message_id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.RemoteUserId)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_id");

                entity.Property(e => e.RemoteUserName)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_name");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<InternalApiLog>(entity =>
            {
                entity.ToTable("internal_api_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.PerformadAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performad_at");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<IvrTag>(entity =>
            {
                entity.ToTable("ivr_tags");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IvrId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ivr_id");

                entity.Property(e => e.Key)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("key");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("jobs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Queue, "jobs_queue_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Attempts)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("attempts");

                entity.Property(e => e.AvailableAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("available_at");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Payload).HasColumnName("payload");

                entity.Property(e => e.Queue).HasColumnName("queue");

                entity.Property(e => e.ReservedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("reserved_at");
            });

            modelBuilder.Entity<KpsRequestLog>(entity =>
            {
                entity.ToTable("kps_request_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BirthDate)
                    .HasMaxLength(10)
                    .HasColumnName("birth_date");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IdentificationNumber)
                    .HasMaxLength(15)
                    .HasColumnName("identification_number");

                entity.Property(e => e.RequestUrl)
                    .HasMaxLength(1000)
                    .HasColumnName("request_url");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<Localization>(entity =>
            {
                entity.ToTable("localizations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Key, "localizations_key_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Default)
                    .HasColumnType("text")
                    .HasColumnName("default");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<LoginLog>(entity =>
            {
                entity.ToTable("login_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IsLoggedIn).HasColumnName("is_logged_in");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Mahalle>(entity =>
            {
                entity.ToTable("mahalle");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_turkish_ci");

                entity.HasIndex(e => e.Aktif, "mahalle_aktif_index");

                entity.HasIndex(e => e.MahalleIlcekey, "mahalle_mahalle_ilcekey_index");

                entity.Property(e => e.MahalleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mahalle_id");

                entity.Property(e => e.Aktif)
                    .IsRequired()
                    .HasColumnName("aktif")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ControlledAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("controlled_at");

                entity.Property(e => e.MahalleIlcekey)
                    .HasColumnType("int(11)")
                    .HasColumnName("mahalle_ilcekey");

                entity.Property(e => e.MahalleKey)
                    .HasColumnType("int(11)")
                    .HasColumnName("mahalle_key");

                entity.Property(e => e.MahalleTitle)
                    .HasMaxLength(255)
                    .HasColumnName("mahalle_title");
            });

            modelBuilder.Entity<MedDataAppointmentLog>(entity =>
            {
                entity.ToTable("med_data_appointment_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .HasColumnName("action");

                entity.Property(e => e.BolumId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bolum_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DrId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("dr_id");

                entity.Property(e => e.IsSuccess).HasColumnName("is_success");

                entity.Property(e => e.SiraNo)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sira_no");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<MedDataCallerNote>(entity =>
            {
                entity.ToTable("med_data_caller_notes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DosyaNo, "med_data_caller_notes_dosya_no_index");

                entity.HasIndex(e => e.KimlikNo, "med_data_caller_notes_kimlik_no_index");

                entity.HasIndex(e => e.Telefon, "med_data_caller_notes_telefon_index");

                entity.HasIndex(e => e.UserId, "med_data_caller_notes_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DosyaNo)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("dosya_no");

                entity.Property(e => e.KimlikNo)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("kimlik_no");

                entity.Property(e => e.Telefon)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("telefon");

                entity.Property(e => e.Text)
                    .HasMaxLength(255)
                    .HasColumnName("text");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<MedDataReceteLog>(entity =>
            {
                entity.ToTable("med_data_recete_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CepTel, "med_data_recete_logs_cep_tel_index");

                entity.HasIndex(e => e.SiraNo, "med_data_recete_logs_sira_no_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CepTel)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("CEP_TEL");

                entity.Property(e => e.GssReceteNo)
                    .HasMaxLength(255)
                    .HasColumnName("GSS_RECETE_NO");

                entity.Property(e => e.SiraNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("SIRA_NO");
            });

            modelBuilder.Entity<MedDataSetting>(entity =>
            {
                entity.ToTable("med_data_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Key, "med_data_settings_key_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Batch)
                    .HasColumnType("int(11)")
                    .HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .HasMaxLength(255)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<Next4BizIssueLog>(entity =>
            {
                entity.ToTable("next4_biz_issue_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Request)
                    .HasColumnType("mediumtext")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");
            });

            modelBuilder.Entity<Nobetciler>(entity =>
            {
                entity.ToTable("nobetciler");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("end_date");

                entity.Property(e => e.MobilePhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Region)
                    .HasMaxLength(255)
                    .HasColumnName("region");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notifications");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.NotifiableId, e.NotifiableType }, "notifications_notifiable_id_notifiable_type_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.NotifiableId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("notifiable_id");

                entity.Property(e => e.NotifiableType).HasColumnName("notifiable_type");

                entity.Property(e => e.ReadAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("read_at");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<NotificationSetting>(entity =>
            {
                entity.ToTable("notification_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentAction, "notifset_incident_action");

                entity.HasIndex(e => e.IncidentSourceId, "notifset_incident_source_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IncidentAction).HasColumnName("incident_action");

                entity.Property(e => e.IncidentSourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("incident_source_id");

                entity.Property(e => e.Target)
                    .HasMaxLength(255)
                    .HasColumnName("target");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OmisLog>(entity =>
            {
                entity.ToTable("omis_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");
            });

            modelBuilder.Entity<OutOfWorkCallLog>(entity =>
            {
                entity.ToTable("out_of_work_call_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DialNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("dial_number");
            });

            modelBuilder.Entity<Pano>(entity =>
            {
                entity.ToTable("panos");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsMobile)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_mobile");

                entity.Property(e => e.LimitWithVisibleDepartments)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("limit_with_visible_departments");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Email, "password_resets_email_index");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Token)
                    .HasMaxLength(255)
                    .HasColumnName("token");
            });

            modelBuilder.Entity<PasswordReset1>(entity =>
            {
                entity.ToTable("password_reset");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.UserId, "password_reset_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsPasswordChanged).HasColumnName("is_password_changed");

                entity.Property(e => e.IsVerified).HasColumnName("is_verified");

                entity.Property(e => e.LastAttemptedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("last_attempted_at");

                entity.Property(e => e.PublicToken)
                    .HasMaxLength(60)
                    .HasColumnName("public_token");

                entity.Property(e => e.Token)
                    .HasMaxLength(10)
                    .HasColumnName("token");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");

                entity.Property(e => e.ValidationAttemptCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("validation_attempt_count");
            });

            modelBuilder.Entity<PhoneDirectoryGroup>(entity =>
            {
                entity.ToTable("phone_directory_groups");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Active, "phone_directory_groups_active_index");

                entity.HasIndex(e => e.DepartmentId, "phone_directory_groups_department_id_index");

                entity.HasIndex(e => e.Name, "phone_directory_groups_name_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.IsOpenToEveryone).HasColumnName("is_open_to_everyone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.SendToCcenter).HasColumnName("send_to_ccenter");
            });

            modelBuilder.Entity<PhoneDirectoryUser>(entity =>
            {
                entity.ToTable("phone_directory_users");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Active, "phone_directory_users_active_index");

                entity.HasIndex(e => e.CreatorDepartmentId, "phone_directory_users_department_id_index");

                entity.HasIndex(e => e.Email, "phone_directory_users_email_index");

                entity.HasIndex(e => e.FaxNumber, "phone_directory_users_fax_number_index");

                entity.HasIndex(e => e.GroupId, "phone_directory_users_group_id_index");

                entity.HasIndex(e => e.IncludeEmailList, "phone_directory_users_include_email_list_index");

                entity.HasIndex(e => e.IncludeFaxList, "phone_directory_users_include_fax_list_index");

                entity.HasIndex(e => e.IncludeSmsList, "phone_directory_users_include_sms_list_index");

                entity.HasIndex(e => e.InternalNumber, "phone_directory_users_internal_number_index");

                entity.HasIndex(e => e.Name, "phone_directory_users_name_index");

                entity.HasIndex(e => e.PhoneNumber, "phone_directory_users_phone_number_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatorDepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_department_id");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FaxNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("fax_number");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");

                entity.Property(e => e.IncludeCallList).HasColumnName("include_call_list");

                entity.Property(e => e.IncludeEmailList).HasColumnName("include_email_list");

                entity.Property(e => e.IncludeFaxList).HasColumnName("include_fax_list");

                entity.Property(e => e.IncludeSmsList).HasColumnName("include_sms_list");

                entity.Property(e => e.InternalNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("internal_number");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");
            });

            modelBuilder.Entity<PhoneDirectoryUserImportLog>(entity =>
            {
                entity.ToTable("phone_directory_user_import_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.PercentageOfComplete)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("percentage_of_complete");

                entity.Property(e => e.PhoneDirectoryGroupId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_directory_group_id");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.RowsCount)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rows_count");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('pending','complete','fail','started')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'pending'");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<PreviewCallList>(entity =>
            {
                entity.ToTable("preview_call_lists");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .HasColumnName("action");

                entity.Property(e => e.AutomaticCallLogId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("automatic_call_log_id");

                entity.Property(e => e.AutomaticCallPlanTargetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("automatic_call_plan_target_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(550)
                    .HasColumnName("description");

                entity.Property(e => e.ProcessingAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("processing_at");
            });

            modelBuilder.Entity<ProAktifLog>(entity =>
            {
                entity.ToTable("pro_aktif_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.ReturnIsEmriId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("return_is_emri_id");

                entity.Property(e => e.ReturnIsEmriNo)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("return_is_emri_no");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'waiting'");
            });

            modelBuilder.Entity<PublicUser>(entity =>
            {
                entity.ToTable("public_users");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IdentificationNumber, "public_users_identification_number_index");

                entity.HasIndex(e => e.UserToken, "public_users_user_token_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IdentificationNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("identification_number");

                entity.Property(e => e.IsValid).HasColumnName("is_valid");

                entity.Property(e => e.LastAttemptedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("last_attempted_at");

                entity.Property(e => e.MobilePhone)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(15)
                    .HasColumnName("user_ip");

                entity.Property(e => e.UserToken)
                    .HasMaxLength(128)
                    .HasColumnName("user_token");

                entity.Property(e => e.ValidationAttemptCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("validation_attempt_count");

                entity.Property(e => e.ValidationCode)
                    .HasMaxLength(6)
                    .HasColumnName("validation_code");
            });

            modelBuilder.Entity<QmComputedForm>(entity =>
            {
                entity.ToTable("qm_computed_forms");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Answers)
                    .HasColumnType("json")
                    .HasColumnName("answers");

                entity.Property(e => e.AutoCallPlan)
                    .HasColumnType("int(11)")
                    .HasColumnName("auto_call_plan");

                entity.Property(e => e.CallTime)
                    .HasMaxLength(255)
                    .HasColumnName("call_time");

                entity.Property(e => e.CallTimeRaw)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("call_time_raw");

                entity.Property(e => e.CallType)
                    .HasMaxLength(255)
                    .HasColumnName("call_type");

                entity.Property(e => e.Caller)
                    .HasMaxLength(255)
                    .HasColumnName("caller");

                entity.Property(e => e.ComputingSeconds)
                    .HasColumnType("int(11)")
                    .HasColumnName("computing_seconds");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentTitle)
                    .HasMaxLength(255)
                    .HasColumnName("department_title");

                entity.Property(e => e.DetailText)
                    .HasColumnType("text")
                    .HasColumnName("detail_text");

                entity.Property(e => e.Extension)
                    .HasMaxLength(255)
                    .HasColumnName("extension");

                entity.Property(e => e.FormId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("form_id");

                entity.Property(e => e.IsExcludedFromEvaluation)
                    .HasColumnName("is_excluded_from_evaluation")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.JoinTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("join_time");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ObjectionDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("objection_date");

                entity.Property(e => e.ObjectionReviewDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("objection_review_date");

                entity.Property(e => e.ObjectionStatus)
                    .HasMaxLength(30)
                    .HasColumnName("objection_status");

                entity.Property(e => e.Target)
                    .HasMaxLength(15)
                    .HasColumnName("target");

                entity.Property(e => e.TelewebQueue)
                    .HasColumnType("int(11)")
                    .HasColumnName("teleweb_queue");

                entity.Property(e => e.TotalScore)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_score");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.WhoClosed)
                    .HasMaxLength(255)
                    .HasColumnName("who_closed");
            });

            modelBuilder.Entity<QmComputedFormObjection>(entity =>
            {
                entity.ToTable("qm_computed_form_objections");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.NewAnswers)
                    .HasColumnType("text")
                    .HasColumnName("new_answers");

                entity.Property(e => e.NewDetailText)
                    .HasColumnType("text")
                    .HasColumnName("new_detail_text");

                entity.Property(e => e.NewTotalScore)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("new_total_score");

                entity.Property(e => e.ObjectionDeniedText)
                    .HasMaxLength(2000)
                    .HasColumnName("objection_denied_text");

                entity.Property(e => e.ObjectionReviewDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("objection_review_date");

                entity.Property(e => e.ObjectionReviewerUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("objection_reviewer_user_id");

                entity.Property(e => e.OldAnswers)
                    .HasColumnType("text")
                    .HasColumnName("old_answers");

                entity.Property(e => e.OldDetailText)
                    .HasColumnType("text")
                    .HasColumnName("old_detail_text");

                entity.Property(e => e.OldTotalScore)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("old_total_score");

                entity.Property(e => e.QmComputedFormId)
                    .HasColumnType("int(11)")
                    .HasColumnName("qm_computed_form_id");

                entity.Property(e => e.ReasonForObjection)
                    .HasColumnType("text")
                    .HasColumnName("reason_for_objection");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('pending','reevaluated','objection_denied')")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<QmComputedFormTime>(entity =>
            {
                entity.ToTable("qm_computed_form_times");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(20)
                    .HasColumnName("action");

                entity.Property(e => e.FinishedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("finished_at");

                entity.Property(e => e.QmComputedFormId)
                    .HasColumnType("int(11)")
                    .HasColumnName("qm_computed_form_id");

                entity.Property(e => e.Seconds)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("seconds");

                entity.Property(e => e.StartedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("started_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<QmForm>(entity =>
            {
                entity.ToTable("qm_forms");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<QmFormQuestion>(entity =>
            {
                entity.ToTable("qm_form_questions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.FormId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("form_id");

                entity.Property(e => e.OldId)
                    .HasColumnType("int(11)")
                    .HasColumnName("old_id");

                entity.Property(e => e.RelatedAnswer)
                    .HasColumnType("int(11)")
                    .HasColumnName("related_answer");

                entity.Property(e => e.RelatedQuestion)
                    .HasColumnType("int(11)")
                    .HasColumnName("related_question");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Visibility)
                    .HasMaxLength(50)
                    .HasColumnName("visibility");
            });

            modelBuilder.Entity<QmOption>(entity =>
            {
                entity.ToTable("qm_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AbsorbingElement)
                    .HasColumnName("absorbing_element")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.OldId)
                    .HasColumnType("int(11)")
                    .HasColumnName("old_id");

                entity.Property(e => e.QuestionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("question_id");

                entity.Property(e => e.Score)
                    .HasColumnType("int(11)")
                    .HasColumnName("score");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<QueueLiveCallsBulkDownload>(entity =>
            {
                entity.ToTable("queue_live_calls_bulk_downloads");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CurrentPage)
                    .HasColumnType("int(11)")
                    .HasColumnName("current_page");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EndTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("end_time");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .HasColumnName("local_name");

                entity.Property(e => e.RequestObject)
                    .HasColumnType("text")
                    .HasColumnName("request_object");

                entity.Property(e => e.StartTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_time");

                entity.Property(e => e.TotalCount)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("total_count");

                entity.Property(e => e.TotalPage)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_page");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<ScheduledIncident>(entity =>
            {
                entity.ToTable("scheduled_incidents");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EndTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("end_time");

                entity.Property(e => e.EndTimeType)
                    .HasColumnType("enum('no_end_time','end_time','number_of_repetitions')")
                    .HasColumnName("end_time_type");

                entity.Property(e => e.IncidentCreateTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_create_time");

                entity.Property(e => e.IncidentRequest)
                    .HasColumnType("text")
                    .HasColumnName("incident_request");

                entity.Property(e => e.NumberOfRepetitions)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("number_of_repetitions");

                entity.Property(e => e.NumberOfWork)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_work");

                entity.Property(e => e.OneTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("one_time");

                entity.Property(e => e.RepetitionDays)
                    .HasMaxLength(255)
                    .HasColumnName("repetition_days");

                entity.Property(e => e.RepetitionFrequencyType)
                    .HasColumnType("enum('day','week','month','year','three_monthly','six_monthly','first_day_of_the_month','last_day_of_the_month','first_day_of_the_year','last_day_of_the_year','one_time')")
                    .HasColumnName("repetition_frequency_type");

                entity.Property(e => e.StartTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("start_time");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<ScheduledIncidentLog>(entity =>
            {
                entity.ToTable("scheduled_incident_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.ErrorLog)
                    .HasColumnType("text")
                    .HasColumnName("error_log");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.ScheduledIncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("scheduled_incident_id");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('success','error')")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Sehir>(entity =>
            {
                entity.ToTable("sehir");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_turkish_ci");

                entity.Property(e => e.SehirId)
                    .HasColumnType("int(2)")
                    .HasColumnName("sehir_id");

                entity.Property(e => e.SehirKey)
                    .HasColumnType("int(11)")
                    .HasColumnName("sehir_key");

                entity.Property(e => e.SehirTitle)
                    .HasMaxLength(255)
                    .HasColumnName("sehir_title");
            });

            modelBuilder.Entity<ServerRecord>(entity =>
            {
                entity.ToTable("server_records");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.ReferenceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reference_id");

                entity.Property(e => e.ReferenceModel)
                    .HasMaxLength(50)
                    .HasColumnName("reference_model");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Setting1, "settings_setting_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Group)
                    .HasMaxLength(255)
                    .HasColumnName("group")
                    .HasDefaultValueSql("'general'");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");

                entity.Property(e => e.Setting1).HasColumnName("setting");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('text','file','image','select','textarea','color','checkbox','number','password')")
                    .HasColumnName("type");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<SmartResponseFlow>(entity =>
            {
                entity.ToTable("smart_response_flows");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomAccountIds)
                    .HasMaxLength(255)
                    .HasColumnName("custom_account_ids");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.FlowChartData)
                    .HasColumnType("text")
                    .HasColumnName("flow_chart_data");

                entity.Property(e => e.IncidentSourceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_source_id");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Keywords)
                    .HasColumnType("text")
                    .HasColumnName("keywords");

                entity.Property(e => e.LastTimeoutMessage)
                    .HasColumnType("int(11)")
                    .HasColumnName("last_timeout_message")
                    .HasDefaultValueSql("'900'");

                entity.Property(e => e.Priority)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("priority");

                entity.Property(e => e.RegexString)
                    .HasMaxLength(100)
                    .HasColumnName("regex_string");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Trigger)
                    .HasMaxLength(30)
                    .HasColumnName("trigger");
            });

            modelBuilder.Entity<SmartResponseFlowSetting>(entity =>
            {
                entity.ToTable("smart_response_flow_settings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Key)
                    .HasMaxLength(255)
                    .HasColumnName("key");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasMaxLength(1000)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<SmartResponseNumberSession>(entity =>
            {
                entity.ToTable("smart_response_number_sessions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExpiredAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("expired_at");

                entity.Property(e => e.LastStage)
                    .HasMaxLength(255)
                    .HasColumnName("last_stage");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");

                entity.Property(e => e.SmartResponseFlowId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("smart_response_flow_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(70)
                    .HasColumnName("source");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<SmartResponseNumberStage>(entity =>
            {
                entity.ToTable("smart_response_number_stages");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasMaxLength(255)
                    .HasColumnName("answer");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomsMessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_message_id");

                entity.Property(e => e.SmartResponseNumberSessionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("smart_response_number_session_id");

                entity.Property(e => e.Stage)
                    .HasMaxLength(255)
                    .HasColumnName("stage");
            });

            modelBuilder.Entity<SmsLog>(entity =>
            {
                entity.ToTable("sms_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentActionId, "sms_log_incident_action_id_index");

                entity.HasIndex(e => e.Recipient, "sms_log_to_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.Recipient)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("recipient");

                entity.Property(e => e.Response)
                    .HasMaxLength(255)
                    .HasColumnName("response")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<SoforDurum>(entity =>
            {
                entity.ToTable("sofor_durum");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "sofor_durum_incident_id_index");

                entity.HasIndex(e => e.Status, "sofor_durum_status_index");

                entity.HasIndex(e => e.UserId, "sofor_durum_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<SokakCadde>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sokak_cadde");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_turkish_ci");

                entity.HasIndex(e => e.Aktif, "sokak_cadde_aktif_index");

                entity.HasIndex(e => e.CsbmKod, "sokak_cadde_csbm_kod_unique")
                    .IsUnique();

                entity.HasIndex(e => e.SokakCaddeId, "sokak_cadde_id")
                    .IsUnique();

                entity.HasIndex(e => e.SokakCaddeMahallekey, "sokak_cadde_sokak_cadde_mahallekey_index");

                entity.HasIndex(e => e.SokakCaddeTitle, "sokak_cadde_title");

                entity.Property(e => e.Aktif)
                    .IsRequired()
                    .HasColumnName("aktif")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ControlledAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("controlled_at");

                entity.Property(e => e.CsbmKod)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("csbm_kod");

                entity.Property(e => e.CsbmTipi)
                    .HasColumnType("enum('CADDE','SOKAK','BULVAR','MEYDAN','KÜME EVLER','KÖY SOKAĞI')")
                    .HasColumnName("csbm_tipi");

                entity.Property(e => e.SokakCaddeId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sokak_cadde_id");

                entity.Property(e => e.SokakCaddeMahallekey)
                    .HasColumnType("int(11)")
                    .HasColumnName("sokak_cadde_mahallekey");

                entity.Property(e => e.SokakCaddeTitle).HasColumnName("sokak_cadde_title");
            });

            modelBuilder.Entity<SupervisorOperatorStatusChangeLog>(entity =>
            {
                entity.ToTable("supervisor_operator_status_change_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Extension)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("extension");

                entity.Property(e => e.NewStatus)
                    .HasMaxLength(255)
                    .HasColumnName("new_status");

                entity.Property(e => e.OldStatus)
                    .HasMaxLength(255)
                    .HasColumnName("old_status");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<TarnetCustomer>(entity =>
            {
                entity.ToTable("tarnet_customers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Number)
                    .HasMaxLength(255)
                    .HasColumnName("number");

                entity.Property(e => e.TarnetCustomerType)
                    .HasMaxLength(255)
                    .HasColumnName("tarnet_customer_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<TarnetCustomerInfo>(entity =>
            {
                entity.ToTable("tarnet_customer_infos");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IntValue, "legal_entity_infos_int_value_index");

                entity.HasIndex(e => e.Key, "legal_entity_infos_key_index");

                entity.HasIndex(e => new { e.Key, e.Value }, "legal_entity_infos_key_value_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IntValue)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("int_value");

                entity.Property(e => e.Key)
                    .HasColumnType("enum('mobile_phone','work_phone','home_phone')")
                    .HasColumnName("key");

                entity.Property(e => e.TarnetCustomerId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tarnet_customer_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TarnetLog>(entity =>
            {
                entity.ToTable("tarnet_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CallId)
                    .HasMaxLength(255)
                    .HasColumnName("call_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Direction)
                    .HasColumnType("enum('in','out')")
                    .HasColumnName("direction");

                entity.Property(e => e.Extension)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("extension");

                entity.Property(e => e.Menu)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("menu");

                entity.Property(e => e.Note)
                    .HasMaxLength(1000)
                    .HasColumnName("note");

                entity.Property(e => e.Target)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("target");

                entity.Property(e => e.TarnetCustomerId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tarnet_customer_id");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<TasarrufDepartmentHinterland>(entity =>
            {
                entity.ToTable("tasarruf_department_hinterlands");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.IlId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("il_id");

                entity.Property(e => e.IlceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ilce_id");
            });

            modelBuilder.Entity<TasarrufFeeRateRule>(entity =>
            {
                entity.ToTable("tasarruf_fee_rate_rules");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.FirstCustomersDeliveryPercentage, "first_cust_deliv_perc_index");

                entity.HasIndex(e => e.FirstCustomersInAdvancedPercentage, "first_cust_in_adv_index");

                entity.HasIndex(e => e.FirstCustomersInstallmentPercentage, "first_cust_inst_index");

                entity.HasIndex(e => e.NormalCustomersDeliveryPercentage, "normal_cust_deliv_perc_index");

                entity.HasIndex(e => e.NormalCustomersInAdvancedPercentage, "normal_cust_in_adv_index");

                entity.HasIndex(e => e.NormalCustomersInstallmentPercentage, "normal_cust_inst_index");

                entity.HasIndex(e => e.FrontPaymentMaxInstallment, "tasarruf_fee_rate_rules_front_payment_max_installment_index");

                entity.HasIndex(e => e.FrontPaymentMaxPercentage, "tasarruf_fee_rate_rules_front_payment_max_percentage_index");

                entity.HasIndex(e => e.FrontPaymentMinInstallment, "tasarruf_fee_rate_rules_front_payment_min_installment_index");

                entity.HasIndex(e => e.FrontPaymentMinPercentage, "tasarruf_fee_rate_rules_front_payment_min_percentage_index");

                entity.HasIndex(e => e.PlanId, "tasarruf_fee_rate_rules_plan_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DeliveryMonth)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delivery_month");

                entity.Property(e => e.FirstCustomersDeliveryPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("first_customers_delivery_percentage");

                entity.Property(e => e.FirstCustomersDeliveryPercentageInstallment)
                    .HasPrecision(6, 3)
                    .HasColumnName("first_customers_delivery_percentage_installment");

                entity.Property(e => e.FirstCustomersInAdvancedPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("first_customers_in_advanced_percentage");

                entity.Property(e => e.FirstCustomersInstallmentCreditCardPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("first_customers_installment_credit_card_percentage");

                entity.Property(e => e.FirstCustomersInstallmentPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("first_customers_installment_percentage");

                entity.Property(e => e.FrontPaymentMaxInstallment)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("front_payment_max_installment");

                entity.Property(e => e.FrontPaymentMaxPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("front_payment_max_percentage");

                entity.Property(e => e.FrontPaymentMinInstallment)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("front_payment_min_installment");

                entity.Property(e => e.FrontPaymentMinPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("front_payment_min_percentage");

                entity.Property(e => e.NormalCustomersDeliveryPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("normal_customers_delivery_percentage");

                entity.Property(e => e.NormalCustomersDeliveryPercentageInstallment)
                    .HasPrecision(6, 3)
                    .HasColumnName("normal_customers_delivery_percentage_installment");

                entity.Property(e => e.NormalCustomersInAdvancedPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("normal_customers_in_advanced_percentage");

                entity.Property(e => e.NormalCustomersInstallmentCreditCardPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("normal_customers_installment_credit_card_percentage");

                entity.Property(e => e.NormalCustomersInstallmentPercentage)
                    .HasPrecision(6, 3)
                    .HasColumnName("normal_customers_installment_percentage");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("plan_id");
            });

            modelBuilder.Entity<TasarrufGroup>(entity =>
            {
                entity.ToTable("tasarruf_groups");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.GroupSize)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("group_size");

                entity.Property(e => e.HowManyUsed)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("how_many_used");

                entity.Property(e => e.MaxServiceCostInstallment)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("max_service_cost_installment");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.ValidUntil)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("valid_until");
            });

            modelBuilder.Entity<TasarrufJobrouterIncidentLog>(entity =>
            {
                entity.ToTable("tasarruf_jobrouter_incident_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentNumber, "tasarruf_jobrouter_incident_logs_incident_number_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Documents)
                    .HasColumnType("text")
                    .HasColumnName("documents");

                entity.Property(e => e.IncidentNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("incident_number");

                entity.Property(e => e.ProcessTable)
                    .HasColumnType("text")
                    .HasColumnName("process_table");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.SignedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("signed_at");
            });

            modelBuilder.Entity<TasarrufLogoLog>(entity =>
            {
                entity.ToTable("tasarruf_logo_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.LogoFicheNumber)
                    .HasMaxLength(255)
                    .HasColumnName("logo_fiche_number");

                entity.Property(e => e.LogoReferenceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("logo_reference_id");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(20)
                    .HasColumnName("payment_type");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("project_id");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TasarrufPlan>(entity =>
            {
                entity.ToTable("tasarruf_plans");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ConstantRateAmount, "tasarruf_plans_constant_rate_amount_index");

                entity.HasIndex(e => e.ConstantRateCoefficient, "tasarruf_plans_constant_rate_coefficient_index");

                entity.HasIndex(e => e.DeliveryDelay, "tasarruf_plans_delivery_delay_index");

                entity.HasIndex(e => e.DeliveryIncrementReference, "tasarruf_plans_delivery_increment_reference_index");

                entity.HasIndex(e => e.DeliveryMonthConstantOrVariable, "tasarruf_plans_delivery_month_constant_or_variable_index");

                entity.HasIndex(e => e.DeliveryMonth, "tasarruf_plans_delivery_month_index");

                entity.HasIndex(e => e.DeliveryOverride, "tasarruf_plans_delivery_override_index");

                entity.HasIndex(e => e.FirstXCustomer, "tasarruf_plans_first_x_customer_index");

                entity.HasIndex(e => e.GroupSize, "tasarruf_plans_group_size_index");

                entity.HasIndex(e => e.HowManyUsed, "tasarruf_plans_how_many_used_index");

                entity.HasIndex(e => e.IncreasePeriod, "tasarruf_plans_increase_period_index");

                entity.HasIndex(e => e.IncreaseRateAfterDelivery, "tasarruf_plans_increase_rate_after_delivery_index");

                entity.HasIndex(e => e.InstallmentFeeFrontPayment, "tasarruf_plans_installment_fee_front_payment_index");

                entity.HasIndex(e => e.InstallmentFeeFrontPaymentPercentage, "tasarruf_plans_installment_fee_front_payment_percentage_index");

                entity.HasIndex(e => e.IsActive, "tasarruf_plans_is_active_index");

                entity.HasIndex(e => e.MinDeliveryMonth, "tasarruf_plans_min_delivery_month_index");

                entity.HasIndex(e => e.MonthlyGtFee, "tasarruf_plans_monthly_gt_fee_index");

                entity.HasIndex(e => e.PaymentPlan, "tasarruf_plans_payment_plan_index");

                entity.HasIndex(e => e.PeriodicIncreaseAfterDelivery, "tasarruf_plans_periodic_increase_after_delivery_index");

                entity.HasIndex(e => e.PeriodicIncreaseRate, "tasarruf_plans_periodic_increase_rate_index");

                entity.HasIndex(e => e.PeriodicIncrementReference, "tasarruf_plans_periodic_increment_reference_index");

                entity.HasIndex(e => e.PlanType, "tasarruf_plans_plan_type_index");

                entity.HasIndex(e => e.RequestedAmountReference, "tasarruf_plans_requested_amount_reference_index");

                entity.HasIndex(e => e.RequestedPercentage, "tasarruf_plans_requested_percentage_index");

                entity.HasIndex(e => e.ServiceAmountReference, "tasarruf_plans_service_amount_reference_index");

                entity.HasIndex(e => e.Title, "tasarruf_plans_title_index");

                entity.HasIndex(e => e.ValidUntil, "tasarruf_plans_valid_until_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ConstantRateAmount)
                    .HasColumnType("int(11)")
                    .HasColumnName("constant_rate_amount");

                entity.Property(e => e.ConstantRateCoefficient)
                    .HasColumnType("int(11)")
                    .HasColumnName("constant_rate_coefficient");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DeliveryDelay)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("delivery_delay")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.DeliveryIncrementReference)
                    .HasColumnType("enum('last_installment','remaining_payment','total_payment')")
                    .HasColumnName("delivery_increment_reference")
                    .HasDefaultValueSql("'last_installment'");

                entity.Property(e => e.DeliveryMonth)
                    .HasColumnType("int(11)")
                    .HasColumnName("delivery_month");

                entity.Property(e => e.DeliveryMonthConstantOrVariable)
                    .HasColumnType("enum('constant','variable')")
                    .HasColumnName("delivery_month_constant_or_variable")
                    .HasDefaultValueSql("'variable'");

                entity.Property(e => e.DeliveryOverride)
                    .HasColumnType("int(11)")
                    .HasColumnName("delivery_override")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FeeCanBeInstallment)
                    .HasColumnName("fee_can_be_installment")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FirstXCustomer)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("first_x_customer");

                entity.Property(e => e.GroupSize)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_size");

                entity.Property(e => e.HowManyUsed)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("how_many_used")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncreasePeriod)
                    .HasColumnType("enum('monthly','for_3_months','for_6_months','yearly')")
                    .HasColumnName("increase_period");

                entity.Property(e => e.IncreaseRateAfterDelivery)
                    .HasPrecision(10, 7)
                    .HasColumnName("increase_rate_after_delivery");

                entity.Property(e => e.InstallmentFeeFrontPayment)
                    .HasColumnName("installment_fee_front_payment")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.InstallmentFeeFrontPaymentPercentage)
                    .HasPrecision(8, 2)
                    .HasColumnName("installment_fee_front_payment_percentage")
                    .HasDefaultValueSql("'1.00'");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.MinDeliveryMonth)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_delivery_month");

                entity.Property(e => e.MonthlyGtFee)
                    .HasColumnName("monthly_gt_fee")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PaymentPlan)
                    .HasColumnType("enum('constant','delivery_increased','delivery_periodic_increment','periodic_increment')")
                    .HasColumnName("payment_plan");

                entity.Property(e => e.PercentageOfWithoutCampaignServiceAmount)
                    .HasPrecision(6, 3)
                    .HasColumnName("percentage_of_without_campaign_service_amount");

                entity.Property(e => e.PeriodicIncreaseAfterDelivery).HasColumnName("periodic_increase_after_delivery");

                entity.Property(e => e.PeriodicIncreaseRate)
                    .HasPrecision(10, 7)
                    .HasColumnName("periodic_increase_rate");

                entity.Property(e => e.PeriodicIncrementReference)
                    .HasColumnType("enum('last_installment','remaining_payment','total_payment')")
                    .HasColumnName("periodic_increment_reference");

                entity.Property(e => e.PlanType)
                    .HasColumnType("enum('group','individual','constant_rate')")
                    .HasColumnName("plan_type");

                entity.Property(e => e.RequestedAmountReference)
                    .HasColumnType("enum('total_payment','remaining_payment')")
                    .HasColumnName("requested_amount_reference");

                entity.Property(e => e.RequestedPercentage)
                    .HasPrecision(10, 7)
                    .HasColumnName("requested_percentage");

                entity.Property(e => e.ServiceAmountReference)
                    .HasColumnType("enum('total_payment','remaining_payment')")
                    .HasColumnName("service_amount_reference");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.ValidUntil)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("valid_until");

                entity.Property(e => e.XPercentageFeeOnly)
                    .HasPrecision(8, 2)
                    .HasColumnName("x_percentage_fee_only")
                    .HasDefaultValueSql("'18.00'");
            });

            modelBuilder.Entity<TasarrufPlanGroup>(entity =>
            {
                entity.ToTable("tasarruf_plan_groups");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(255)
                    .HasColumnName("group_id");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("plan_id");
            });

            modelBuilder.Entity<TelewebBreakOption>(entity =>
            {
                entity.ToTable("teleweb_break_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .HasColumnName("color");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsBreakReqeustRequired).HasColumnName("is_break_reqeust_required");

                entity.Property(e => e.IsWorking)
                    .HasColumnName("is_working")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TelewebBreakRequest>(entity =>
            {
                entity.ToTable("teleweb_break_requests");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BreakTimes)
                    .HasMaxLength(255)
                    .HasColumnName("break_times");

                entity.Property(e => e.ClosedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("closed_at");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.ManagerUserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("manager_user_id");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.RequestText)
                    .HasColumnType("text")
                    .HasColumnName("request_text");

                entity.Property(e => e.ResponseText)
                    .HasColumnType("text")
                    .HasColumnName("response_text");

                entity.Property(e => e.SelectedBreakOption)
                    .HasMaxLength(255)
                    .HasColumnName("selected_break_option");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.TelewebQueue)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("teleweb_queue");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<TelewebCallAction>(entity =>
            {
                entity.ToTable("teleweb_call_actions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .HasColumnName("action");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.End)
                    .HasColumnType("decimal(8,3) unsigned")
                    .HasColumnName("end");

                entity.Property(e => e.Start)
                    .HasColumnType("decimal(8,3) unsigned")
                    .HasColumnName("start");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<TelewebChannelJoinLog>(entity =>
            {
                entity.ToTable("teleweb_channel_join_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Extension)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("extension");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("phone_number");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('spy','whisper','join')")
                    .HasColumnName("type");

                entity.Property(e => e.Uid)
                    .HasMaxLength(32)
                    .HasColumnName("uid");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<TelewebDoCallLog>(entity =>
            {
                entity.ToTable("teleweb_do_call_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CallId)
                    .HasMaxLength(100)
                    .HasColumnName("call_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Extension)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("extension");

                entity.Property(e => e.ReceivedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("received_at");

                entity.Property(e => e.Target)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target");

                entity.Property(e => e.Uid)
                    .HasMaxLength(100)
                    .HasColumnName("uid");
            });

            modelBuilder.Entity<TelewebInternalLog>(entity =>
            {
                entity.ToTable("teleweb_internal_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CreatedAt, "teleweb_internal_logs_created_at_index");

                entity.HasIndex(e => e.UserId, "teleweb_internal_logs_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Log)
                    .HasColumnType("text")
                    .HasColumnName("log");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<TelewebQueueStatusLog>(entity =>
            {
                entity.ToTable("teleweb_queue_status_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Extension, "teleweb_queue_status_logs_extension_index");

                entity.HasIndex(e => e.Queue, "teleweb_queue_status_logs_queue_index");

                entity.HasIndex(e => e.Status, "teleweb_queue_status_logs_status_index");

                entity.HasIndex(e => e.UserId, "teleweb_queue_status_logs_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Extension)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("extension");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.Queue)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("queue");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<TimeCondition>(entity =>
            {
                entity.ToTable("time_conditions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.TimeConditionGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("time_condition_group_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TimeConditionGroup>(entity =>
            {
                entity.ToTable("time_condition_groups");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.MesaiDisiAnons)
                    .HasMaxLength(500)
                    .HasColumnName("mesai_disi_anons");

                entity.Property(e => e.MesaiIciAnons)
                    .HasMaxLength(500)
                    .HasColumnName("mesai_ici_anons");

                entity.Property(e => e.Title)
                    .HasMaxLength(60)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TiskiIndIncidentLog>(entity =>
            {
                entity.ToTable("tiski_ind_incident_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Request)
                    .HasColumnType("mediumtext")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");
            });

            modelBuilder.Entity<TweetLog>(entity =>
            {
                entity.ToTable("tweet_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.CustomsIncidentRelationId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customs_incident_relation_id");

                entity.Property(e => e.CustomsMessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_message_id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.RemoteUserId)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_id");

                entity.Property(e => e.RemoteUserName)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_name");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");
            });

            modelBuilder.Entity<TwitterDmLog>(entity =>
            {
                entity.ToTable("twitter_dm_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.CustomsIncidentRelationId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customs_incident_relation_id");

                entity.Property(e => e.CustomsMessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_message_id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.RemoteUserId)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_id");

                entity.Property(e => e.RemoteUserName)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_name");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");
            });

            modelBuilder.Entity<TwitterImageOption>(entity =>
            {
                entity.ToTable("twitter_image_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CustomsAccountsId, "twitter_image_options_customs_accounts_id_index");

                entity.HasIndex(e => e.IncidentSourceId, "twitter_image_options_incident_source_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CharacterCount)
                    .HasMaxLength(10)
                    .HasColumnName("character_count")
                    .HasDefaultValueSql("'500'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomsAccountsId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_accounts_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.FontSize)
                    .HasMaxLength(10)
                    .HasColumnName("font_size")
                    .HasDefaultValueSql("'24'");

                entity.Property(e => e.Image)
                    .HasColumnType("text")
                    .HasColumnName("image");

                entity.Property(e => e.ImageCordinates)
                    .HasColumnType("text")
                    .HasColumnName("image_cordinates");

                entity.Property(e => e.IncidentSourceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_source_id");

                entity.Property(e => e.IncidentTopicIds)
                    .HasColumnType("text")
                    .HasColumnName("incident_topic_ids");

                entity.Property(e => e.LineMaxCharacterCount)
                    .HasMaxLength(10)
                    .HasColumnName("line_max_character_count")
                    .HasDefaultValueSql("'75'");

                entity.Property(e => e.PageCountCordinates)
                    .HasColumnType("text")
                    .HasColumnName("page_count_cordinates");

                entity.Property(e => e.PageCountFontSize)
                    .HasMaxLength(10)
                    .HasColumnName("page_count_font_size")
                    .HasDefaultValueSql("'24'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TwitterUserInfo>(entity =>
            {
                entity.ToTable("twitter_user_infos");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(161)
                    .HasColumnName("description");

                entity.Property(e => e.Followed)
                    .HasColumnType("int(11)")
                    .HasColumnName("followed");

                entity.Property(e => e.Follower)
                    .HasColumnType("int(11)")
                    .HasColumnName("follower");

                entity.Property(e => e.Location)
                    .HasMaxLength(31)
                    .HasColumnName("location");

                entity.Property(e => e.NumberOfTweets)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_tweets");

                entity.Property(e => e.ProfilePic)
                    .HasMaxLength(255)
                    .HasColumnName("profile_pic");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.Verified).HasColumnName("verified");
            });

            modelBuilder.Entity<UlakbelIncident>(entity =>
            {
                entity.ToTable("ulakbel_incidents");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.RemoteId, "mavi_masa_incidents_remote_id_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedIncidentNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_incident_number");

                entity.Property(e => e.Data)
                    .HasColumnType("mediumtext")
                    .HasColumnName("data");

                entity.Property(e => e.Files)
                    .HasColumnType("text")
                    .HasColumnName("files");

                entity.Property(e => e.ImportedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("imported_at");

                entity.Property(e => e.IncidentSourceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_source_id");

                entity.Property(e => e.IsCompleted).HasColumnName("is_completed");

                entity.Property(e => e.RemoteId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("remote_id");

                entity.Property(e => e.RemoteNumber)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("remote_number");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('MAVIMASA','ZABITA')")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<UlakbelIncidentLog>(entity =>
            {
                entity.ToTable("ulakbel_incident_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnType("enum('create','transfer','return','reopen','forward','approve','approval_reject','process','comment','internal_return','complete','delete','spam','upload','ask')")
                    .HasColumnName("action");

                entity.Property(e => e.CompletionType)
                    .HasMaxLength(255)
                    .HasColumnName("completion_type");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.IsCompleted).HasColumnName("is_completed");

                entity.Property(e => e.PerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("performed_at");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.UlakbelIncidentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ulakbel_incident_id");
            });

            modelBuilder.Entity<UlakfonNotificationLog>(entity =>
            {
                entity.ToTable("ulakfon_notification_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Caller)
                    .HasMaxLength(255)
                    .HasColumnName("caller");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(255)
                    .HasColumnName("caller_id");

                entity.Property(e => e.CallerName)
                    .HasMaxLength(255)
                    .HasColumnName("caller_name");

                entity.Property(e => e.CreatedAt)
                    .HasMaxLength(255)
                    .HasColumnName("created_at");

                entity.Property(e => e.ReceivedAt)
                    .HasMaxLength(255)
                    .HasColumnName("received_at");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.Property(e => e.Target)
                    .HasMaxLength(255)
                    .HasColumnName("target");

                entity.Property(e => e.TargetUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_user_id");
            });

            modelBuilder.Entity<UniversalIncidentLog>(entity =>
            {
                entity.ToTable("universal_incident_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.IsCompleted)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_completed");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Result)
                    .HasColumnType("text")
                    .HasColumnName("result");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Active, "active_index");

                entity.HasIndex(e => e.DepartmentId, "department_id_index");

                entity.HasIndex(e => e.MobilePhone, "mobile_phone_index");

                entity.HasIndex(e => e.ActiveDirectoryUsername, "users_active_directory_username_unique")
                    .IsUnique();

                entity.HasIndex(e => e.ApiToken, "users_api_token_unique")
                    .IsUnique();

                entity.HasIndex(e => e.TotpSecretKey, "users_authenticator_secret_key_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "users_email_unique")
                    .IsUnique();

                entity.HasIndex(e => e.InterPhone, "users_inter_phone_index");

                entity.HasIndex(e => e.IsGroup, "users_is_group_index");

                entity.HasIndex(e => e.LastLoginTime, "users_last_login_time_index");

                entity.HasIndex(e => e.LastRequestTime, "users_last_request_time_index");

                entity.HasIndex(e => e.TelewebExtension, "users_teleweb_extension_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ActiveDirectoryUsername).HasColumnName("active_directory_username");

                entity.Property(e => e.ApiToken)
                    .HasMaxLength(60)
                    .HasColumnName("api_token");

                entity.Property(e => e.CallCenterSynonyms)
                    .HasColumnType("text")
                    .HasColumnName("call_center_synonyms");

                entity.Property(e => e.ColorBackground)
                    .HasMaxLength(6)
                    .HasColumnName("color_background")
                    .HasDefaultValueSql("'4c5a66'");

                entity.Property(e => e.ColorForeground)
                    .HasMaxLength(6)
                    .HasColumnName("color_foreground")
                    .HasDefaultValueSql("'e8c869'");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.DefaultIncidentTableId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("default_incident_table_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FontSize)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("font_size")
                    .HasDefaultValueSql("'14'");

                entity.Property(e => e.GetNotificationsViaEmail)
                    .IsRequired()
                    .HasColumnName("get_notifications_via_email")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GetNotificationsViaMobileApp)
                    .IsRequired()
                    .HasColumnName("get_notifications_via_mobile_app")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GetNotificationsViaSms)
                    .IsRequired()
                    .HasColumnName("get_notifications_via_sms")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdentificationNumber)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("identification_number");

                entity.Property(e => e.IncludeInPhoneBook).HasColumnName("include_in_phone_book");

                entity.Property(e => e.InterPhone)
                    .HasMaxLength(20)
                    .HasColumnName("inter_phone");

                entity.Property(e => e.IosToken)
                    .HasMaxLength(255)
                    .HasColumnName("ios_token");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.IsPasswordChangeRequired).HasColumnName("is_password_change_required");

                entity.Property(e => e.IsSuperAdmin).HasColumnName("is_super_admin");

                entity.Property(e => e.JanusHandleId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("janus_handle_id");

                entity.Property(e => e.JanusSessionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("janus_session_id");

                entity.Property(e => e.LastLoginTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("last_login_time");

                entity.Property(e => e.LastRequestTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("last_request_time");

                entity.Property(e => e.LoginFromAllowedIps).HasColumnName("login_from_allowed_ips");

                entity.Property(e => e.MobilePhone)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(255)
                    .HasColumnName("nickname");

                entity.Property(e => e.OnLeave).HasColumnName("on_leave");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.ProfilePicture)
                    .HasMaxLength(255)
                    .HasColumnName("profile_picture");

                entity.Property(e => e.RememberToken)
                    .HasMaxLength(100)
                    .HasColumnName("remember_token");

                entity.Property(e => e.RowsPerPage)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rows_per_page")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.ShowSearchBar).HasColumnName("show_search_bar");

                entity.Property(e => e.TelewebExtension)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("teleweb_extension");

                entity.Property(e => e.TelewebPenalty)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("teleweb_penalty");

                entity.Property(e => e.TotpSecretKey)
                    .HasMaxLength(64)
                    .HasColumnName("totp_secret_key");

                entity.Property(e => e.TotpSecretKeyVerifiedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("totp_secret_key_verified_at");

                entity.Property(e => e.UserRoleId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_role_id");

                entity.Property(e => e.UserTitleId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_title_id");
            });

            modelBuilder.Entity<UserApiToken>(entity =>
            {
                entity.ToTable("user_api_tokens");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ApiToken, "user_api_tokens_api_token_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ApiToken).HasColumnName("api_token");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("expires_at");

                entity.Property(e => e.RegisteredIp)
                    .HasMaxLength(255)
                    .HasColumnName("registered_ip");

                entity.Property(e => e.RegisteredUserAgent)
                    .HasMaxLength(255)
                    .HasColumnName("registered_user_agent");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserFastAnswer>(entity =>
            {
                entity.ToTable("user_fast_answers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.UserId, "fastanswer_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserFaxInbox>(entity =>
            {
                entity.ToTable("user_fax_inbox");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.FaxInboxId, "user_fax_inbox_fax_inbox_id_index");

                entity.HasIndex(e => e.UserId, "user_fax_inbox_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.FaxInboxId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("fax_inbox_id");

                entity.Property(e => e.ReadAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("read_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserFcmToken>(entity =>
            {
                entity.ToTable("user_fcm_tokens");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.UserId, e.Token }, "user_fcm_tokens_user_id_token_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DeviceInfo)
                    .HasColumnType("text")
                    .HasColumnName("device_info");

                entity.Property(e => e.IsUlakfon).HasColumnName("is_ulakfon");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.TokenSource)
                    .HasMaxLength(255)
                    .HasColumnName("token_source")
                    .HasDefaultValueSql("'ulakbel'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserFeedback>(entity =>
            {
                entity.ToTable("user_feedbacks");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.UserId, "feedback_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.ToTable("user_groups");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("department_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserGroupRelation>(entity =>
            {
                entity.ToTable("user_group_relations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.GroupId, "usergrouprelations_group_id_index");

                entity.HasIndex(e => e.UserId, "usergrouprelations_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("group_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserImportLog>(entity =>
            {
                entity.ToTable("user_import_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('pending','complete','fail','started')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'pending'");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserOption>(entity =>
            {
                entity.ToTable("user_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Key, "user_options_key_index");

                entity.HasIndex(e => e.UserId, "user_options_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.ToTable("user_permissions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.UserId, "auth_user_id_index");

                entity.HasIndex(e => e.UserRoleId, "auth_user_role_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .HasColumnName("action");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Permission).HasColumnName("permission");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserRoleId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_role_id");
            });

            modelBuilder.Entity<UserRRMemory>(entity =>
            {
                entity.ToTable("user_r_r_memories");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.LastUserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("last_user_id");

                entity.Property(e => e.Process)
                    .HasMaxLength(150)
                    .HasColumnName("process");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("user_roles");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .HasColumnName("icon")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<UserSmsCode>(entity =>
            {
                entity.ToTable("user_sms_codes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.UserId, "user_sms_codes_user_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("code");

                entity.Property(e => e.SendAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("send_at");

                entity.Property(e => e.SmsResponse)
                    .HasMaxLength(255)
                    .HasColumnName("sms_response");

                entity.Property(e => e.Used).HasColumnName("used");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UserTitle>(entity =>
            {
                entity.ToTable("user_titles");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<VideoCallOperatorStatus>(entity =>
            {
                entity.ToTable("video_call_operator_statuses");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.RegisterName)
                    .HasMaxLength(255)
                    .HasColumnName("register_name");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<WebForm>(entity =>
            {
                entity.ToTable("web_forms");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentSourceId, "web_forms_incident_source_id_index");

                entity.HasIndex(e => e.PublicUrl, "web_forms_public_url_unique")
                    .IsUnique();

                entity.HasIndex(e => e.SendNotificationToIncidentUser, "web_forms_send_notification_to_incident_user_index");

                entity.HasIndex(e => e.SmsVerification, "web_forms_sms_verification_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AllowAnonymous).HasColumnName("allow_anonymous");

                entity.Property(e => e.CaptchaRequired)
                    .IsRequired()
                    .HasColumnName("captcha_required")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator_user_id");

                entity.Property(e => e.CustomFields)
                    .HasColumnType("text")
                    .HasColumnName("custom_fields");

                entity.Property(e => e.DefaultFields)
                    .HasColumnType("text")
                    .HasColumnName("default_fields");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Fields)
                    .HasColumnType("text")
                    .HasColumnName("fields");

                entity.Property(e => e.FloodProtectMinutes)
                    .HasColumnType("int(11)")
                    .HasColumnName("flood_protect_minutes");

                entity.Property(e => e.IncidentActionInfo)
                    .HasColumnType("text")
                    .HasColumnName("incident_action_info");

                entity.Property(e => e.IncidentSourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("incident_source_id");

                entity.Property(e => e.IsIncludedInReports).HasColumnName("is_included_in_reports");

                entity.Property(e => e.Options)
                    .HasColumnType("text")
                    .HasColumnName("options");

                entity.Property(e => e.PublicUrl).HasColumnName("public_url");

                entity.Property(e => e.SendNotificationToIncidentUser).HasColumnName("send_notification_to_incident_user");

                entity.Property(e => e.SmsVerification)
                    .HasColumnName("sms_verification")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.VerifyNames).HasColumnName("verify_names");
            });

            modelBuilder.Entity<WebFormCustomField>(entity =>
            {
                entity.ToTable("web_form_custom_fields");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Key)
                    .HasMaxLength(50)
                    .HasColumnName("key");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<WebFormCustomFieldOption>(entity =>
            {
                entity.ToTable("web_form_custom_field_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Key)
                    .HasMaxLength(50)
                    .HasColumnName("key");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.Property(e => e.WebFormCustomFieldId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("web_form_custom_field_id");
            });

            modelBuilder.Entity<WebFormCustomTable>(entity =>
            {
                entity.ToTable("web_form_custom_tables");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Source, "web_form_custom_tables_source_index");

                entity.HasIndex(e => new { e.Source, e.Key }, "web_form_custom_tables_source_key_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Key)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("key");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<WebFormFlowChart>(entity =>
            {
                entity.ToTable("web_form_flow_charts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<WebFormObject>(entity =>
            {
                entity.ToTable("web_form_objects");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedStepDepartmentIds)
                    .HasColumnType("text")
                    .HasColumnName("completed_step_department_ids");

                entity.Property(e => e.CompletedStepTopicIds)
                    .HasColumnType("text")
                    .HasColumnName("completed_step_topic_ids");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Fields)
                    .HasColumnType("text")
                    .HasColumnName("fields");

                entity.Property(e => e.ObjectType)
                    .HasColumnType("enum('form','user')")
                    .HasColumnName("object_type");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.TitleField)
                    .HasMaxLength(255)
                    .HasColumnName("title_field");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<WebFormObjectElement>(entity =>
            {
                entity.ToTable("web_form_object_elements");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.Custom)
                    .HasColumnType("text")
                    .HasColumnName("custom");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.LastStates)
                    .HasColumnType("text")
                    .HasColumnName("last_states");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("object_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<WhatsappLog>(entity =>
            {
                entity.ToTable("whatsapp_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Attachments)
                    .HasColumnType("text")
                    .HasColumnName("attachments");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomsAccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_account_id");

                entity.Property(e => e.CustomsIncidentRelationId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("customs_incident_relation_id");

                entity.Property(e => e.CustomsMessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customs_message_id");

                entity.Property(e => e.IncidentActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_action_id");

                entity.Property(e => e.LastPerformedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("last_performed_at");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.RemoteUserName)
                    .HasMaxLength(255)
                    .HasColumnName("remote_user_name");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.RetryCount)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("retry_count")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WhatsappPing>(entity =>
            {
                entity.ToTable("whatsapp_pings");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.FeedbackSent, "whatsapp_pings_feedback_sent_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.FeedbackSent).HasColumnName("feedback_sent");

                entity.Property(e => e.PingId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ping_id");

                entity.Property(e => e.PingReceivedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ping_received_at");

                entity.Property(e => e.PingSendAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ping_send_at");

                entity.Property(e => e.PingTarget)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ping_target");

                entity.Property(e => e.PongReceivedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("pong_received_at");

                entity.Property(e => e.PongSendAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("pong_send_at");
            });

            modelBuilder.Entity<WhereCustomerHear>(entity =>
            {
                entity.ToTable("where_customer_hears");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<WorkFlow>(entity =>
            {
                entity.ToTable("work_flows");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Priority, "work_flow_priority");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ApprovalPriority)
                    .HasColumnType("enum('two_upper_parent_department_responsible_must_approve','parent_department_responsible_must_approve','department_responsible_must_approve','multiple_intermediate_must_approve')")
                    .HasColumnName("approval_priority");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Departments)
                    .HasColumnType("text")
                    .HasColumnName("departments");

                entity.Property(e => e.IncidentAction)
                    .HasMaxLength(255)
                    .HasColumnName("incident_action");

                entity.Property(e => e.IncidentSourceIds)
                    .HasColumnType("text")
                    .HasColumnName("incident_source_ids");

                entity.Property(e => e.MultipleApproveTargets)
                    .HasColumnType("text")
                    .HasColumnName("multiple_approve_targets");

                entity.Property(e => e.Options)
                    .HasMaxLength(1000)
                    .HasColumnName("options")
                    .HasDefaultValueSql("'{\"target_department_id\":0}'");

                entity.Property(e => e.Priority)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.Receiver)
                    .HasColumnType("text")
                    .HasColumnName("receiver");

                entity.Property(e => e.Sender)
                    .HasColumnType("text")
                    .HasColumnName("sender");

                entity.Property(e => e.Target)
                    .HasColumnType("int(11)")
                    .HasColumnName("target");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.WhatToDo)
                    .HasMaxLength(255)
                    .HasColumnName("what_to_do");
            });

            modelBuilder.Entity<YoncaLog>(entity =>
            {
                entity.ToTable("yonca_logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IncidentId, "yonca_logs_incident_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("completed_at");

                entity.Property(e => e.IncidentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incident_id");

                entity.Property(e => e.Request)
                    .HasColumnType("text")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
