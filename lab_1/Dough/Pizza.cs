using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dough
{
    public class Pizza : IEatable
    {
        public int Diameter { get; set; }
        public int PriceOfPizza { get; set; }



        public Pizza(int ObjDiameter, int ObjPrice)
        {
            Diameter = ObjDiameter;
            PriceOfPizza = ObjPrice;
        }

        public void Info()
        {
            Console.WriteLine($"Диаметр пиццы = {Diameter}");
            Console.WriteLine($"Цена = {PriceOfPizza}");
        }

        public override string ToString()
        {
            return "{PriceOFPizza}";
        }

        public int Eat()
        {
            Console.WriteLine("Съеден кусочек пиццы!");

            return 0;
        }

        public void Bake()
        {
            Console.WriteLine("Пицца готова!");
        }
    }
}
