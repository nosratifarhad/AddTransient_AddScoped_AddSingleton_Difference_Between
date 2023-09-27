namespace ServiceLifetimeWebApplication.DependencyInjectionSample.Interfaces;

public interface IExampleSingletonService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
}
