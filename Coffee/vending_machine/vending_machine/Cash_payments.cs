using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class Cash_payments : IPayment
    {
        cash_bank cash;
        modul modul;
        panel panel;
        public Cash_payments(cash_bank _cash, modul _modul, panel _panel)
        {
            modul = _modul;
            cash = _cash;
            panel = _panel;
        }
        public void Option(int summ)
        {
            while (summ > cash.User_Money)
            {
                Console.WriteLine("Пополните счет");
                int z = Convert.ToInt32(Console.ReadLine());
                panel.add_coin(z);
            }

        }
    }
}