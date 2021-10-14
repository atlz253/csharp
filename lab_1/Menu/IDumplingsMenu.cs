using lab_1.Dumpling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Menu
{

    interface IDumplingsMenu
    {
        void Init();

        Dumplings Create();

        void CookMenu();

        void EatMenu();

        void NameMenu();

        void ClassMenu();
    }
}
