using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumpling
{
    sealed class Vareniki : Dumplings
    {
        /* 
        0 - варенье 
        1 - картошка
        2 - творог
        */
        private int filling;

        public int Filling { get; }

        Vareniki(int filling): base()
        {
            this.filling = filling;
        }

        Vareniki(char filling, double weight): base(weight)
        {
            this.filling = filling;
        }

        public bool IsSweet()
        {
            switch (filling)
            {
                case 0:
                case 2:
                    return true;
                case 1:
                    return false;
            }

            return false;
        }

        public override string Name()
        {
            return base.Name() + "вареники";
        }
    }
}
