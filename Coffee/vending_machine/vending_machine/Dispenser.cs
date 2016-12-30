using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class Dispenser
    {
        public int max_value;
        public int current_value;
        public Dispenser(int max, int current)
        {
            max_value = max;
            current_value = current;
        }
    }
}