using Microsoft.Extensions.DependencyInjection;
using StrategtPatternWithKeyedService.Abstracts;
using StrategtPatternWithKeyedService.Strategies;

namespace StrategtPatternWithKeyedService.IOC
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddStrategyServices(this IServiceCollection services)
        {
            services.AddKeyedTransient<ITransactionStrategy, SaleTransactionStrategy>("Sale");
            services.AddKeyedTransient<ITransactionStrategy, CancelTransactionStrategy>("Cancel");
            services.AddKeyedTransient<ITransactionStrategy, RefundTransactionStrategy>("Refund");

            return services;
        }

    }
}
