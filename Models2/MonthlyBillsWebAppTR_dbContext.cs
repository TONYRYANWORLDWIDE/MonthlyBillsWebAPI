using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace MonthlyBillsWebAPI.Models2
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

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BringHomePay> BringHomePay { get; set; }
        public virtual DbSet<BringHomePayAll> BringHomePayAll { get; set; }
        public virtual DbSet<Dates> Dates { get; set; }
        public virtual DbSet<KeyBalance> KeyBalance { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<MonthlyBills> MonthlyBills { get; set; }
        public virtual DbSet<TransactionsupdateNew> TransactionsupdateNew { get; set; }
        public virtual DbSet<UpcomingBills> UpcomingBills { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserClaim> UserClaim { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }
        public virtual DbSet<UserOg> UserOg { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserUserRole> UserUserRole { get; set; }
        public virtual DbSet<WeeklyBills> WeeklyBills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=monthlybillswebapp-tr-dbserver.database.windows.net;Database=MonthlyBillsWebAppTR_db;Trusted_Connection=False; User ID=tonyryan;Password=AzureWebApp#1");
                //optionsBuilder.UseSqlServer(Configuration.Get["ConnectionString:AzureDB"]));
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
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
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
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
                    .HasColumnName("UserID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BringHomePay)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__BringHome__UserI__467D75B8");
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

            modelBuilder.Entity<Dates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayOfMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Thedate)
                    .HasColumnName("thedate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<KeyBalance>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.KeyBalance1).HasColumnName("KeyBalance");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.KeyBalance)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__KeyBalanc__UserI__3552E9B6");
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

                entity.Property(e => e.Date)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MonthlyBills)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__MonthlyBi__UserI__2DB1C7EE");
            });

            modelBuilder.Entity<TransactionsupdateNew>(entity =>
            {
                entity.ToTable("transactionsupdateNew");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountTransformed)
                    .HasColumnName("amount_transformed")
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Originaldescription)
                    .HasColumnName("originaldescription")
                    .IsUnicode(false);

                entity.Property(e => e.SubCat)
                    .HasColumnName("sub_cat")
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transaction_type")
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

                entity.Property(e => e.RunningTotal).HasColumnType("numeric(13, 2)");

                entity.Property(e => e.TheDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UpcomingBills)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UpcomingB__UserI__36470DEF");
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
                    .HasColumnName("UserID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WeeklyBills)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__WeeklyBil__UserI__345EC57D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
