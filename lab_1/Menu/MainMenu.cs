using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Menu
{
    class MainMenu
    {
        public void Init()
        {
            int choice;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("К вам подходит официант и передает вам меню. \"У нас сегодня мастер класс по пельменям. По вам видно, что вы не первый раз лепите пельмени. Рыбак рыбака видит издалека ;)\". ");
                Console.WriteLine("Что вас интересует?");
                Console.WriteLine("1. хинкали");
                Console.WriteLine("2. манты");
                Console.WriteLine("3. пельмени");
                Console.WriteLine("4. вареники");
                Console.WriteLine("5. я составлю список");
                Console.WriteLine("0. выход");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        new KhinkaliMenu().Init();
                        break;
                    case 2:
                        new MantiMenu().Init();
                        break;
                    case 3:
                        new PelmeniMenu().Init();
                        break;
                    case 4:
                        new VarenikiMenu().Init();
                        break;
                    case 5:
                        new ListMenu().Init();
                        break;
                    case 0:
                        return;
                }
            }
        }
    }
}
