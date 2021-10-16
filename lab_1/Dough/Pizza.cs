using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dough
{
    public class Pizza : IEatable
    {
        public int Dough { get; set; }
        public int PriceOfPizza { get; set; }

        public Pizza()
        {
            Dough = 25;
            PriceOfPizza = 100;
        }

        public Pizza(int ObjDiameter, int ObjPrice)
        {
            Dough = ObjDiameter;
            PriceOfPizza = ObjPrice;
        }

        public void Info()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Диаметр пиццы = {Dough}");
            Console.WriteLine($"Цена = {PriceOfPizza}");
        }

        public int Eat()
        {
            Console.WriteLine("Съеден кусочек пиццы!");

            return 0;
        }

        public int Cook()
        {
            Console.WriteLine("Пицца готова!");

            return 0;
        }

        public override string ToString()
        {
            return "Пицца";
        }
    }
}
