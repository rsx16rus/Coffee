using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class Ingridient
    {
        public string name { get; set; }
        public Dispenser dispener { get; set; }

        public Ingridient(string _name, Dispenser _dispenser)
        {
            if (string.IsNullOrEmpty(_name))
                throw new ArgumentException("Name cannot be null/empty ", nameof(_name));
            name = _name;
            dispener = _dispenser;
        }
    }
}