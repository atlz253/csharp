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
        1 - варенье 
        2 - картошка
        3 - творог
        */
        private int filling;

        public int Filling 
        { 
            get
            {
                return filling;
            }
        }

        public Vareniki(int filling): base()
        {
            this.filling = filling;
        }

        public Vareniki(char filling, double weight): base(weight)
        {
            this.filling = filling;
        }

        public bool IsSweet()
        {
            switch (filling)
            {
                case 1:
                case 3:
                    return true;
                case 2:
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
