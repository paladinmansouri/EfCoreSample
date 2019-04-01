using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class ReservationContext : DbContext
    {
        public ReservationContext()
        {
        }

        public ReservationContext(DbContextOptions<ReservationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BankLocalize> BankLocalize { get; set; }
        public virtual DbSet<BankMessage> BankMessage { get; set; }
        public virtual DbSet<BankMessageLocalize> BankMessageLocalize { get; set; }
        public virtual DbSet<BreadCrumb> BreadCrumb { get; set; }
        public virtual DbSet<BreadCrumbLocalize> BreadCrumbLocalize { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<ContactTypeLocalize> ContactTypeLocalize { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DefaultText> DefaultText { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<DoctorContact> DoctorContact { get; set; }
        public virtual DbSet<DoctorDefaultText> DoctorDefaultText { get; set; }
        public virtual DbSet<DoctorExpertise> DoctorExpertise { get; set; }
        public virtual DbSet<DoctorFile> DoctorFile { get; set; }
        public virtual DbSet<DoctorSubPlace> DoctorSubPlace { get; set; }
        public virtual DbSet<EvaluationCriteria> EvaluationCriteria { get; set; }
        public virtual DbSet<EvaluationCriteriaLocalize> EvaluationCriteriaLocalize { get; set; }
        public virtual DbSet<Expertise> Expertise { get; set; }
        public virtual DbSet<ExpertiseLevel> ExpertiseLevel { get; set; }
        public virtual DbSet<ExpertiseLevelLocalize> ExpertiseLevelLocalize { get; set; }
        public virtual DbSet<ExpertiseLocalize> ExpertiseLocalize { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<FaqCategory> FaqCategory { get; set; }
        public virtual DbSet<FaqCategoryLocalize> FaqCategoryLocalize { get; set; }
        public virtual DbSet<FaqLocalize> FaqLocalize { get; set; }
        public virtual DbSet<FinancialDocument> FinancialDocument { get; set; }
        public virtual DbSet<FormMessage> FormMessage { get; set; }
        public virtual DbSet<FormMessageLocalize> FormMessageLocalize { get; set; }
        public virtual DbSet<Gateway> Gateway { get; set; }
        public virtual DbSet<GatewayParam> GatewayParam { get; set; }
        public virtual DbSet<GeneralContent> GeneralContent { get; set; }
        public virtual DbSet<GeneralContentLocalize> GeneralContentLocalize { get; set; }
        public virtual DbSet<GeneralContentType> GeneralContentType { get; set; }
        public virtual DbSet<GeneralContentTypeLocalize> GeneralContentTypeLocalize { get; set; }
        public virtual DbSet<HashTag> HashTag { get; set; }
        public virtual DbSet<HealthService> HealthService { get; set; }
        public virtual DbSet<HealthServiceLocalize> HealthServiceLocalize { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<InsuranceLocalize> InsuranceLocalize { get; set; }
        public virtual DbSet<Investor> Investor { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LegalContract> LegalContract { get; set; }
        public virtual DbSet<MedicalMedicine> MedicalMedicine { get; set; }
        public virtual DbSet<MedicalRecodeAdvice> MedicalRecodeAdvice { get; set; }
        public virtual DbSet<MedicalRecodeReserveSharing> MedicalRecodeReserveSharing { get; set; }
        public virtual DbSet<MedicalRecodeSharing> MedicalRecodeSharing { get; set; }
        public virtual DbSet<MedicalRecord> MedicalRecord { get; set; }
        public virtual DbSet<MedicalRecordFile> MedicalRecordFile { get; set; }
        public virtual DbSet<MedicalRecordReserveAdvice> MedicalRecordReserveAdvice { get; set; }
        public virtual DbSet<MedicalRecordSicknessTag> MedicalRecordSicknessTag { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsCategory> NewsCategory { get; set; }
        public virtual DbSet<NewsCategoryLocalize> NewsCategoryLocalize { get; set; }
        public virtual DbSet<NewsHashTag> NewsHashTag { get; set; }
        public virtual DbSet<NewsLocalize> NewsLocalize { get; set; }
        public virtual DbSet<NewsTag> NewsTag { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientDoctorEvaluation> PatientDoctorEvaluation { get; set; }
        public virtual DbSet<PatientDoctorEvaluationCriteria> PatientDoctorEvaluationCriteria { get; set; }
        public virtual DbSet<PatientPlaceEvaluation> PatientPlaceEvaluation { get; set; }
        public virtual DbSet<PatientPlaceEvaluationCriteria> PatientPlaceEvaluationCriteria { get; set; }
        public virtual DbSet<PatientSecretaryEvaluation> PatientSecretaryEvaluation { get; set; }
        public virtual DbSet<PatientSecretaryEvaluationCriteria> PatientSecretaryEvaluationCriteria { get; set; }
        public virtual DbSet<PatientWallet> PatientWallet { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionLocalize> PermissionLocalize { get; set; }
        public virtual DbSet<PersonalHoliday> PersonalHoliday { get; set; }
        public virtual DbSet<PersonContract> PersonContract { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<PlaceContact> PlaceContact { get; set; }
        public virtual DbSet<PlaceFile> PlaceFile { get; set; }
        public virtual DbSet<PlaceHealthService> PlaceHealthService { get; set; }
        public virtual DbSet<PlaceInsurance> PlaceInsurance { get; set; }
        public virtual DbSet<PlaceLocalize> PlaceLocalize { get; set; }
        public virtual DbSet<PlaceOwnership> PlaceOwnership { get; set; }
        public virtual DbSet<PlaceOwnershipLocalize> PlaceOwnershipLocalize { get; set; }
        public virtual DbSet<PlaceType> PlaceType { get; set; }
        public virtual DbSet<PlaceTypeLocalize> PlaceTypeLocalize { get; set; }
        public virtual DbSet<ProfitLetterGroup> ProfitLetterGroup { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<ReschedulingReserve> ReschedulingReserve { get; set; }
        public virtual DbSet<Reserve> Reserve { get; set; }
        public virtual DbSet<ReserveHistory> ReserveHistory { get; set; }
        public virtual DbSet<ReserveState> ReserveState { get; set; }
        public virtual DbSet<ReserveStateHistory> ReserveStateHistory { get; set; }
        public virtual DbSet<Secretary> Secretary { get; set; }
        public virtual DbSet<SecretarySubPlace> SecretarySubPlace { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<SexLocalize> SexLocalize { get; set; }
        public virtual DbSet<Shareholder> Shareholder { get; set; }
        public virtual DbSet<ShiftWork> ShiftWork { get; set; }
        public virtual DbSet<ShiftWorkType> ShiftWorkType { get; set; }
        public virtual DbSet<SicknessTag> SicknessTag { get; set; }
        public virtual DbSet<SubPlace> SubPlace { get; set; }
        public virtual DbSet<SubPlaceContact> SubPlaceContact { get; set; }
        public virtual DbSet<SubPlaceFile> SubPlaceFile { get; set; }
        public virtual DbSet<SubPlaceHealthService> SubPlaceHealthService { get; set; }
        public virtual DbSet<SubPlaceLocalize> SubPlaceLocalize { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<UiPage> UiPage { get; set; }
        public virtual DbSet<UiPageLocalize> UiPageLocalize { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAddress> UserAddress { get; set; }
        public virtual DbSet<UserBankCard> UserBankCard { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<UserGroupLocalize> UserGroupLocalize { get; set; }
        public virtual DbSet<UserGroupPermission> UserGroupPermission { get; set; }
        public virtual DbSet<UserPermission> UserPermission { get; set; }
        public virtual DbSet<Visitor> Visitor { get; set; }
        public virtual DbSet<WalletFinancialTransaction> WalletFinancialTransaction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Reservation;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank", "Payment");

                entity.HasIndex(e => e.GatewayId)
                    .HasName("IX_GatewayId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Gateway)
                    .WithMany(p => p.Bank)
                    .HasForeignKey(d => d.GatewayId)
                    .HasConstraintName("FK_Payment.Bank_Payment.Gateway_GatewayId");
            });

            modelBuilder.Entity<BankLocalize>(entity =>
            {
                entity.ToTable("BankLocalize", "Payment");

                entity.HasIndex(e => e.BankId)
                    .HasName("IX_BankId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankLocalize)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment.BankLocalize_Payment.Bank_BankId");
            });

            modelBuilder.Entity<BankMessage>(entity =>
            {
                entity.ToTable("BankMessage", "Payment");

                entity.HasIndex(e => e.BankId)
                    .HasName("IX_BankId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankMessage)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_Payment.BankMessage_Payment.Bank_BankId");
            });

            modelBuilder.Entity<BankMessageLocalize>(entity =>
            {
                entity.ToTable("BankMessageLocalize", "Payment");

                entity.HasIndex(e => e.BankMessageId)
                    .HasName("IX_BankMessageId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BankMessage)
                    .WithMany(p => p.BankMessageLocalize)
                    .HasForeignKey(d => d.BankMessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment.BankMessageLocalize_Payment.BankMessage_BankMessageId");
            });

            modelBuilder.Entity<BreadCrumb>(entity =>
            {
                entity.ToTable("BreadCrumb", "Common");

                entity.HasIndex(e => e.UiPageId)
                    .HasName("IX_UiPageId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.UiPage)
                    .WithMany(p => p.BreadCrumb)
                    .HasForeignKey(d => d.UiPageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.BreadCrumb_Main.UiPage_UiPageId");
            });

            modelBuilder.Entity<BreadCrumbLocalize>(entity =>
            {
                entity.ToTable("BreadCrumbLocalize", "Common");

                entity.HasIndex(e => e.BreadCrumbId)
                    .HasName("IX_BreadCrumbId");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("IX_LanguageId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.BreadCrumb)
                    .WithMany(p => p.BreadCrumbLocalize)
                    .HasForeignKey(d => d.BreadCrumbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.BreadCrumbLocalize_Main.BreadCrumb_BreadCrumbId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.BreadCrumbLocalize)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.BreadCrumbLocalize_Main.Language_LanguageId");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.ToTable("Calendar", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.GregorianDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersianDate)
                    .IsRequired()
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City", "UserManagement");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("IX_ProvinceId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.City_UserManagement.Province_ProvinceId");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.ToTable("ContactType", "Site");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContactTypeLocalize>(entity =>
            {
                entity.ToTable("ContactTypeLocalize", "Site");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.ContactTypeLocalize)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactTypeLocalize_ContactType");
            });

            modelBuilder.Entity<ContactUs>(entity =>
            {
                entity.ToTable("ContactUs", "Site");

                entity.Property(e => e.Answer).HasMaxLength(800);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(800);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.TrackingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "UserManagement");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<DefaultText>(entity =>
            {
                entity.ToTable("DefaultText", "Common");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Doctor", "Person");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.MedicalSystemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Doctor)
                    .HasForeignKey<Doctor>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_User");
            });

            modelBuilder.Entity<DoctorContact>(entity =>
            {
                entity.ToTable("DoctorContact", "Person");

                entity.Property(e => e.ContectValue)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.DoctorContact)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorContact_ContactType");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorContact)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorContact_Doctor");
            });

            modelBuilder.Entity<DoctorDefaultText>(entity =>
            {
                entity.ToTable("DoctorDefaultText", "Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorDefaultText)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorDefaultText_Doctor");
            });

            modelBuilder.Entity<DoctorExpertise>(entity =>
            {
                entity.ToTable("DoctorExpertise", "Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorExpertise)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorExpertise_Doctor");

                entity.HasOne(d => d.Expertise)
                    .WithMany(p => p.DoctorExpertise)
                    .HasForeignKey(d => d.ExpertiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorExpertise_Expertise");

                entity.HasOne(d => d.ExpertiseNavigation)
                    .WithMany(p => p.DoctorExpertise)
                    .HasForeignKey(d => d.ExpertiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorExpertise_ExpertiseLevel");
            });

            modelBuilder.Entity<DoctorFile>(entity =>
            {
                entity.ToTable("DoctorFile", "Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorFile)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorFile_Doctor");
            });

            modelBuilder.Entity<DoctorSubPlace>(entity =>
            {
                entity.ToTable("DoctorSubPlace", "Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PercentageReserve).HasColumnType("decimal(2, 2)");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorSubPlace)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalDoctor_Doctor");

                entity.HasOne(d => d.SubPlaceHealthService)
                    .WithMany(p => p.DoctorSubPlace)
                    .HasForeignKey(d => d.SubPlaceHealthServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorSubPlace_SubPlaceHealthService");

                entity.HasOne(d => d.SubPlace)
                    .WithMany(p => p.DoctorSubPlace)
                    .HasForeignKey(d => d.SubPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorSubPlace_SubPlace");
            });

            modelBuilder.Entity<EvaluationCriteria>(entity =>
            {
                entity.ToTable("EvaluationCriteria", "Evaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EvaluationCriteriaLocalize>(entity =>
            {
                entity.ToTable("EvaluationCriteriaLocalize", "Evaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.EvaluationCriteria)
                    .WithMany(p => p.EvaluationCriteriaLocalize)
                    .HasForeignKey(d => d.EvaluationCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvaluationCriteriaLocalize_EvaluationCriteria");
            });

            modelBuilder.Entity<Expertise>(entity =>
            {
                entity.ToTable("Expertise", "Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Parrent)
                    .WithMany(p => p.InverseParrent)
                    .HasForeignKey(d => d.ParrentId)
                    .HasConstraintName("FK_Expertise_Expertise");
            });

            modelBuilder.Entity<ExpertiseLevel>(entity =>
            {
                entity.ToTable("ExpertiseLevel", "Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExpertiseLevelLocalize>(entity =>
            {
                entity.ToTable("ExpertiseLevelLocalize", "Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Expertise)
                    .WithMany(p => p.ExpertiseLevelLocalize)
                    .HasForeignKey(d => d.ExpertiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpertiseLevelLocalize_ExpertiseLevel");
            });

            modelBuilder.Entity<ExpertiseLocalize>(entity =>
            {
                entity.ToTable("ExpertiseLocalize", "Person");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Expertise)
                    .WithMany(p => p.ExpertiseLocalize)
                    .HasForeignKey(d => d.ExpertiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpertiseLocalize_Expertise");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("Faq", "Site");

                entity.HasIndex(e => e.FaqCategoryId)
                    .HasName("IX_FaqCategoryId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FaqCategory)
                    .WithMany(p => p.Faq)
                    .HasForeignKey(d => d.FaqCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.Faq_Main.FaqCategory_FaqCategoryId");
            });

            modelBuilder.Entity<FaqCategory>(entity =>
            {
                entity.ToTable("FaqCategory", "Site");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FaqCategoryLocalize>(entity =>
            {
                entity.ToTable("FaqCategoryLocalize", "Site");

                entity.HasIndex(e => e.FaqCategoryId)
                    .HasName("IX_FaqCategoryId");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("IX_LanguageId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.FaqCategory)
                    .WithMany(p => p.FaqCategoryLocalize)
                    .HasForeignKey(d => d.FaqCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.FaqCategoryLocalize_Main.FaqCategory_FaqCategoryId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FaqCategoryLocalize)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.FaqCategoryLocalize_Main.Language_LanguageId");
            });

            modelBuilder.Entity<FaqLocalize>(entity =>
            {
                entity.ToTable("FaqLocalize", "Site");

                entity.HasIndex(e => e.FaqId)
                    .HasName("IX_FaqId");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("IX_LanguageId");

                entity.Property(e => e.Answer).HasMaxLength(800);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(800);

                entity.HasOne(d => d.Faq)
                    .WithMany(p => p.FaqLocalize)
                    .HasForeignKey(d => d.FaqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.FaqLocalize_Main.Faq_FaqId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FaqLocalize)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.FaqLocalize_Main.Language_LanguageId");
            });

            modelBuilder.Entity<FinancialDocument>(entity =>
            {
                entity.ToTable("FinancialDocument", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PatientWallet)
                    .WithMany(p => p.FinancialDocument)
                    .HasForeignKey(d => d.PatientWalletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FinancialDocument_PatientWallet");

                entity.HasOne(d => d.Reserve)
                    .WithMany(p => p.FinancialDocument)
                    .HasForeignKey(d => d.ReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FinancialDocument_Reserve");
            });

            modelBuilder.Entity<FormMessage>(entity =>
            {
                entity.ToTable("FormMessage", "Common");

                entity.HasIndex(e => e.PageFormItemId)
                    .HasName("IX_PageFormItemId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormMessageLocalize>(entity =>
            {
                entity.ToTable("FormMessageLocalize", "Common");

                entity.HasIndex(e => e.FormMessageId)
                    .HasName("IX_FormMessageId");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("IX_LanguageId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FormMessage)
                    .WithMany(p => p.FormMessageLocalize)
                    .HasForeignKey(d => d.FormMessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.FormMessageLocalize_Main.FormMessage_FormMessageId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FormMessageLocalize)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.FormMessageLocalize_Main.Language_LanguageId");
            });

            modelBuilder.Entity<Gateway>(entity =>
            {
                entity.ToTable("Gateway", "Payment");

                entity.HasIndex(e => e.BankId)
                    .HasName("IX_BankId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BankNavigation)
                    .WithMany(p => p.GatewayNavigation)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment.Gateway_Payment.Bank_BankId");
            });

            modelBuilder.Entity<GatewayParam>(entity =>
            {
                entity.ToTable("GatewayParam", "Payment");

                entity.HasIndex(e => e.GatewayId)
                    .HasName("IX_GatewayId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Gateway)
                    .WithMany(p => p.GatewayParam)
                    .HasForeignKey(d => d.GatewayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment.GatewayParam_Payment.Gateway_GatewayId");
            });

            modelBuilder.Entity<GeneralContent>(entity =>
            {
                entity.ToTable("GeneralContent", "Common");

                entity.HasIndex(e => e.GeneralContentTypeId)
                    .HasName("IX_GeneralContentTypeId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralContentType)
                    .WithMany(p => p.GeneralContent)
                    .HasForeignKey(d => d.GeneralContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.GeneralContent_Main.GeneralContentType_GeneralContentTypeId");
            });

            modelBuilder.Entity<GeneralContentLocalize>(entity =>
            {
                entity.ToTable("GeneralContentLocalize", "Common");

                entity.HasIndex(e => e.GeneralContentId)
                    .HasName("IX_GeneralContentId");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("IX_LanguageId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.GeneralContent)
                    .WithMany(p => p.GeneralContentLocalize)
                    .HasForeignKey(d => d.GeneralContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.GeneralContentLocalize_Main.GeneralContent_GeneralContentId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.GeneralContentLocalize)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.GeneralContentLocalize_Main.Language_LanguageId");
            });

            modelBuilder.Entity<GeneralContentType>(entity =>
            {
                entity.ToTable("GeneralContentType", "Common");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GeneralContentTypeLocalize>(entity =>
            {
                entity.ToTable("GeneralContentTypeLocalize", "Common");

                entity.HasIndex(e => e.GeneralContentTypeId)
                    .HasName("IX_GeneralContentTypeId");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("IX_LanguageId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.GeneralContentType)
                    .WithMany(p => p.GeneralContentTypeLocalize)
                    .HasForeignKey(d => d.GeneralContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.GeneralContentTypeLocalize_Main.GeneralContentType_GeneralContentTypeId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.GeneralContentTypeLocalize)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.GeneralContentTypeLocalize_Main.Language_LanguageId");
            });

            modelBuilder.Entity<HashTag>(entity =>
            {
                entity.ToTable("HashTag", "Site");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<HealthService>(entity =>
            {
                entity.ToTable("HealthService", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HealthServiceLocalize>(entity =>
            {
                entity.ToTable("HealthServiceLocalize", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceTitle)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.HealthService)
                    .WithMany(p => p.HealthServiceLocalize)
                    .HasForeignKey(d => d.HealthServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HealthServiceLocalize_HealthService");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.ToTable("Insurance", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InsuranceLocalize>(entity =>
            {
                entity.ToTable("InsuranceLocalize", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.InsuranceLocalize)
                    .HasForeignKey(d => d.InsuranceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InsuranceLocalize_Insurance");
            });

            modelBuilder.Entity<Investor>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Investor", "Financial");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProfitLetterGroup)
                    .WithMany(p => p.Investor)
                    .HasForeignKey(d => d.ProfitLetterGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Investor_ProfitLetterGroup");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language", "Common");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortTitle).HasMaxLength(10);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<LegalContract>(entity =>
            {
                entity.ToTable("LegalContract", "Financial");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.LegalContract)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LegalContract_Place");

                entity.HasOne(d => d.Visitor)
                    .WithMany(p => p.LegalContract)
                    .HasForeignKey(d => d.VisitorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LegalContract_Visitor");
            });

            modelBuilder.Entity<MedicalMedicine>(entity =>
            {
                entity.ToTable("MedicalMedicine", "Medical");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.MedicalRecord)
                    .WithMany(p => p.MedicalMedicine)
                    .HasForeignKey(d => d.MedicalRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalMedicine_MedicalRecord");

                entity.HasOne(d => d.MedicineNavigation)
                    .WithMany(p => p.MedicalMedicine)
                    .HasForeignKey(d => d.Medicine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalMedicine_Medicine");
            });

            modelBuilder.Entity<MedicalRecodeAdvice>(entity =>
            {
                entity.ToTable("MedicalRecodeAdvice", "Rerserve");

                entity.Property(e => e.AdviceDescriotion).HasMaxLength(400);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpinionFileName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.FromDoctor)
                    .WithMany(p => p.MedicalRecodeAdviceFromDoctor)
                    .HasForeignKey(d => d.FromDoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecodeAdvice_DoctorFrom");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MedicalRecodeAdvice)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecodeAdvice_Patient");

                entity.HasOne(d => d.ToDoctor)
                    .WithMany(p => p.MedicalRecodeAdviceToDoctor)
                    .HasForeignKey(d => d.ToDoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecodeAdvice_DoctorTo");
            });

            modelBuilder.Entity<MedicalRecodeReserveSharing>(entity =>
            {
                entity.ToTable("MedicalRecodeReserveSharing", "Medical");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.MedicalRecodeSharing)
                    .WithMany(p => p.MedicalRecodeReserveSharing)
                    .HasForeignKey(d => d.MedicalRecodeSharingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecodeReserveSharing_MedicalRecodeSharing");

                entity.HasOne(d => d.MedicalRecordReserve)
                    .WithMany(p => p.MedicalRecodeReserveSharing)
                    .HasForeignKey(d => d.MedicalRecordReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecodeReserveSharing_MedicalRecordReserve");
            });

            modelBuilder.Entity<MedicalRecodeSharing>(entity =>
            {
                entity.ToTable("MedicalRecodeSharing", "Medical");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShareDescription).HasMaxLength(400);

                entity.HasOne(d => d.FromDoctor)
                    .WithMany(p => p.MedicalRecodeSharingFromDoctor)
                    .HasForeignKey(d => d.FromDoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecodeSharing_Doctor");

                entity.HasOne(d => d.ToDoctor)
                    .WithMany(p => p.MedicalRecodeSharingToDoctor)
                    .HasForeignKey(d => d.ToDoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecodeSharing_Doctor1");
            });

            modelBuilder.Entity<MedicalRecord>(entity =>
            {
                entity.ToTable("MedicalRecord", "Medical");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DiseaseDescription).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Treatment).IsRequired();

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.MedicalRecord)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecordReserve_Doctor");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MedicalRecord)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecordReserve_Patient");

                entity.HasOne(d => d.Reserver)
                    .WithMany(p => p.MedicalRecord)
                    .HasForeignKey(d => d.ReserverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecord_Reserve");
            });

            modelBuilder.Entity<MedicalRecordFile>(entity =>
            {
                entity.ToTable("MedicalRecordFile", "Medical");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Medical)
                    .WithMany(p => p.MedicalRecordFile)
                    .HasForeignKey(d => d.MedicalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalFile_MedicalRecord");
            });

            modelBuilder.Entity<MedicalRecordReserveAdvice>(entity =>
            {
                entity.ToTable("MedicalRecordReserveAdvice", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.MedicalRecodeAdvice)
                    .WithMany(p => p.MedicalRecordReserveAdvice)
                    .HasForeignKey(d => d.MedicalRecodeAdviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecordReserveAdvice_MedicalRecodeAdvice");

                entity.HasOne(d => d.MedicalRecordReserve)
                    .WithMany(p => p.MedicalRecordReserveAdvice)
                    .HasForeignKey(d => d.MedicalRecordReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalRecordReserveAdvice_MedicalRecordReserve");
            });

            modelBuilder.Entity<MedicalRecordSicknessTag>(entity =>
            {
                entity.ToTable("MedicalRecordSicknessTag", "Medical");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.MedicalRecode)
                    .WithMany(p => p.MedicalRecordSicknessTag)
                    .HasForeignKey(d => d.MedicalRecodeId)
                    .HasConstraintName("FK_MedicalRecordSicknessTag_MedicalRecord");

                entity.HasOne(d => d.SicknessTagNavigation)
                    .WithMany(p => p.MedicalRecordSicknessTag)
                    .HasForeignKey(d => d.SicknessTag)
                    .HasConstraintName("FK_MedicalRecordSicknessTag_SicknessTag");
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.ToTable("Medicine", "Medical");

                entity.Property(e => e.BrandName).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("News", "Site");

                entity.HasIndex(e => e.NewsCategoryId)
                    .HasName("IX_NewsCategoryId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.NewsCategory)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.NewsCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.News_Main.NewsCategory_NewsCategoryId");
            });

            modelBuilder.Entity<NewsCategory>(entity =>
            {
                entity.ToTable("NewsCategory", "Site");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NewsCategoryLocalize>(entity =>
            {
                entity.ToTable("NewsCategoryLocalize", "Site");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("IX_LanguageId");

                entity.HasIndex(e => e.NewsCategoryId)
                    .HasName("IX_NewsCategoryId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.NewsCategoryLocalize)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.NewsCategoryLocalize_Main.Language_LanguageId");

                entity.HasOne(d => d.NewsCategory)
                    .WithMany(p => p.NewsCategoryLocalize)
                    .HasForeignKey(d => d.NewsCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.NewsCategoryLocalize_Main.NewsCategory_NewsCategoryId");
            });

            modelBuilder.Entity<NewsHashTag>(entity =>
            {
                entity.ToTable("NewsHashTag", "Site");

                entity.HasIndex(e => e.HashTagId)
                    .HasName("IX_HashTagId");

                entity.HasIndex(e => e.NewsId)
                    .HasName("IX_NewsId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.HashTag)
                    .WithMany(p => p.NewsHashTag)
                    .HasForeignKey(d => d.HashTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.NewsHashTag_Main.HashTag_HashTagId");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewsHashTag)
                    .HasForeignKey(d => d.NewsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.NewsHashTag_Main.News_NewsId");
            });

            modelBuilder.Entity<NewsLocalize>(entity =>
            {
                entity.ToTable("NewsLocalize", "Site");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("IX_LanguageId");

                entity.HasIndex(e => e.NewsId)
                    .HasName("IX_NewsId");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortBody).HasMaxLength(250);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.NewsLocalize)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.NewsLocalize_Main.Language_LanguageId");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewsLocalize)
                    .HasForeignKey(d => d.NewsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.NewsLocalize_Main.News_NewsId");
            });

            modelBuilder.Entity<NewsTag>(entity =>
            {
                entity.ToTable("NewsTag", "Site");

                entity.HasIndex(e => e.NewsId)
                    .HasName("IX_NewsId");

                entity.HasIndex(e => e.TagId)
                    .HasName("IX_TagId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewsTag)
                    .HasForeignKey(d => d.NewsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.NewsTag_Main.News_NewsId");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.NewsTag)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.NewsTag_Main.Tag_TagId");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Patient", "Person");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.PatientInsurance)
                    .HasForeignKey(d => d.InsuranceId)
                    .HasConstraintName("FK_Patient_Insurance");

                entity.HasOne(d => d.SupplementaryInsurance)
                    .WithMany(p => p.PatientSupplementaryInsurance)
                    .HasForeignKey(d => d.SupplementaryInsuranceId)
                    .HasConstraintName("FK_Patient_Supplementary_Insurance");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Patient)
                    .HasForeignKey<Patient>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_User");
            });

            modelBuilder.Entity<PatientDoctorEvaluation>(entity =>
            {
                entity.ToTable("PatientDoctorEvaluation", "Evaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PatientDoctorEvaluation)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientClub_Doctor");

                entity.HasOne(d => d.Paient)
                    .WithMany(p => p.PatientDoctorEvaluation)
                    .HasForeignKey(d => d.PaientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientClub_Patient");

                entity.HasOne(d => d.Reserve)
                    .WithMany(p => p.PatientDoctorEvaluation)
                    .HasForeignKey(d => d.ReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientClub_Reserve");
            });

            modelBuilder.Entity<PatientDoctorEvaluationCriteria>(entity =>
            {
                entity.ToTable("PatientDoctorEvaluationCriteria", "Evaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.EvaluationCriteria)
                    .WithMany(p => p.PatientDoctorEvaluationCriteria)
                    .HasForeignKey(d => d.EvaluationCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientDoctorEvaluationCriteria_EvaluationCriteria");

                entity.HasOne(d => d.PatientDoctorEvaluation)
                    .WithMany(p => p.PatientDoctorEvaluationCriteria)
                    .HasForeignKey(d => d.PatientDoctorEvaluationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientDoctorEvaluationCriteria_PatientDoctorEvaluation");
            });

            modelBuilder.Entity<PatientPlaceEvaluation>(entity =>
            {
                entity.ToTable("PatientPlaceEvaluation", "Evaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Paient)
                    .WithMany(p => p.PatientPlaceEvaluation)
                    .HasForeignKey(d => d.PaientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientPlaceEvaluation_Patient");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.PatientPlaceEvaluation)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientPlaceEvaluation_Place");

                entity.HasOne(d => d.Reserve)
                    .WithMany(p => p.PatientPlaceEvaluation)
                    .HasForeignKey(d => d.ReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientPlaceEvaluation_Reserve");
            });

            modelBuilder.Entity<PatientPlaceEvaluationCriteria>(entity =>
            {
                entity.ToTable("PatientPlaceEvaluationCriteria", "Evaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.EvaluationCriteria)
                    .WithMany(p => p.PatientPlaceEvaluationCriteria)
                    .HasForeignKey(d => d.EvaluationCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientPlaceEvaluationCriteria_EvaluationCriteria");

                entity.HasOne(d => d.PatientPlaceEvaluation)
                    .WithMany(p => p.PatientPlaceEvaluationCriteria)
                    .HasForeignKey(d => d.PatientPlaceEvaluationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientPlaceEvaluationCritera_PatientPlaceEvaluation");
            });

            modelBuilder.Entity<PatientSecretaryEvaluation>(entity =>
            {
                entity.ToTable("PatientSecretaryEvaluation", "Evaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Paient)
                    .WithMany(p => p.PatientSecretaryEvaluation)
                    .HasForeignKey(d => d.PaientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientSecretaryEvaluation_Patient");

                entity.HasOne(d => d.Reserve)
                    .WithMany(p => p.PatientSecretaryEvaluation)
                    .HasForeignKey(d => d.ReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientSecretaryEvaluation_Reserve");

                entity.HasOne(d => d.Secretary)
                    .WithMany(p => p.PatientSecretaryEvaluation)
                    .HasForeignKey(d => d.SecretaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientSecretaryEvaluation_Secretary");
            });

            modelBuilder.Entity<PatientSecretaryEvaluationCriteria>(entity =>
            {
                entity.ToTable("PatientSecretaryEvaluationCriteria", "Evaluation");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.EvaluationCriteria)
                    .WithMany(p => p.PatientSecretaryEvaluationCriteria)
                    .HasForeignKey(d => d.EvaluationCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientSecretaryEvaluationCriteria_EvaluationCriteria");

                entity.HasOne(d => d.PatientSecretaryEvaluation)
                    .WithMany(p => p.PatientSecretaryEvaluationCriteria)
                    .HasForeignKey(d => d.PatientSecretaryEvaluationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientSecretaryEvaluationCriteria_PatientSecretaryEvaluation");
            });

            modelBuilder.Entity<PatientWallet>(entity =>
            {
                entity.ToTable("PatientWallet", "Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientWallet)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWallet_Patient");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment", "Payment");

                entity.HasIndex(e => e.GatewayId)
                    .HasName("IX_GatewayId");

                entity.Property(e => e.CallBackDate).HasColumnType("datetime");

                entity.Property(e => e.CartId)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Gateway)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.GatewayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment.Payment_Payment.Gateway_GatewayId");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission", "UserManagement");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PermissionLocalize>(entity =>
            {
                entity.ToTable("PermissionLocalize", "UserManagement");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_PermissionId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionLocalize)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.PermissionLocalize_UserManagement.Permission_PermissionId");
            });

            modelBuilder.Entity<PersonalHoliday>(entity =>
            {
                entity.ToTable("PersonalHoliday", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Calendar)
                    .WithMany(p => p.PersonalHoliday)
                    .HasForeignKey(d => d.CalendarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalHoliday_Calendar");

                entity.HasOne(d => d.ShiftWork)
                    .WithMany(p => p.PersonalHoliday)
                    .HasForeignKey(d => d.ShiftWorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalHoliday_ShiftWork");
            });

            modelBuilder.Entity<PersonContract>(entity =>
            {
                entity.ToTable("PersonContract", "Financial");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PersonContract)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonContract_Doctor");

                entity.HasOne(d => d.Visitor)
                    .WithMany(p => p.PersonContract)
                    .HasForeignKey(d => d.VisitorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonContract_Visitor");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.ToTable("Place", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PlaceAddress)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.PlaceOwnership)
                    .WithMany(p => p.Place)
                    .HasForeignKey(d => d.PlaceOwnershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hospital_HospitalOwnership");

                entity.HasOne(d => d.PlaceType)
                    .WithMany(p => p.Place)
                    .HasForeignKey(d => d.PlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hospital_HotpitalType");
            });

            modelBuilder.Entity<PlaceContact>(entity =>
            {
                entity.ToTable("PlaceContact", "Place");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ContectValue)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.PlaceContact)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_ContactType");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.PlaceContact)
                    .HasForeignKey<PlaceContact>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_Doctor");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.PlaceContact)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceContact_Place");
            });

            modelBuilder.Entity<PlaceFile>(entity =>
            {
                entity.ToTable("PlaceFile", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.PlaceFile)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceFile_Place");
            });

            modelBuilder.Entity<PlaceHealthService>(entity =>
            {
                entity.ToTable("PlaceHealthService", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.HealthService)
                    .WithMany(p => p.PlaceHealthService)
                    .HasForeignKey(d => d.HealthServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalHealthService_HealthService");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.PlaceHealthService)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceHealthService_Place");
            });

            modelBuilder.Entity<PlaceInsurance>(entity =>
            {
                entity.ToTable("PlaceInsurance", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.PlaceInsurance)
                    .HasForeignKey(d => d.InsuranceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalInsurance_Insurance");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.PlaceInsurance)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceInsurance_Place");
            });

            modelBuilder.Entity<PlaceLocalize>(entity =>
            {
                entity.ToTable("PlaceLocalize", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PlaceAddress)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.PlaceLocalize)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceLocalize_Place");
            });

            modelBuilder.Entity<PlaceOwnership>(entity =>
            {
                entity.ToTable("PlaceOwnership", "Place");

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlaceOwnershipLocalize>(entity =>
            {
                entity.ToTable("PlaceOwnershipLocalize", "Place");

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.PlaceOwnership)
                    .WithMany(p => p.PlaceOwnershipLocalize)
                    .HasForeignKey(d => d.PlaceOwnershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceOwnershipLocalize_PlaceOwnership");
            });

            modelBuilder.Entity<PlaceType>(entity =>
            {
                entity.ToTable("PlaceType", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PlaceTypeLocalize>(entity =>
            {
                entity.ToTable("PlaceTypeLocalize", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.PlaceType)
                    .WithMany(p => p.PlaceTypeLocalize)
                    .HasForeignKey(d => d.PlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceTypeLocalize_PlaceType");
            });

            modelBuilder.Entity<ProfitLetterGroup>(entity =>
            {
                entity.ToTable("ProfitLetterGroup", "Financial");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PercentageShare).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province", "UserManagement");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_CountryId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Province)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.Province_UserManagement.Country_CountryId");
            });

            modelBuilder.Entity<ReschedulingReserve>(entity =>
            {
                entity.ToTable("ReschedulingReserve", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Reserve)
                    .WithMany(p => p.ReschedulingReserve)
                    .HasForeignKey(d => d.ReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReschedulingReserve_Reserve");
            });

            modelBuilder.Entity<Reserve>(entity =>
            {
                entity.ToTable("Reserve", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Reserve)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reserve_Patient");
            });

            modelBuilder.Entity<ReserveHistory>(entity =>
            {
                entity.ToTable("ReserveHistory", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Calendar)
                    .WithMany(p => p.ReserveHistory)
                    .HasForeignKey(d => d.CalendarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReserveHistory_Calendar");

                entity.HasOne(d => d.Reserve)
                    .WithMany(p => p.ReserveHistory)
                    .HasForeignKey(d => d.ReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReserveHistory_Reserve");

                entity.HasOne(d => d.ReserveState)
                    .WithMany(p => p.ReserveHistory)
                    .HasForeignKey(d => d.ReserveStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReserveHistory_ReserveState");

                entity.HasOne(d => d.ShiftWork)
                    .WithMany(p => p.ReserveHistory)
                    .HasForeignKey(d => d.ShiftWorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReserveHistory_ShiftWork");
            });

            modelBuilder.Entity<ReserveState>(entity =>
            {
                entity.ToTable("ReserveState", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ReserveStateHistory>(entity =>
            {
                entity.ToTable("ReserveStateHistory", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CurrentReserveState)
                    .WithMany(p => p.ReserveStateHistoryCurrentReserveState)
                    .HasForeignKey(d => d.CurrentReserveStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReserveStateHistory_ReserveState_Current");

                entity.HasOne(d => d.OldReserveState)
                    .WithMany(p => p.ReserveStateHistoryOldReserveState)
                    .HasForeignKey(d => d.OldReserveStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReserveStateHistory_ReserveState_Old");

                entity.HasOne(d => d.Reserve)
                    .WithMany(p => p.ReserveStateHistory)
                    .HasForeignKey(d => d.ReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReserveStateHistory_Reserve");
            });

            modelBuilder.Entity<Secretary>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Secretary", "Person");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Secretary)
                    .HasForeignKey<Secretary>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Secretary_User");
            });

            modelBuilder.Entity<SecretarySubPlace>(entity =>
            {
                entity.ToTable("SecretarySubPlace", "Person");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseTime).HasMaxLength(100);

                entity.HasOne(d => d.DoctorSubPlace)
                    .WithMany(p => p.SecretarySubPlace)
                    .HasForeignKey(d => d.DoctorSubPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecretarySubPlace_DoctorSubPlace");

                entity.HasOne(d => d.Secretary)
                    .WithMany(p => p.SecretarySubPlace)
                    .HasForeignKey(d => d.SecretaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecretaryOwner_Secretary");
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.ToTable("Sex", "UserManagement");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SexLocalize>(entity =>
            {
                entity.ToTable("SexLocalize", "UserManagement");

                entity.HasIndex(e => e.SexId)
                    .HasName("IX_SexId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.SexLocalize)
                    .HasForeignKey(d => d.SexId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.SexLocalize_UserManagement.Sex_SexId");
            });

            modelBuilder.Entity<Shareholder>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Shareholder", "Financial");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PercentageShare).HasColumnType("decimal(2, 2)");

                entity.HasOne(d => d.ProfitLetterGroup)
                    .WithMany(p => p.Shareholder)
                    .HasForeignKey(d => d.ProfitLetterGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shareholder_ProfitLetterGroup");
            });

            modelBuilder.Entity<ShiftWork>(entity =>
            {
                entity.ToTable("ShiftWork", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.DoctorSubPlace)
                    .WithMany(p => p.ShiftWork)
                    .HasForeignKey(d => d.DoctorSubPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShiftWork_DoctorSubPlace");

                entity.HasOne(d => d.ShiftWorkType)
                    .WithMany(p => p.ShiftWork)
                    .HasForeignKey(d => d.ShiftWorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShiftWork_ShiftWorkType");
            });

            modelBuilder.Entity<ShiftWorkType>(entity =>
            {
                entity.ToTable("ShiftWorkType", "Rerserve");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SicknessTag>(entity =>
            {
                entity.ToTable("SicknessTag", "Medical");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SubPlace>(entity =>
            {
                entity.ToTable("SubPlace", "Place");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.SubPlace)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubPlace_Place");

                entity.HasOne(d => d.SubPlaceParentNavigation)
                    .WithMany(p => p.InverseSubPlaceParentNavigation)
                    .HasForeignKey(d => d.SubPlaceParent)
                    .HasConstraintName("FK_SubPlace_SubPlace");
            });

            modelBuilder.Entity<SubPlaceContact>(entity =>
            {
                entity.ToTable("SubPlaceContact", "Place");

                entity.Property(e => e.ContectValue)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.SubPlaceContact)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubPlaceContact_ContactType");

                entity.HasOne(d => d.SubPlace)
                    .WithMany(p => p.SubPlaceContact)
                    .HasForeignKey(d => d.SubPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubPlaceContact_SubPlace");
            });

            modelBuilder.Entity<SubPlaceFile>(entity =>
            {
                entity.ToTable("SubPlaceFile", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SubPlace)
                    .WithMany(p => p.SubPlaceFile)
                    .HasForeignKey(d => d.SubPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubPlaceFile_SubPlace");
            });

            modelBuilder.Entity<SubPlaceHealthService>(entity =>
            {
                entity.ToTable("SubPlaceHealthService", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PlaceHealthService)
                    .WithMany(p => p.SubPlaceHealthService)
                    .HasForeignKey(d => d.PlaceHealthServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubPlaceHelathService_PlaceHealthService");

                entity.HasOne(d => d.SubPlace)
                    .WithMany(p => p.SubPlaceHealthService)
                    .HasForeignKey(d => d.SubPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubPlaceHelathService_SubPlace");
            });

            modelBuilder.Entity<SubPlaceLocalize>(entity =>
            {
                entity.ToTable("SubPlaceLocalize", "Place");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.SubPlace)
                    .WithMany(p => p.SubPlaceLocalize)
                    .HasForeignKey(d => d.SubPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubPlaceLocalize_SubPlace");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag", "Site");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UiPage>(entity =>
            {
                entity.ToTable("UiPage", "Common");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UiPageLocalize>(entity =>
            {
                entity.ToTable("UiPageLocalize", "Common");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("IX_LanguageId");

                entity.HasIndex(e => e.UiPageId)
                    .HasName("IX_UiPageId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.UiPageLocalize)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.UiPageLocalize_Main.Language_LanguageId");

                entity.HasOne(d => d.UiPage)
                    .WithMany(p => p.UiPageLocalize)
                    .HasForeignKey(d => d.UiPageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Main.UiPageLocalize_Main.UiPage_UiPageId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "UserManagement");

                entity.HasIndex(e => e.CityId)
                    .HasName("IX_CityId");

                entity.HasIndex(e => e.SexId)
                    .HasName("IX_SexId");

                entity.HasIndex(e => e.UserGroupId)
                    .HasName("IX_UserGroupId");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NationalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_UserManagement.User_UserManagement.City_CityId");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK_UserManagement.User_UserManagement.Sex_SexId");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.User_UserManagement.UserGroup_UserGroupId");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.ToTable("UserAddress", "UserManagement");

                entity.HasIndex(e => e.CityId)
                    .HasName("IX_CityId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Langtiude).HasMaxLength(100);

                entity.Property(e => e.Latitude).HasMaxLength(100);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumberPreCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumberPreCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.UserAddress)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.UserAddress_UserManagement.City_CityId");
            });

            modelBuilder.Entity<UserBankCard>(entity =>
            {
                entity.ToTable("UserBankCard", "UserManagement");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShabaNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.UserBankCard)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserBankCard_Bank");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserBankCard)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserBankCard_User");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.ToTable("UserGroup", "UserManagement");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserGroupLocalize>(entity =>
            {
                entity.ToTable("UserGroupLocalize", "UserManagement");

                entity.HasIndex(e => e.UserGroupId)
                    .HasName("IX_UserGroupId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.UserGroupLocalize)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.UserGroupLocalize_UserManagement.UserGroup_UserGroupId");
            });

            modelBuilder.Entity<UserGroupPermission>(entity =>
            {
                entity.ToTable("UserGroupPermission", "UserManagement");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_PermissionId");

                entity.HasIndex(e => e.UserGroupId)
                    .HasName("IX_UserGroupId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserGroupPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.UserGroupPermission_UserManagement.Permission_PermissionId");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.UserGroupPermission)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.UserGroupPermission_UserManagement.UserGroup_UserGroupId");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.ToTable("UserPermission", "UserManagement");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_PermissionId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.UserPermission_UserManagement.Permission_PermissionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserManagement.UserPermission_UserManagement.User_UserId");
            });

            modelBuilder.Entity<Visitor>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Visitor", "Financial");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProfitLetterGroup)
                    .WithMany(p => p.Visitor)
                    .HasForeignKey(d => d.ProfitLetterGroupId)
                    .HasConstraintName("FK_Visitor_ProfitLetterGroup");
            });

            modelBuilder.Entity<WalletFinancialTransaction>(entity =>
            {
                entity.ToTable("WalletFinancialTransaction", "Payment");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PatientWallet)
                    .WithMany(p => p.WalletFinancialTransaction)
                    .HasForeignKey(d => d.PatientWalletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WalletFinancialTransaction_PatientWallet");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.WalletFinancialTransaction)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WalletFinancialTransaction_Payment");
            });
        }
    }
}
