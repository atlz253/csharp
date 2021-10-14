using lab_1.Dumpling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Menu
{
    class PelmeniMenu : IDumplingsMenu
    {
        private Pelmeni obj = null;

        public void Init()
        {
            int choice;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Ага попался, любитель настоящих русских пельменей!");
                Console.WriteLine("1. слепить пельмени");
                Console.WriteLine("2. классифицировать пельмени");
                Console.WriteLine("3. сварить пельмени");
                Console.WriteLine("4. пожарить пельмени");
                Console.WriteLine("5. съесть пельмени");
                Console.WriteLine("6. имя класса");
                Console.WriteLine("7. узнать тип мяса");
                Console.WriteLine("0. выход");

                int.TryParse(Console.ReadLine(), out choice);

                Console.Clear();

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        obj = (Pelmeni) Create();
                        break;
                    case 2:
                        NameMenu();
                        break;
                    case 3:
                        CookMenu();
                        break;
                    case 4:
                        FryMenu();
                        break;
                    case 5:
                        EatMenu();
                        break;
                    case 6:
                        ClassMenu();
                        break;
                    case 7:
                        TypeMenu();
                        break;
                }

                Console.ReadKey();
            }
        }

        public Dumplings Create()
        {
            int choice;
            
            while (true)
            {
                Console.WriteLine("Выберите фарш:");
                Console.WriteLine("1. свинина");
                Console.WriteLine("2. говядина");
                Console.WriteLine("3. курица");
                Console.WriteLine("4. индейка");

                int.TryParse(Console.ReadLine(), out choice);
                
                if (choice >= 1 && choice <= 3)
                    return new Pelmeni(choice);
            }
        }

        public void NameMenu()
        {
            if (obj != null)
                Console.WriteLine(obj.Name());
            else
                Console.WriteLine("100% воздуха!");
        }

        public void CookMenu()
        {
            switch (obj.Cook())
            {
                case 0:
                    Console.WriteLine("Сварены вкусные пельмени!");
                    break;
                case 1:
                    Console.WriteLine("Сначала нужно слепить пельмени");
                    break;
                case 2:
                    Console.WriteLine("О нет! Пельмени испортились!");
                    break;
            }
        }

        public void FryMenu()
        {
            switch (obj.Cook())
            {
                case 0:
                    Console.WriteLine("Пожарены вкусные пельмени!");
                    break;
                case 1:
                    Console.WriteLine("О нет! Пельмени испортились!");
                    break;
            }
        }

        public void EatMenu()
        {
            switch (obj.Eat())
            {
                case 0:
                    Console.WriteLine("Пельмени съедены и вы довольны)");
                    break;
                case 1:
                    Console.WriteLine("А где пельмени?");
                    break;
                case 2:
                    Console.WriteLine("Хорошо бы их приготовить...");
                    break;
            }
        }

        public void ClassMenu()
        {
            if (obj != null)
                Console.WriteLine(obj.ToString());
            else
                Console.WriteLine("Ладно, храни свои секреты!");
        }

        public void TypeMenu()
        {
            if (obj != null)
                switch (obj.MeatType)
                {
                    case 1:
                        Console.WriteLine("Свинина");
                        break;
                    case 2:
                        Console.WriteLine("Говядина");
                        break;
                    case 3:
                        Console.WriteLine("Курица");
                        break;
                    case 4:
                        Console.WriteLine("Индейка");
                        break;
                }
            else
                Console.WriteLine("Void");
        }
    }
}
