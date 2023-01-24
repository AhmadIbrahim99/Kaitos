using AutoMapper;
using Kaitos.Data.DataBaseContext;
using Kaitos.Data.Mapper;
using Kaitos.Manager;
using Kaitos.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Kaitos.Data.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.AddDbContext<KatiosDbContext>(options =>
            {
                options.UseSqlServer(configurationManager.GetConnectionString("DefaultConnection"));
            });
            services.AddSingleton(
                        new MapperConfiguration(
                        cfg => { cfg.AddProfile(new Mapping()); }
                        ).
                        CreateMapper()
                        );
            services.AddMemoryCache();
            services.AddSession();
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddUserManager<ApplicationUserManager>()
               .AddEntityFrameworkStores<KatiosDbContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });
            return services;
        }

        public static void AddDependencyInjection(this IServiceCollection services)
        {
            Assembly assembly = typeof(DependencyInjection).GetTypeInfo().Assembly;


            var allRepositroies = assembly.GetTypes().
                Where(type => type.Name.EndsWith("Repository")
                && !type.Name.Contains("BaseEntity"));

            foreach (var repository in allRepositroies)
            {
                if (repository.IsGenericType) return;
                Console.WriteLine($"{repository.FullName} 1");
                var allInterface = repository.GetInterfaces();
                var mainInterFace = allInterface.Except(allInterface.SelectMany(i => i.GetInterfaces()));
                foreach (var iRepository in mainInterFace)
                {
                    if (iRepository.IsGenericType) return;
                    Console.WriteLine($"{iRepository.FullName} 2");
                    services.AddScoped(iRepository, repository);
                }
            }

        }

        public static void AddDependencyInjectionForServices(this IServiceCollection services)
        {
            Assembly assembly = typeof(DependencyInjection).GetTypeInfo().Assembly;
            var allServices = assembly.GetTypes().
                Where(type => type.Name.EndsWith("Service"));
            Console.WriteLine("asdlhasdbasd");
            foreach (var service in allServices)
            {
                Console.WriteLine($"{service.FullName} 1");
                var allInterface = service.GetInterfaces();
                var mainInterFace = allInterface.Except(allInterface.SelectMany(i => i.GetInterfaces()));
                foreach (var iService in mainInterFace)
                {
                    Console.WriteLine($"{iService.FullName} 2");
                    services.AddTransient(iService, service);
                }
            }
        }
    }
}

