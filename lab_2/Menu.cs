using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Menu
    {
        public static void Init(LinkedList<Sportsmen> list)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Отображение содержимого списка");
                Console.WriteLine("2. Добавление нового элемента");
                Console.WriteLine("3. Удаление элемента с указанным индексом");
                Console.WriteLine("4. Корректировка элемента");
                Console.WriteLine("5. Работа с коллекцией");
                Console.WriteLine("0. Выход");

                int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        ListMenu(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        AddMenu(list);
                        break;
                    case 3:
                        RemoveMenu(list);
                        break;
                    case 4:
                        EditMenu(list);
                        break;
                    case 5:
                        FindMenu(list);
                        break;

                }
            }
        }

        public static void ListMenu(LinkedList<Sportsmen> list)
        {
            int count = 1;
            Console.WriteLine("╔═══════╦════════════════╦══════════════╦════════════════╦════════════════╦══════════════╗");
            Console.WriteLine("║   №   ║    Фамилия     ║     Пол      ║   Вид спорта   ║  Год рождения  ║     Рост     ║");

            if (list.Count > 0)
                Console.WriteLine("╠═══════╬════════════════╬══════════════╬════════════════╬════════════════╬══════════════╣");
            else
                Console.WriteLine("╚═══════╩════════════════╩══════════════╩════════════════╩════════════════╩══════════════╝");

            foreach (Sportsmen item in list)
            {
                Console.WriteLine($"║   {count,-4}║    {item.LastName,-11} ║     {item.Gender,-8} ║   {item.Sport,-11}  ║  {item.BirthdayYear,-12}  ║     {item.Height,-7}  ║");

                if (item != list.Last())
                    Console.WriteLine("╠═══════╬════════════════╬══════════════╬════════════════╬════════════════╬══════════════╣");
                else
                    Console.WriteLine("╚═══════╩════════════════╩══════════════╩════════════════╩════════════════╩══════════════╝");
                count++;
            }
        }

        public static void AddMenu(LinkedList<Sportsmen> list)
        {
            Sportsmen temp_1 = new Sportsmen();
            Sportsmen temp_2 = new Sportsmen();

            Console.WriteLine("Куда вы хотите добавить новый элемент:");
            Console.WriteLine("1. В начало\n2. В конец\n3. В произвольное место");
            int.TryParse(Console.ReadLine(), out int menu_1);
            switch (menu_1)
            {
                case 1:
                    temp_1.ReadInfo();
                    list.AddFirst(temp_1);
                    Console.Clear();
                    break;
                case 2:
                    temp_1.ReadInfo();
                    list.AddLast(temp_1);
                    Console.Clear();
                    break;
                case 3:
                    if (list.Count != 0)
                    {
                        int count = 1;

                        Console.Clear();
                        Console.WriteLine("После какого элемента вы хотите добавить новый элемент:");
                        ListMenu(list);

                        int.TryParse(Console.ReadLine(), out int menu_2);

                        temp_1.ReadInfo();
                        foreach (Sportsmen man in list)
                        {
                            if (count == menu_2)
                            {
                                temp_2 = man;
                            }
                            count++;
                        }
                        list.AddAfter(list.Find(temp_2), temp_1);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Список пуст");
                    }
                    break;
            }
        }

        public static void RemoveMenu(LinkedList<Sportsmen> list)
        {
            int count = 1;

            Console.Clear();
            Console.WriteLine("Какой элемент вы хотите удалить:");
            ListMenu(list);

            int.TryParse(Console.ReadLine(), out int menu);

            foreach (Sportsmen man in list.ToArray())
            {
                if (count == menu)
                {
                    list.Remove(man);
                    break;
                }
                count++;
            }
        }

        public static void EditMenu(LinkedList<Sportsmen> list)
        {
            int count = 1;
            Sportsmen temp_man = new Sportsmen();

            Console.Clear();
            Console.WriteLine("Какой элемент вы хотите скорректировать:");
            ListMenu(list);

            int.TryParse(Console.ReadLine(), out int menu_1);

            foreach (Sportsmen man in list.ToArray())
            {
                if (count == menu_1)
                {
                    if (list.Find(man) != null)
                    {
                        temp_man = man;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                        return;
                    }
                }
                count++;
            }

            Console.Clear();
            Console.WriteLine("Какое поле вы хотите корректировать:\n1. Фамилия\n2. Пол\n3. Вид спорта\n4. Год рождения\n5. Рост");

            int.TryParse(Console.ReadLine(), out int menu_2);

            switch (menu_2)
            {
                case 1:
                    Console.WriteLine($"Текущее значение: {temp_man.LastName}");
                    Console.WriteLine("Введите новое значение: ");
                    temp_man.LastName = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine($"Текущее значение: {temp_man.Gender}");
                    Console.WriteLine("Введите новое значение: ");
                    temp_man.Gender = Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine($"Текущее значение: {temp_man.Sport}");
                    Console.WriteLine("Введите новое значение: ");
                    temp_man.Sport = Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine($"Текущее значение: {temp_man.BirthdayYear}");
                    Console.WriteLine("Введите новое значение: ");
                    do
                    {
                        try
                        {
                            temp_man.BirthdayYear = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка чтения, введите целое число");
                        }
                    } while (true);
                    break;

                case 5:
                    Console.WriteLine($"Текущее значение: {temp_man.Height}");
                    Console.WriteLine("Введите новое значение: ");
                    do
                    {
                        try
                        {
                            temp_man.Height = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка чтения, введите целое число");
                        }
                    } while (true);
                    break;
            }

            foreach (Sportsmen man in list)
            {
                if (count == menu_1)
                {
                    if (list.Find(man) != null)
                    {
                        list.Find(man).Value = temp_man;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                        return;
                    }
                }
                count++;
            }

            Console.Clear();
        }

        public static Sportsmen? GetHighestSwimmer(LinkedList<Sportsmen> list)
        {
            Sportsmen hightestSwimmer = new Sportsmen();

            foreach (Sportsmen man in list)
            {
                if (man.Sport.ToLower() == "плавание" && man.Height > hightestSwimmer.Height)
                {
                    hightestSwimmer = man;
                }
            }
            if (hightestSwimmer.Height == 0)
                return null;
            return hightestSwimmer;
        }

        public static LinkedList<Sportsmen> GetJuniorSportsmen(LinkedList<Sportsmen> list)
        {
            int currentYear = DateTime.Now.Year;
            LinkedList<Sportsmen> juniorList = new LinkedList<Sportsmen>();

            foreach (Sportsmen man in list)
            {
                if ((currentYear - man.BirthdayYear) <= 17 && (currentYear - man.BirthdayYear) >= 14)
                {
                    juniorList.AddLast(man);
                }
            }
            return juniorList;
        }

        public static void FindMenu(LinkedList<Sportsmen> list)
        {
            Console.WriteLine("1. Найти самого высокого спортсмена, занимающегося плаванием, среди мужчин.");
            Console.WriteLine("2. Вывести сведения о спортсменках, выступающих в юниорском разряде(14 - 17лет).");

            int.TryParse(Console.ReadLine(), out int choice);
            Console.Clear();

            switch (choice)
            {
                case 1:
                    if (GetHighestSwimmer(list) != null)
                    {
                        Console.WriteLine("Самый высокий пловец:");
                        Console.WriteLine($"{GetHighestSwimmer(list).Value.LastName},  Рост: {GetHighestSwimmer(list).Value.Height}");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    ListMenu(Menu.GetJuniorSportsmen(list));
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}
