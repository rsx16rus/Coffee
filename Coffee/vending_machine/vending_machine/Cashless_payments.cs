using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class Cashless_payments : IPayment
    {
        cash_bank cash;
        modul modul;
        public Cashless_payments(cash_bank _cash, modul _modul)
        {
            cash = _cash;
            modul = _modul;
        }
        public void Option(int summ)
        {
            Console.WriteLine("Оплата картой");
            if (modul.connect_to_Bank("123456789"))
            {
                cash.add_apparat_e_money(summ);
            }

        }
    }
}