using DevExpress.XtraLayout.Customization;
using Microsoft.EntityFrameworkCore;
using PlanSystem.Entity;

namespace PlanSystem
{
    public class MainDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Defaults.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasData(
                new Users()
                {
                    Id = 1,
                    IsReadonly = false,
                    UserName = "admin",
                    Password = "123"
                }
                );

            modelBuilder.Entity<PropertyCategories>()
                .HasData(
                new PropertyCategories()
                {
                    Id = 1,
                    Name = "زمین"
                },
                new PropertyCategories()
                {
                    Id = 2,
                    Name = "دیوارها"
                },
                new PropertyCategories()
                {
                    Id = 3,
                    Name = "ساختمان"
                },
                new PropertyCategories()
                {
                    Id = 4,
                    Name = "چاه"
                },
                new PropertyCategories()
                {
                    Id = 5,
                    Name = "چاه بدرفت"
                },
                new PropertyCategories()
                {
                    Id = 6,
                    Name = "پطرول پمپ"
                },
                new PropertyCategories()
                {
                    Id = 7,
                    Name = "تعمیرات به شکل هنګر و تحویل خانه پخته کاري"
                }
                );

            modelBuilder.Entity<PropertyType>()
                .HasData(
                new PropertyType()
                {
                    Id = 1,
                    Name = "تجارتي"
                },
                new PropertyType()
                {
                    Id = 2,
                    Name = "دولتي"
                },
                new PropertyType()
                {
                    Id = 3,
                    Name = "رهایشي"
                },
                new PropertyType()
                {
                    Id = 4,
                    Name = "صنعتي"
                },
                new PropertyType()
                {
                    Id = 5,
                    Name = "تولیدي"
                },
                new PropertyType()
                {
                    Id = 6,
                    Name = "عامه"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<PropertyCategories> Categories { get; set; }
        public DbSet<PropertyType> Types { get; set; }
        public DbSet<PropertyInfo> Properties { get; set; }
        public DbSet<RegistrationInfo> Registration { get; set; }
    }
}
