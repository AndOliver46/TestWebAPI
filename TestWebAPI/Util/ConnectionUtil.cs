using Microsoft.EntityFrameworkCore;
using Npgsql;
using TestWebAPI.Model;

namespace TestWebAPI.Util
{
    public class ConnectionUtil : DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Host=localhost:5432;" +
                "Username=postgres;" +
                "Password=163098;" +
                "Database=employee_sample";
            optionsBuilder.UseNpgsql(connString);
        }
    }
}
