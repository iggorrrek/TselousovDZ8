using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovDZ
{
    public class BankTransaction
    {
        private static int transactionCount = 0;

        public BankTransaction()
        {
            transactionCount++;
        }

        public static int GetTransactionCount()
        {
            return transactionCount;
        }
    }
}
