namespace ServiceLifetimeWebApplication.DependencyInjectionSample.Interfaces;

public interface IReportServiceLifetime
{
    Guid Id { get; }

    ServiceLifetime Lifetime { get; }
}
