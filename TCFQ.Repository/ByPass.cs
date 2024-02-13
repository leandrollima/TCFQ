//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using TCFQ.Repository.Context;

//namespace TCFQ.Repository
//{
//    public class ByPass : IDesignTimeDbContextFactory<AppDbContext>
//    {
//        public AppDbContext CreateDbContext(string[] args)
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
//            optionsBuilder.UseMySql("server=localhost;port=3306;database=tcfq;uid=root;password=root",
//                    ServerVersion.Create(
//                        new Version(),
//                        Pomelo.EntityFrameworkCore.MySql.Infrastructure.ServerType.MySql));
//            return new AppDbContext(optionsBuilder.Options);
//        }
//    }
//}
