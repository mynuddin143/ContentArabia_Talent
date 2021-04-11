using Content.Talent.DataAccess;
using IO.Swagger.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SE.CAF.CC.Persistance;
using SentinelModRepo.Common;

namespace Content.API
{
    public class CompositionRoot : IDependecyInjection
    {
        public IServiceCollection ApplicationDependency<T>(IServiceCollection collection, IConfiguration Configuration) where T : MsSqlRepository
        {

            collection.AddScoped<IRegistrationApiController>(p => new TalentRegistrationDA(p.GetService<T>()));
            collection.AddTransient<RegistrationApiController>();
            //collection.AddTransient<ConsumerWorker>();
            //collection.AddScoped<Receiver, ConsumerWorker>();
            return collection;
        }
    }
}
