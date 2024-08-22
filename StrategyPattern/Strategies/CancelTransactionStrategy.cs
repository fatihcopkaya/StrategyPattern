using StrategyPattern.Abstracts;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategies
{
    public class CancelTransactionStrategy : ITransactionStrategy
    {
        public void Execute(TransactionModel model)
        {
            Console.WriteLine($"{model.TransactionType} İşlemi Başarılı");
        }
    }
}
