using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MonthlyBillsWebAPI.Models
{
    public partial class MonthlyBillsWebAppTR_dbContext : DbContext
    {
        public MonthlyBillsWebAppTR_dbContext()
        {
        }

        public MonthlyBillsWebAppTR_dbContext(DbContextOptions<MonthlyBillsWebAppTR_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoles2> AspNetRoles2 { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserClaims1> AspNetUserClaims1 { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserLogins1> AspNetUserLogins1 { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserRoles1> AspNetUserRoles1 { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUsers1> AspNetUsers1 { get; set; }
        public virtual DbSet<BillTypes> BillTypes { get; set; }
        public virtual DbSet<BringHomePay> BringHomePay { get; set; }
        public virtual DbSet<BringHomePayAll> BringHomePayAll { get; set; }
        public virtual DbSet<Calories> Calories { get; set; }
        public virtual DbSet<ChimeRevenueByMonth> ChimeRevenueByMonth { get; set; }
        public virtual DbSet<Dates> Dates { get; set; }
        public virtual DbSet<DisasterInfo> DisasterInfo { get; set; }
        public virtual DbSet<EmpTest> EmpTest { get; set; }
        public virtual DbSet<KeyBalance> KeyBalance { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<MonthlyBills> MonthlyBills { get; set; }
        public virtual DbSet<OneOffBills> OneOffBills { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<Transactions1> Transactions1 { get; set; }
        public virtual DbSet<UpcomingBills> UpcomingBills { get; set; }
        public virtual DbSet<UpcomingBillsAlter> UpcomingBillsAlter { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserClaim> UserClaim { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }
        public virtual DbSet<UserOg> UserOg { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserUserRole> UserUserRole { get; set; }
        public virtual DbSet<VenmoTransactions> VenmoTransactions { get; set; }
        public virtual DbSet<VwMonthlyBudget> VwMonthlyBudget { get; set; }
        public virtual DbSet<VwWeeklyIncomeNeeded> VwWeeklyIncomeNeeded { get; set; }
        public virtual DbSet<WeeklyBills> WeeklyBills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=monthlybillswebapp-tr-dbserver.database.windows.net;Database=MonthlyBillsWebAppTR_db;User ID=tonyryan;Password=AzureWebApp#1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoles2>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserClaims1>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims1)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins1>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins1)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles1>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles1)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles1)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUsers1>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<BillTypes>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BillType).HasMaxLength(25);
            });

            modelBuilder.Entity<BringHomePay>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickOnePayDate).HasColumnType("date");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<BringHomePayAll>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Calories>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("calories");

                entity.Property(e => e.Activeenergy)
                    .HasColumnName("activeenergy")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("creationdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Restingenergy)
                    .HasColumnName("restingenergy")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Totalburned)
                    .HasColumnName("totalburned")
                    .HasColumnType("decimal(16, 6)");
            });

            modelBuilder.Entity<ChimeRevenueByMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChimeRevenueByMonth", "CMP");

                entity.Property(e => e.MonthYear).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayOfMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Todo')");

                entity.Property(e => e.MonthNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Thedate)
                    .HasColumnName("thedate")
                    .HasColumnType("date");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasDefaultValueSql("((2020))");
            });

            modelBuilder.Entity<DisasterInfo>(entity =>
            {
                entity.HasKey(e => new { e.DisasterNumber, e.County })
                    .HasName("PK_Disaster_County")
                    .IsClustered(false);

                entity.ToTable("DisasterInfo", "FEMA");

                entity.Property(e => e.County)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.DeclarationDate).HasColumnType("datetime");

                entity.Property(e => e.LastRefresh)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefreshAdj).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpTest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KeyBalance>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvailableBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.KeyBalance1).HasColumnName("KeyBalance");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MonthlyBills>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillAlias).HasMaxLength(50);

                entity.Property(e => e.Paid)
                    .IsRequired()
                    .HasColumnName("Paid?")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<OneOffBills>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bill)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(450);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.OneOffBills)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OneOffBills_BillType");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => new { e.Transaction_Id, e.Account_Id, e.Date })
                    .HasName("PK__Transact__BC75FCA20F68E0C9");

                entity.ToTable("Transactions", "CMP");

                entity.Property(e => e.Transaction_Id)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Account_Id)
                    .HasColumnName("account_id")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Account_Owner)
                    .HasColumnName("account_owner")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Authorized_Date)
                    .HasColumnName("authorized_date")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Iso_Currency_Code)
                    .HasColumnName("iso_currency_code")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Merchant_Name)
                    .HasColumnName("merchant_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Payment_Channel)
                    .HasColumnName("payment_channel")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Payment_Meta)
                    .HasColumnName("payment_meta")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pending)
                    .HasColumnName("pending")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pending_Transaction_Id)
                    .HasColumnName("pending_transaction_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Transaction_Code)
                    .HasColumnName("transaction_code")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Transaction_Type)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unofficial_Currency_Code)
                    .HasColumnName("unofficial_currency_code")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transactions1>(entity =>
            {
                entity.HasKey(e => new { e.TransactionId, e.AccountId, e.Date })
                    .HasName("PK__Transact__BC75FCA2B80882A5");

                entity.ToTable("Transactions");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccountOwner)
                    .HasColumnName("account_owner")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AuthorizedDate)
                    .HasColumnName("authorized_date")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsoCurrencyCode)
                    .HasColumnName("iso_currency_code")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantName)
                    .HasColumnName("merchant_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentChannel)
                    .HasColumnName("payment_channel")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMeta)
                    .HasColumnName("payment_meta")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pending)
                    .HasColumnName("pending")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PendingTransactionId)
                    .HasColumnName("pending_transaction_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionCode)
                    .HasColumnName("transaction_code")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnofficialCurrencyCode)
                    .HasColumnName("unofficial_currency_code")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpcomingBills>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.RunningTotal).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.TheDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<UpcomingBillsAlter>(entity =>
            {
                entity.ToTable("UpcomingBills_Alter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.TheDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UK_User_UserName")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.PasswordHash).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.SecurityStamp).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserClaim>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PK_UserClaim_ClaimID");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClaim)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserClaim_User");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.ProviderKey })
                    .HasName("PK_UserLogin_UserID_LoginProvider_ProviderKey");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogin)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserLogin_User");
            });

            modelBuilder.Entity<UserOg>(entity =>
            {
                entity.HasKey(e => e.UseId)
                    .HasName("PK__User__64B2E0AAE53B309F");

                entity.ToTable("UserOG");

                entity.Property(e => e.UseId).HasColumnName("UseID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_UserRole_RoleID");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_UserRole_Name")
                    .IsUnique();

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_UserUserRole_UserID_RoleID");

                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserUserRole)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserUserRole_UserRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserUserRole)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserUserRole_User");
            });

            modelBuilder.Entity<VenmoTransactions>(entity =>
            {
                entity.ToTable("VenmoTransactions", "CMP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DateCompleted)
                    .HasColumnName("date_completed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("date_updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("display_name")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(55);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(55);

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Userid1)
                    .HasColumnName("userid")
                    .HasMaxLength(25);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VwMonthlyBudget>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MonthlyBudget");

                entity.Property(e => e.TotalOutflow).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwWeeklyIncomeNeeded>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WeeklyIncomeNeeded");

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.NeededPerWeek).HasColumnType("numeric(7, 2)");

                entity.Property(e => e.RunningTotal).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.TheDate).HasColumnType("date");
            });

            modelBuilder.Entity<WeeklyBills>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(450);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
