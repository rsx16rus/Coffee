using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            mixer mx1 = new mixer();
            cash_bank c1 = new cash_bank();
            apparat a1 = new apparat(mx1);
            modul m1 = new modul(a1, c1);
            panel p1 = new panel(m1);

            Ingridient coffe = new Ingridient("Coffe", new Dispenser(100, 100));
            Ingridient milk = new Ingridient("milk", new Dispenser(100, 100));
            Ingridient cup = new Ingridient("Cup", new Dispenser(100, 100));
            Ingridient sugar = new Ingridient("sugar", new Dispenser(100, 100));
            Ingridient water = new Ingridient("Water", new Dispenser(100, 100));
            Ingridient maggi = new Ingridient("Maggi", new Dispenser(100, 100));


            m1.Recepies.Add(new Recepie("black coffe"
                , new List<Ingridient>() { cup, coffe, water }
                , new List<int>() { 1, 1, 10 }, 35));

            m1.Recepies.Add(new Recepie("Black Coffee+sugar"
                , new List<Ingridient>() { cup, coffe, sugar, water }
                , new List<int>() { 1, 1, 1, 10 }, 35));

            m1.Recepies.Add(new Recepie("White Coffe"
                , new List<Ingridient>() { cup, coffe, milk, water }
                , new List<int>() { 1, 1, 1, 10 }, 35));

            m1.Recepies.Add(new Recepie("White Coffe+ Sugar"
                , new List<Ingridient>() { cup, coffe, milk, sugar, water }
                , new List<int>() { 1, 1, 1, 1, 10 }, 35));

            m1.Recepies.Add(new Recepie("Maggi"
                , new List<Ingridient>() { maggi, water }
                , new List<int>() { 1, 10 }, 25));

            p1.Balans();
            p1.modul.check_recepies();

            Console.WriteLine("Сделай заказ");
            int z = Convert.ToInt32(Console.ReadLine());
            p1.selection_order(z);

            Console.ReadLine();

        }
    }
}
