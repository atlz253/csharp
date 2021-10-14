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
                Console.WriteLine("3. сварить манты");
                Console.WriteLine("4. съесть манты");
                Console.WriteLine("5. классифицировать манты");
                Console.WriteLine("6. имя класса");
                Console.WriteLine("7. соленые ли манты?");
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
                    case 3:
                        CookMenu();
                        break;
                    case 4:
                        EatMenu();
                        break;
                    case 5:
                        NameMenu();
                        break;
                    case 6:
                        ClassMenu();
                        break;
                    case 7:
                        SaltMenu();
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

            return new Manti();
        }

        public void MantiToString()
        {
            if (obj != null)
                Console.WriteLine(obj);
            else
                Console.WriteLine("У вас нет мант... мантов.... манты?");
        }

        public void CookMenu()
        {
            switch (obj.Cook())
            {
                case 0:
                    Console.WriteLine("Манты сварены и поданы на стол!");
                    break;
                case 1:
                    Console.WriteLine("Где манты, Билли? Где мааанты?");
                    break;
                case 2:
                    Console.WriteLine("Манты разварились! О нет!");
                    break;
            }
        }

        public void EatMenu()
        {
            switch (obj.Eat())
            {
                case 0:
                    Console.WriteLine("Вы съели манты. Не хинкали... Эх, но все же вкусно)");
                    break;
                case 1:
                    Console.WriteLine("Ваши манты не существуют!");
                    break;
                case 2:
                    Console.WriteLine("Никто не захотел есть сырые манты!");
                    break;
            }
        }

        public void NameMenu()
        {
            if (obj != null)
                Console.WriteLine(obj.Name());
            else
                Console.WriteLine("А точно ли это манты? Ты указываешь на пустой стол...");
        }

        public void ClassMenu()
        {
            if (obj != null)
                Console.WriteLine(obj.ToString());
            else
                Console.WriteLine("Ладно, храни свои секреты!");
        }

        public void SaltMenu()
        {
            if (obj != null && obj.Salt)
                Console.WriteLine("Все хорошо! Манты посолены!");
            else if (obj != null)
                Console.WriteLine("Кажется не хватает соли!");
            else
                Console.WriteLine("В мантах не хватает мантов");
        }
    }
}
