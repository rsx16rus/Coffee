using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class panel
    {
        public modul modul;
        public bool cash;
        public panel(modul _modul)
        {
            modul = _modul;
            cash = true;
        }
        public void payment_option(IPayment op, int _summ)
        {
            op.Option(_summ);
        }

        public void selection_order(int number)
        {

            modul.selection_order(number);
            Console.WriteLine("Выберите способ оплаты");
            Console.WriteLine("1-Наличный, 2- По Карте, 3-отмена");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i == 1)
            {
                payment_option(new Cash_payments(modul.cash_bank, modul, this), modul.Recepies[number].price);
                modul.create_order(number, true);
            }
            else if (i == 2)
            {
                payment_option(new Cashless_payments(modul.cash_bank, modul), modul.Recepies[number].price);
                modul.create_order(number, false);
            }
        }
        public void add_coin(int coin)
        {
            if (cash)
            {
                if ((coin == 1) ||
                    (coin == 2) ||
                    (coin == 5) ||
                    (coin == 10))
                    modul.add_money(coin);
                else
                    Console.WriteLine("Не знаю такую монету");
            }
            else
            {
                modul.output_coin(coin);
            }

        }

        public void output_coin()
        {
            modul.output_coin();
        }
        public void Balans()
        {
            Console.WriteLine("Ваш кредит " + modul.cash_bank.User_Money + " Рублей");
        }
    }
}