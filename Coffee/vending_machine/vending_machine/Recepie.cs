using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class Recepie
    {
        public string name { get; set; }
        public List<Ingridient> Ingridients { get; set; }
        public List<int> Count { get; set; }
        public int price { get; set; }

        public Recepie(string _name, List<Ingridient> _Ingridients, List<int> _Count, int _price)
        {
            if (string.IsNullOrEmpty(_name))
                throw new ArgumentException("Name cannot be null/empty ", nameof(_name));
            name = _name;
            Ingridients = _Ingridients;
            Count = _Count;
            price = _price;
        }
    }
}