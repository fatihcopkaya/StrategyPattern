using StrategyPattern.Abstracts;
using StrategyPattern.Models;
using StrategyPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Factories
{
    public class TransactionFactory
    {
        public static ITransactionStrategy CreateStrategy(string transactionType)
        {
            return transactionType switch
            {
                "Sale" => new SaleTransactionStrategy(),
                "Cancel" => new CancelTransactionStrategy(),
                "Refund" => new RefundTransactionStrategy(),
            };
        }
            


    }
}
