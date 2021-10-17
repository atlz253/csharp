using System;

namespace lab_3.Dough
{
    public class Pizza : IEatable, IDisposable
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
            Console.WriteLine($"Поколение: {GC.GetGeneration(this)}");
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

        ~Pizza()
        {
            Console.WriteLine("Был вызван деструктор класса Pizza");
            Console.ReadKey();
            Console.Clear();
        }

        public void Dispose()
        {
            Console.WriteLine("Был вызван метод Dispose класса Pizza");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
