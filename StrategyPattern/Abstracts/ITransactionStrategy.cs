using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Abstracts
{
    public interface ITransactionStrategy
    {
        void Execute(TransactionModel model);
    }
}
