using lab_1.Dumpling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Menu
{
    class MantiMenu : IDumplingsMenu
    {
        private Manti obj = null;

        public void Init()
        {
            int choice;

             while (true)
            {
                Console.Clear();

                Console.WriteLine("А чем манты отличаются от хинкалей?! Ну ладно... Добавим специй)");
                Console.WriteLine("1. создать манты");
                Console.WriteLine("2. глянуть на манты");
                Console.WriteLine("0. выход");

                int.TryParse(Console.ReadLine(), out choice);

                Console.Clear();

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        obj = (Manti) Create();
                        break;
                    case 2:
                        MantiToString();
                        break;
                }

                Console.ReadKey();
            }
        }

        public Dumplings Create()
        {
            int choice;

            Console.WriteLine("Повар вызван на кухню и готов творить. У вас странное чувство. Не видели ли вы этого повара раньше?");
            Console.WriteLine("Ваши поручения, шеф:");
            Console.WriteLine("1. вложи в эти манты свою душу");
            Console.WriteLine("2. я подберу приправы и вес");
            Console.WriteLine("3. отойди от плиты, я все сделаю самостоятельно");

            int.TryParse(Console.ReadLine(), out choice);

            Console.Clear();

            if (choice == 1)
            {
                Console.WriteLine("Я вложил в эти манты... Стоп, это была моя фраза!");
                return new Manti();
            }
            else if (choice == 2)
            {
                double weight;

                bool salt = false,
                pepper = false,
                paprika = false,
                karri = false;

                while (true)
                {
                    Console.WriteLine("Вы подходите к набору специй, там всего 3 солонки! Будем как то выкручиваться:");
                    Console.WriteLine("1. Посолить");
                    Console.WriteLine("2. Поперчить");
                    Console.WriteLine("3. Добавить паприки");
                    Console.WriteLine("4. Достать из своего потайного кармана карри");
                    Console.WriteLine("0. Приемлемое количество специй");

                    int.TryParse(Console.ReadLine(), out choice);

                    if (choice == 0)
                        break;

                    switch (choice)
                    {
                        case 1:
                            if (!salt)
                            {
                                salt = true;

                                Console.WriteLine("Соль успешно добавлена!");
                            }
                            else
                            {
                                Console.WriteLine("Нет нет! Сегодня не пересаливаем манты!");
                            }
                            break;
                        case 2:
                            if (!pepper)
                            {
                                pepper = true;

                                Console.WriteLine("Вы добавили немного перца");
                            }
                            else
                            {
                                Console.WriteLine("Больше перца богу перца!");
                            }
                            break;
                        case 3:
                            if (!paprika)
                            {
                                paprika = true;

                                Console.WriteLine("Вы добавили паприку в фарш");
                            }
                            else
                            {
                                Console.WriteLine("Больше паприки хочется...");
                            }
                            break;
                        case 4:
                            if (!karri)
                            {
                                karri = true;

                                Console.WriteLine("Вы достаете из потайного кармана склянку с секретной специей");
                            }
                            else
                            {
                                Console.WriteLine("Карри закончился :'(");
                            }
                            break;
                    }
                }

                Console.Write("Хочу, чтобы весил он примерно: ");
                double.TryParse(Console.ReadLine(), out weight);

                return new Manti(weight, salt, pepper, paprika, karri);
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

        public void MantiToString()
        {
            if (obj != null)
                Console.WriteLine(obj);
            else
                Console.WriteLine("У вас нет мант... мантов.... манты?");
        }

        public void EatMenu()
        {

        }
    }
}
