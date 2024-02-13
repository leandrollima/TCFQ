using Microsoft.EntityFrameworkCore;
using TCFQ.Domain;

namespace TCFQ.Repository.Context
{
    public class AppDbContext : DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
                
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connectionString = "server=localhost;port=3306;database=tcfq;uid=root;password=root";
        //    if (!optionsBuilder.IsConfigured)
        //        optionsBuilder.UseMySql(connectionString, ServerVersion.Create(
        //                new Version(),
        //                Pomelo.EntityFrameworkCore.MySql.Infrastructure.ServerType.MySql)
        //           );
        //}

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
