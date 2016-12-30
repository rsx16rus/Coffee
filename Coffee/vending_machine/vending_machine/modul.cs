using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class modul
    {
        public List<Recepie> Recepies = new List<Recepie>();

        public apparat apparat;
        public cash_bank cash_bank;

        public modul(apparat _apparat, cash_bank _cash_bank)
        {
            apparat = _apparat;
            cash_bank = _cash_bank;
        }
        public void selection_order(int number)
        {
            Console.WriteLine("К оплате " + Recepies[number].price + " Рублей");

        }
        public void create_order(int number, bool state)
        {
            if (state)
            {
                apparat.create_order(Recepies[number]);
                cash_bank.decrease_user_money(Recepies[number].price);
                output_coin();
            }
            else
            {
                apparat.create_order(Recepies[number]);
            }
        }
        public void check_recepies()
        {
            foreach (var recept in Recepies)
            {
                if (apparat.check_recepie(recept))
                    Console.WriteLine("Рецепт " + recept.name + " доступен ");
                else
                    Console.WriteLine("Рецепт " + recept.name + " недоступен ");
            }
        }
        public void add_money(int count)
        {
            cash_bank.add_user_money(count);
            Console.WriteLine("Пополнение баланса на " + count + " рублей");
        }
        public void output_coin()
        {
            Console.WriteLine("Выдача сдачи " + cash_bank.User_Money + " рублей");
            cash_bank.decrease_user_money(cash_bank.User_Money);

        }
        //Сброс денег без пользователя например если пополняем счет при выборе безналичного рассчета
        public void output_coin(int coin)
        {
            Console.WriteLine("Выдача сдачи " + coin + " рублей");
        }
        public bool connect_to_Bank(string number_card)
        {
            Console.WriteLine("Соединение с банком");
            Console.WriteLine("Ожидание ответа");
            if (response_request())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool response_request()
        {
            Console.WriteLine("Успешно");
            return true;
        }
    }
}