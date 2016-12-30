using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class apparat
    {
        mixer Mixer;

        public apparat(mixer _mixer)
        {
            Mixer = _mixer;
        }

        public void create_order(Recepie r)
        {
            Console.WriteLine("Готовим " + r.name);
            foreach (var Ingridient in r.Ingridients)
            {
                Mixer.add_ingridient(Ingridient, r.Count[r.Ingridients.IndexOf(Ingridient)]);
            }
            Mixer.Run();
        }
        public bool check_recepie(Recepie r)
        {
            bool state = true;
            foreach (var Ingridient in r.Ingridients)
            {
                if (Ingridient.dispener.current_value < r.Count[r.Ingridients.IndexOf(Ingridient)])
                    state = false;
            }
            return state;
        }
    }
}