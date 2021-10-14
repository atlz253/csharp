using lab_1.Dumpling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Menu
{
    class VarenikiMenu : IDumplingsMenu
    {
        private Vareniki obj = null;

        public void Init()
        {

            int choice;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. слепить вареники");
                Console.WriteLine("2. классифицировать вареники");
                Console.WriteLine("3. сварить вареники");
                Console.WriteLine("4. съесть вареники");
                Console.WriteLine("5. сладкая ли начинка?");
                Console.WriteLine("0. выход");

                int.TryParse(Console.ReadLine(), out choice);

                Console.Clear();

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        obj = (Vareniki)Create();
                        break;
                    case 2:
                        NameMenu();
                        break;
                    case 3:
                        CookMenu();
                        break;
                    case 4:
                        EatMenu();
                        break;
                    case 5:
                        SweetMenu();
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
                Console.WriteLine("Выберите начинку:");
                Console.WriteLine("1. варенье");
                Console.WriteLine("2. картошка");
                Console.WriteLine("3. творог");

                int.TryParse(Console.ReadLine(), out choice);

                if (choice >= 0 && choice <= 2)
                    return new Vareniki(choice);
            }
        }

        public void CookMenu()
        {
            switch (obj.Cook())
            {
                case 0:
                    Console.WriteLine("Сварены вкусные вареники!");
                    break;
                case 1:
                    Console.WriteLine("Сначала нужно слепить вареники");
                    break;
                case 2:
                    Console.WriteLine("О нет! Вареники испортились!");
                    break;
            }
        }

        public void EatMenu()
        {
            switch (obj.Eat())
            {
                case 0:
                    Console.WriteLine("Очень вкусные вареники были съедены");
                    break;
                case 1:
                    Console.WriteLine("АААА! Вареники пропали!");
                    break;
                case 2:
                    Console.WriteLine("Хорошо бы их приготовить...");
                    break;
            }
        }

        public void NameMenu()
        {
            if (obj != null)
                Console.WriteLine(obj.Name());
            else
                Console.WriteLine("100% воздуха!");
        }

        public void SweetMenu()
        {
            if (obj.IsSweet())
                Console.WriteLine("Используется сладкая начинка");
            else
                Console.WriteLine("Боюсь расстроить сладкоежек, но они соленые");
        }
    }
}
