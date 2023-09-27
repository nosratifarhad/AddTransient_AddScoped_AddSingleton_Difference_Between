namespace ServiceLifetimeWebApplication.DependencyInjectionSample.Interfaces;

public interface IExampleTransientService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
}
