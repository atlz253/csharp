using lab_1.Dough;
using lab_1.Dumpling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Menu
{
    class ListMenu
    {
        List<IEatable> list = new List<IEatable>();

        public void Init()
        {
            int choice;

            while (true)
            {
                Console.WriteLine("1. Добавить элемент в список");
                Console.WriteLine("2. Вывод свойств объекта из списка");
                Console.WriteLine("3. Выполнение методов объекта из списка");
                Console.WriteLine("4. Вывод объектов списка");
                Console.WriteLine("5. Без разницы что, дайте мне это съесть!");
                Console.WriteLine("0. Выход");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        AddMenu();
                        break;
                    case 2:
                        PropertyMenu();
                        break;
                }

                Console.ReadKey();
            }
        }

        public void AddMenu()
        {
            int choice;

            Console.WriteLine("1. Хинкали");
            Console.WriteLine("2. Манты");
            Console.WriteLine("3. Пельмени");
            Console.WriteLine("4. Вареники");
            Console.WriteLine("5. Пицца");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    list.Add(new Khinkali());
                    break;
                case 2:
                    list.Add(new Manti());
                    break;
                case 3:
                    list.Add(new Pelmeni());
                    break;
                case 4:
                    list.Add(new Vareniki());
                    break;
                case 5:
                    list.Add(new Pizza());
                    break;
            }
        }

        public void PropertyMenu()
        {
            foreach (IEatable item in list)
            {
                item.Info();
                Console.Write("\n");
            }
        }
    }
}
