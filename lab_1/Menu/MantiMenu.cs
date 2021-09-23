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
        public void Init()
        {
            int choice;

             while (true)
            {
                Console.WriteLine("А чем манты отличаются от хинкалей?! Ну... Добавим специй)");
                Console.WriteLine("1. создать манты");
            }
        }

        public Dumplings Create()
        {
            return new Manti();
        }

        public void EatMenu()
        {

        }
    }
}
