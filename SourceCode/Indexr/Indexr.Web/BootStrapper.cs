using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Indexr.Data;
using System.Web.Http;
using Autofac;
using System.Reflection;
using Autofac.Integration.Mvc;
using Indexr.Service;

namespace Indexr.Web
{
    public static class BootStrapper
    {
        public static void Run()
        {
            InitializeAndSeedDb();
            SetIocContainer();
        }

        private static void InitializeAndSeedDb()
        {
            try
            {
                // Initializes and seeds the database.
                Database.SetInitializer(new DbInitializer());

                using (var context = new AppDbContext())
                {
                    context.Database.Initialize(force: true);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private static void SetIocContainer()
        {
            try
            {
                //Implement Autofac

                var configuration = GlobalConfiguration.Configuration;
                var builder = new ContainerBuilder();

                // Register MVC controllers using assembly scanning.
                builder.RegisterControllers(Assembly.GetExecutingAssembly());

                // Register MVC controller and API controller dependencies per request.
                builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerDependency();
                builder.RegisterType<DatabaseFactory>().As<IDatabaseFactory>().InstancePerLifetimeScope();

                // Register service
                builder.RegisterAssemblyTypes(typeof(ProfileService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerDependency();

                // Register repository
                builder.RegisterAssemblyTypes(typeof(ProfileRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerDependency();

                var container = builder.Build();

                //for MVC Controller Set the dependency resolver implementation.
                var resolverMvc = new AutofacDependencyResolver(container);
                System.Web.Mvc.DependencyResolver.SetResolver(resolverMvc);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}