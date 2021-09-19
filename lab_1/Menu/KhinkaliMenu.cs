using lab_1.Dumplings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Menu
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
                Console.WriteLine("1. Создать хинкали [задание параметров конструируемого объекта]");
                Console.WriteLine("2. Досье на хинкали [вывод свойств объекта]");
                Console.WriteLine("3. Получить идеальное соотношение хинкалей [выполнение статического метода]");
                Console.WriteLine("4. Сварить хинкали");
                Console.WriteLine("5. Съесть хинкали");
                Console.WriteLine("6. Получить соотношение мяса и теста");
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
                        KhinkaliToString();
                        break;
                    case 3:
                        IdealRatioMenu();
                        break;
                    case 4:
                        CookMenu();
                        break;
                    case 5:
                        EatMenu();
                        break;
                    case 6:
                        RatioMenu();
                        break;
                    default:
                        ErrorMenu();
                        break;
                }

                Console.ReadKey();
            }

        }

        private Khinkali KhinkaliCreate()
        {
            int choice;

            Console.WriteLine("Повар вызван на кухню и готов творить. Ваши поручения, шеф:");
            Console.WriteLine("1. удиви меня");
            Console.WriteLine("2. у меня появилась новая формула хинкалей!");
            Console.WriteLine("3. отойди от плиты, я все сделаю самостоятельно");

            int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                Console.WriteLine("Я вложил в эти хинкали свою душу, шеф <3");
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

        private void KhinkaliToString()
        {
            if (obj != null)
                Console.WriteLine(obj);
            else
                Console.WriteLine("У вас нет хинкалей! ахаха");
        }

        private void IdealRatioMenu()
        {
            int[] ratio = Khinkali.IdealRatio();
            Console.WriteLine($"Идеальное соотношение для хинкалей: {ratio[0]}% мяса и {ratio[1]}% теста. Такая формула позволяет остаться хинкалям сочными и не развариться из-за недостатка теста.");
        }

        private void CookMenu()
        {
            if (obj != null && obj.Exist)
            {
                int result = obj.Cook();

                switch (result)
                {
                    case 0:
                        Console.WriteLine("Хинкали сварены, шеф!");
                        break;
                    case 1:
                        Console.WriteLine("Все таки это была плохая идея сварить их снова... Никто не хочет кашу из хинкалей?");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Шеф, случилось ужасное! Я не могу в это поверить! У нас закончились хинкали в холодильнике!");
            }
        }

        private void EatMenu()
        {
            if (obj != null)
            {
                int result = obj.Eat();

                switch (result)
                {
                    case 0:
                        Console.WriteLine("Хинкали получились ооочень вкусные!");
                        break;
                    case 1:
                        Console.WriteLine("Подождите... Я же их уже съел :(");
                        break;
                    case 2:
                        Console.WriteLine("Неплохо было бы их сначала сварить)");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Что-то я начал часто забывать... Хм, вроде бы чтобы съесть хинкали их нужно слепить. Точно!");
            }
        }

        private void ErrorMenu()
        {
            Console.WriteLine("Я ограничен технологиями своего времени. Новых взаимодействия с хинкалями еще не изобрели ;(");
        }

        private void RatioMenu()
        {
            if (obj != null && obj.Exist)
            {
                int[] ratio = obj.Ratio();

                Console.WriteLine($"Вы определили на глаз, что соотношение хинкалей: {ratio[0]}% мяса и {ratio[1]}% теста.");
            }
            else
            {
                Console.WriteLine("Примерно 100% пустоты");
            }
        }
    }
}
