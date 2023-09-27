﻿namespace ServiceLifetimeWebApplication.DependencyInjectionSample.Interfaces;

public interface IExampleScopedService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
}
