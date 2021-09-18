using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class KhinkaliMenu
    {
        private Khinkali obj = null;

        public void Init()
        {
            int choice;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("\"Пельмени! Хорошие пельмени это очень вкусно! На самом деле рецепт простой: много мяса, мало теста\" @ Floppa\n");
                Console.WriteLine("1. Создать хинкали");
                Console.WriteLine("2. Досье на хинкали");
                Console.WriteLine("0. Выход");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        obj = KhinkaliCreate();
                        break;
                    case 2:
                        if (obj != null)
                            Console.WriteLine(obj);
                        else
                            Console.WriteLine("У вас нет хинкалей! ахаха");

                        Console.ReadLine();
                        break;
                }
            }
            
        }

        public Khinkali KhinkaliCreate()
        {
            int choice;

            Console.WriteLine("Повар вызван на кухню и готов творить. Ваши поручения, шеф:");
            Console.WriteLine("1. удиви меня");
            Console.WriteLine("2. у меня появилась новая формула хинкалей!");
            Console.WriteLine("3. отойди от плиты, я все сделаю самостоятельно");

            int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                return new Khinkali();
            }
            else if (choice == 2)
            {
                int meat;
                double weight;

                Console.Write("Слушай, как тебе идея сделать процент мяса по отношению к тесту равным: ");
                int.TryParse(Console.ReadLine(), out meat);
                Console.Write("Хочу, чтобы весил он примерно: ");
                double.TryParse(Console.ReadLine(), out weight);

                return new Khinkali(meat, weight);
            }
            else if (choice == 3)
            {
                int meat;
                double weight;
                int foldNum;

                Console.Write("Вы подошли к рабочему месту и готовы творить. После недолгих раздумий вы решаете сделать процент мяса по отшношению к тесту: ");
                int.TryParse(Console.ReadLine(), out meat);
                Console.Write("Вы представляете размер вашего творения, предположительно он будет весить:");
                double.TryParse(Console.ReadLine(), out weight);
                Console.Write("Вы - истинный шеф повар. После 10 лет обучения в одном храме Пекина вы познали дзен и секретную формулу хинкалей \"дракона\", у которых складок ровно:");
                int.TryParse(Console.ReadLine(), out foldNum);

                return new Khinkali(meat, weight, foldNum);
            }

            return new Khinkali();
        }
    }
}
