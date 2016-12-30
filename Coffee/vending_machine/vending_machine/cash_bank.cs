using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class cash_bank
    {
        public int User_Money { get; private set; }
        private int Apparat_Money { get; set; }
        public int Apparat_E_Money { get; set; }

        public cash_bank()
        {
            User_Money = 0;
            Apparat_Money = 1000;
            Apparat_E_Money = 1000;
        }
        public void add_apparat_e_money(int count)
        {
            Apparat_E_Money += count;
        }
        public void decrease_apparat_e_money(int count)
        {
            Apparat_E_Money -= count;
        }
        public void add_user_money(int count)
        {
            User_Money += count;
        }
        public void decrease_user_money(int count)
        {
            User_Money -= count;
        }
        public void add_apparat_money(int count)
        {
            Apparat_Money += count;
        }
        public void decrease_apparat_money(int count)
        {
            Apparat_Money -= count;
        }
    }
}