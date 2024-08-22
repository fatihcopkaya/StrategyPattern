




using Microsoft.Extensions.DependencyInjection;
using StrategtPatternWithKeyedService.Abstracts;
using StrategtPatternWithKeyedService.IOC;
using StrategtPatternWithKeyedService.Models;

var serviceProvider = new ServiceCollection()
    .AddStrategyServices() 
    .BuildServiceProvider();


var type = Console.ReadLine();
TransactionModel model = new TransactionModel()
{
    TransactionType = type
};

var strategy = serviceProvider.GetKeyedService<ITransactionStrategy>(model.TransactionType);
strategy.Execute(model);

Console.ReadLine();