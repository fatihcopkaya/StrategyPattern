using StrategtPatternWithKeyedService.Abstracts;
using StrategtPatternWithKeyedService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategtPatternWithKeyedService.Strategies
{
    public class SaleTransactionStrategy : ITransactionStrategy
    {
        public void Execute(TransactionModel model)
        {
            Console.WriteLine($"{model.TransactionType} İşlemi Başarılı");
        }
    }
}
