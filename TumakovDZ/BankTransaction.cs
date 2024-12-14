using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovDZ
{
    public class BankTransaction
    {
        public static int count = 1;

        static BankTransaction()
        {
            count ++ ;
            Vuvod() ;
        }
        static int Vuvod()
        {
            return count;
        }
    }
}
