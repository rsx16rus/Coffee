using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class mixer
    {
        public void add_ingridient(Ingridient I, int count)
        {
            I.dispener.current_value = I.dispener.current_value - count;
        }
        public void Run()
        {
            Console.WriteLine("Напиток готов");
        }
    }
}