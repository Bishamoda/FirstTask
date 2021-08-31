using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_calc
{
    class Values
    {
        private decimal _numb;

        public decimal Numb { get { return _numb; } set { _numb = value; } }

        public bool SetNumbMethod()
        {
            Console.WriteLine("Enter your number: ");

            if (decimal.TryParse(Console.ReadLine(), out _numb))
            {
                Numb = _numb;
                return true;
            }
            Console.WriteLine("Its not a number! Try again.");
            return false;
        }

    }
}
