using lab_3.Dough;
using lab_3.Dumpling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Menu
{
    class ListMenu
    {
        List<IEatable> list = new List<IEatable>();

        public void Init()
        {
            int choice;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Добавить элемент в список");
                Console.WriteLine("2. Вывод свойств объекта из списка");
                Console.WriteLine("3. Приготовить что-то из списка");
                Console.WriteLine("4. Съесть что-то из списка");
                Console.WriteLine("5. Вывод объектов списка");
                Console.WriteLine("6. Угостить друга");
                Console.WriteLine("7. Удалить блюдо из списка");
                Console.WriteLine("8. Швырнуть тарелку! (вызов метода Dispose)");
                Console.WriteLine("9. Попросить позвать сборщика мусора");
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
                    case 3:
                        CookMenu();
                        break;
                    case 4:
                        EatMenu();
                        break;
                    case 5:
                        ObjectsMenu();
                        break;
                    case 6:
                        FriendMenu();
                        break;
                    case 7:
                        DeleteMenu();
                        break;
                    case 8:
                        DisposeMenu();
                        break;
                    case 9:
                        GCMenu();
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
            int index;

            Console.Write("Введите индекс объекта: ");

            int.TryParse(Console.ReadLine(), out index);

            try
            {
                list[index].Info();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введен неверный индекс!");
            }
        }

        public void InfoMenu()
        {
            int index;

            Console.Write("Введите индекс объекта: ");

            int.TryParse(Console.ReadLine(), out index);

            try
            {
                list[index].Info();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введен неверный индекс!");
            }
        }

        public void CookMenu()
        {
            int index;

            Console.Write("Введите индекс объекта: ");

            int.TryParse(Console.ReadLine(), out index);

            try
            {
                list[index].Cook();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введен неверный индекс!");
            }
        }

        public void EatMenu()
        {
            int index;

            Console.Write("Введите индекс объекта: ");

            int.TryParse(Console.ReadLine(), out index);

            try
            {
                list[index].Eat();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введен неверный индекс!");
            }
        }

        public void ObjectsMenu()
        {
            int count = 0;

            foreach (IEatable item in list)
            {
                Console.Write($"{count}. ");
                item.Info();
                Console.Write("\n");
                count++;
            }
        }

        public void ProzhorliviyDrug(IEatable eda)
        {
            Console.WriteLine("Я создам идеальное общество, где никто не будет голодным!");
            eda.Cook();
            eda.Eat();
        }

        public void FriendMenu()
        {
            int index;

            Console.Write("Введите индекс объекта, которым угостим друга: ");

            int.TryParse(Console.ReadLine(), out index);

            try
            {
                ProzhorliviyDrug(list[index]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введен неверный индекс!");
            }
        }

        public void DeleteMenu()
        {
            Console.WriteLine("Какой элемент удаляем: ");
            ObjectsMenu();

            int.TryParse(Console.ReadLine(), out int index);

            try
            {
                list.Remove(list[index]);

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введен неверный индекс!");
            }
        }

        public void DisposeMenu()
        {
            Console.WriteLine("Выберите элемент: ");
            ObjectsMenu();

            ObjectsMenu();

            int.TryParse(Console.ReadLine(), out int index);

            try
            {
                IDisposable tmp = (IDisposable)list[index];
                tmp.Dispose();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введен неверный индекс!");
            }
        }

        public void GCMenu()
        {
            GC.Collect();

            Console.WriteLine("Был вызван сборщик мусора");
        }
    }
}
