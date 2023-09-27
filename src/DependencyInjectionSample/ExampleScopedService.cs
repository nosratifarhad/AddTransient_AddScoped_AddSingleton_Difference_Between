using ServiceLifetimeWebApplication.DependencyInjectionSample.Interfaces;

namespace ServiceLifetimeWebApplication.DependencyInjectionSample;

internal sealed class ExampleScopedService : IExampleScopedService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}