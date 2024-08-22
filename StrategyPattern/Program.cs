



using StrategyPattern.Factories;
using StrategyPattern.Models;

var type = Console.ReadLine();
TransactionModel model = new TransactionModel()
{
    TransactionType = type
};
var strategy = TransactionFactory.CreateStrategy(model.TransactionType);
strategy.Execute(model);

Console.ReadLine();