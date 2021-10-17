using lab_3.Dumpling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Menu
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
