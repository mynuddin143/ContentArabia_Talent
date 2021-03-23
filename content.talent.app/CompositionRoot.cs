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

            //collection.AddScoped<IUsersRepository>(p => new UsersDA(p.GetService<T>()));
            //collection.AddTransient<UserApiController>();
            //collection.AddTransient<ConsumerWorker>();
            //collection.AddScoped<Receiver, ConsumerWorker>();
            return collection;
        }
    }
}
