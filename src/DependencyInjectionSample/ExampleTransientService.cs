using ServiceLifetimeWebApplication.DependencyInjectionSample.Interfaces;

namespace ServiceLifetimeWebApplication.DependencyInjectionSample;

internal sealed class ExampleTransientService : IExampleTransientService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}