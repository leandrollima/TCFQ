using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TCFQ.WF.Configuration;

namespace TCFQ.WF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = ConfigureServices();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Criar o formulário principal e injetar o DbContext
            var mainForm = serviceProvider.GetRequiredService<FrmMain>();
            Application.Run(mainForm);


            //Application.Run(new FrmVideo());
        }

        static IServiceProvider ConfigureServices()
        {
            var configuration = new ConfigurationBuilder().AddJsonFileConfig();

            string connectionString = configuration.GetConnectionString("DefaultConnection")!;
            string mySqlVersion = configuration.GetSection("MySqlVersion").Value!;

            var serviceProvider = new ServiceCollection()
            .AddAppDbContext(connectionString, mySqlVersion)
            .AddTransient<FrmMain>()
            .AddTransient<FrmCorrectionExam>()
            .BuildServiceProvider();

            return serviceProvider;
        }
    }
}