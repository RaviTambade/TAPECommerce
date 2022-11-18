using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovtLib
{
    //Hollywood design principle
    public  class TaxManager
    {
        public void DeductIncomeTax()
        {
            Console.WriteLine("25 % Income tax has been deducted from your account...");
        }

        public void DeductServiceTax()
        {
            Console.WriteLine("Service tax has been deducted from your account...");
        }
        public void DeductTDS()
        {
            Console.WriteLine("TDS tax has been deducted from your account...");
        }
    }
}
