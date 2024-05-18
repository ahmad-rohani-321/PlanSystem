using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PlanSystem.Entity;

namespace PlanSystem
{
    public class MainDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqliteConnectionStringBuilder connectionString = new SqliteConnectionStringBuilder();
            connectionString.DataSource = @"Database.db";
            connectionString.Password = "Secret@123Ahmad.Rohani";
            optionsBuilder.UseSqlite(new SqliteConnection(connectionString.ConnectionString));
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
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<PropertyCategories> Categories { get; set; }
        public DbSet<PropertyType> Types { get; set; }
        public DbSet<PropertyInfo> Properties { get; set; }
        public DbSet<RegistrationInfo> Registration { get; set; }
    }
}
