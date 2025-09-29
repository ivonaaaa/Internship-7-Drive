using DumpDrive.Data;
using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Factories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DumpDrive
{
    class Program
    {

        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddScoped<DumpDriveDbContext>(provider =>
            {
                var factory = new DumpDriveDbContextFactory();
                return factory.CreateDbContext(args: new string[0]);
            });

            services.AddScoped<UserRepository>();
            services.AddScoped<DriveRepository>();
            services.AddScoped<SharedRepository>();

            services.AddScoped<LoginAndRegistration>();
            services.AddScoped<MainMenu>();

            var serviceProvider = services.BuildServiceProvider();

            var homePageFactory = serviceProvider.GetRequiredService<LoginAndRegistration>();
            var homePage = homePageFactory.CreateLoginAndRegisterMenu();
            homePage.Execute();
        }
    }
}
