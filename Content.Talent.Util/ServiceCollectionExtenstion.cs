

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SE.CAF.CC.Persistance;

namespace SentinelModRepo.Common
{
    public interface IDependecyInjection
    {
        IServiceCollection ApplicationDependency<T>(IServiceCollection collection, IConfiguration Configuration) where T : MsSqlRepository;
    }
    public static class ServiceCollectionExtenstion
    {
        public static IServiceCollection AddDependency<T>(this IServiceCollection collection, IConfiguration configuration) where T : IDependecyInjection, new()
        {
            //var iDependecyInjection = new T();
            //collection = iDependecyInjection.ApplicationDependency(collection, configuration);
            //return collection;

            var iDependecyInjection = new T();
            collection = iDependecyInjection.ApplicationDependency<MsSqlRepository>(collection, configuration);
            return collection;
        }
    }
}
