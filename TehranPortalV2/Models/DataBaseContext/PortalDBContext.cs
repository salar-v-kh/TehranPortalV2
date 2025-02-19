//using Microsoft.EntityFrameworkCore;
//using PortalWebMVC.Models.Entities.Base_info;
//using System.Collections.Generic;
//using TehranPortalV2.Controllers.FirstTable;

//namespace PortalWebMVC.Models.DataBaseContex
//{
//    public class PortalDBContext : DbContext
//    {
//        public PortalDBContext(DbContextOptions<PortalDBContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<Branch> TB_Branch { get; set; }
//        public DbSet<ITLabele> TB_ITLabele { get; set; }

//        public DbSet<YLable> TB_YLable { get; set; }

//        public DbSet<UserPersonal> TB_UserPersonal { get; set; }
//        public DbSet<ClientPassword> TB_ClientPassword { get; set; }
//        public DbSet<DeviceProfiles> TB_DeviceProfile { get; set; }


//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            modelBuilder.Entity<Branch>(entity =>
//            {
//                entity.HasKey(e => e.BRCode); // تعریف کلید اصلی
//                entity.Property(e => e.BRCode)
//                    .HasMaxLength(4) // محدودیت طول ۴ کاراکتر
//                    .IsRequired(); // اجباری بودن فیلد
//                entity.Property(e => e.BRName)
//                    .IsRequired(); // اجباری بودن فیلد نام
//                entity.Property(e => e.BRPhone1);

//                entity.Property(e => e.BRPhone2);

//                entity.Property(e => e.BRPhone3);

//                entity.Property(e => e.IPAddress)
//                   .HasMaxLength(2);

//            });

//            modelBuilder.Entity<YLable>(entity =>
//            {
//                entity.HasKey(e => e.Y_LableCode); // تعریف کلید اصلی
//                entity.Property(e => e.Y_LableCode)
//                    .HasMaxLength(7) // محدودیت طول ۷ کاراکتر
//                    .IsRequired(); // اجباری بودن فیلد
//                entity.Property(e => e.Id)
//                    .IsRequired(); // اجباری بودن فیلد
//                entity.Property(e => e.YLableStatus)
//                    .IsRequired(); // اجباری بودن فیلد
//            });

//            modelBuilder.Entity<ITLabele>(entity =>
//            {
//                entity.HasKey(e => e.IT_CodeLable); // تعریف کلید اصلی
//                entity.Property(e => e.IT_CodeLable)
//                    .HasMaxLength(10) // محدودیت طول ۱۰ کاراکتر
//                    .IsRequired(); // اجباری بودن فیلد
//                entity.Property(e => e.Id)
//                    .IsRequired(); // اجباری بودن فیلد
//                entity.Property(e => e.ITLableStatus)
//                   .IsRequired(); // اجباری بودن فیلد
//            });

//            modelBuilder.Entity<UserPersonal>(entity =>
//            {
//                entity.HasKey(e => e.Id_Personal); // تعریف کلید اصلی
//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(100)
//                    .IsRequired();
//                entity.Property(e => e.LastName)
//                    .HasMaxLength(100)
//                    .IsRequired();
//                entity.Property(e =>e.Role)
//                    .IsRequired();
//                entity.Property(e => e.Active)
//                .IsRequired();
//                entity.Property(e => e.PhoneNumber)
//                    .HasMaxLength(15)
//                    .IsRequired();
//                entity.Property(e => e.Gender)
//                    .IsRequired();
//                entity.Property(e => e.Password)
//                    .HasMaxLength(100)
//                    .IsRequired();

//                entity.HasOne(e => e.ClientPassword)
//                .WithOne(p => p.UserPersonal)
//                .HasForeignKey<ClientPassword>(p => p.Id_Personal);

//            });
//            modelBuilder.Entity<ClientPassword>(entity =>
//            {
//                entity.HasKey(e => e.Id_Personal);
//                entity.Property(e => e.Password)
//                .HasMaxLength(100)
//                .IsRequired();
//            });
//        }
//    }
//}


using Microsoft.EntityFrameworkCore;
using PortalWebMVC.Models.Entities.Base_info;
using TehranPortalV2.Models.Entities.FirstTable;

namespace PortalWebMVC.Models.DataBaseContex
{
    public class PortalDBContext : DbContext
    {
        public PortalDBContext(DbContextOptions<PortalDBContext> options)
            : base(options)
        {
        }

        public DbSet<Branch> TB_Branch { get; set; }
        public DbSet<ITLabele> TB_ITLabele { get; set; }
        public DbSet<YLable> TB_YLable { get; set; }
        public DbSet<UserPersonal> TB_UserPersonal { get; set; }
        public DbSet<ClientPassword> TB_ClientPassword { get; set; }
        // public DbSet<DeviceProfiles> TB_DeviceProfile { get; set; }
        public DbSet<CombinedLable> TB_CombinedLables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //---------------CombinedLable-------------
            modelBuilder.Entity<CombinedLable>()
             .HasOne(c => c.YLable)
             .WithMany()
             .HasForeignKey(c => c.YLableCode);

            modelBuilder.Entity<CombinedLable>()
                .HasOne(c => c.ITLabele)
                .WithMany()
                .HasForeignKey(c => c.ITLableCode);





            // ---------------- Branch ----------------
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BRCode); // کلید اصلی
                entity.Property(e => e.BRCode)
                    .HasMaxLength(4)
                    .IsRequired();
                entity.Property(e => e.BRName)
                    .IsRequired();
                entity.Property(e => e.BRPhone1);
                entity.Property(e => e.BRPhone2);
                entity.Property(e => e.BRPhone3);
                entity.Property(e => e.IPAddress)
                   .HasMaxLength(15);
            });

            // ---------------- YLable ----------------
            //modelBuilder.Entity<YLable>(entity =>
            //{
            //    entity.HasKey(e => e.Y_LableCode); // کلید اصلی روی Y_LableCode
            //    entity.Property(e => e.Y_LableCode)
            //        .HasMaxLength(7)
            //        .IsRequired();
            //    entity.Property(e => e.YLableStatus)
            //        .IsRequired();
            //});

            modelBuilder.Entity<ITLabele>(entity =>
            {
                entity.HasKey(e => e.IT_CodeLable); // کلید اصلی روی IT_CodeLable
                entity.Property(e => e.IT_CodeLable)
                      .HasMaxLength(10)
                      .IsRequired();
                entity.Property(e => e.ITLableStatus)
                      .IsRequired();

                // تعریف رابطه یک به چند: هر ITLabele چند YLable دارد.
                entity.HasMany(e => e.YLables)
                      .WithOne(y => y.ITLabele)
                      .HasForeignKey(y => y.IT_CodeLable)
                      .IsRequired();
            });
            // ---------------- ITLabele ----------------
            //modelBuilder.Entity<ITLabele>(entity =>
            //{
            //    entity.HasKey(e => e.IT_CodeLable); // کلید اصلی روی IT_CodeLable
            //    entity.Property(e => e.IT_CodeLable)
            //        .HasMaxLength(10)
            //        .IsRequired();
            //    entity.Property(e => e.ITLableStatus)
            //        .IsRequired();
            //});

            modelBuilder.Entity<YLable>(entity =>
            {
                entity.HasKey(e => e.Y_LableCode);
                entity.Property(e => e.Y_LableCode)
                      .HasMaxLength(7)
                      .IsRequired();

                entity.Property(e => e.IT_CodeLable)
                      .HasMaxLength(10)
                      .IsRequired();
            });




            // ---------------- UserPersonal ----------------
            modelBuilder.Entity<UserPersonal>(entity =>
            {
                entity.HasKey(e => e.Id_Personal);
                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsRequired();
                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsRequired();
                entity.Property(e => e.Role)
                    .IsRequired();
                entity.Property(e => e.Active)
                    .IsRequired();
                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsRequired();
                entity.Property(e => e.Gender)
                    .IsRequired();
                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.HasOne(e => e.ClientPassword)
                    .WithOne(p => p.UserPersonal)
                    .HasForeignKey<ClientPassword>(p => p.Id_Personal);
            });

            // ---------------- ClientPassword ----------------
            modelBuilder.Entity<ClientPassword>(entity =>
            {
                entity.HasKey(e => e.Id_Personal);
                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsRequired();
            });
        }
    }
}
