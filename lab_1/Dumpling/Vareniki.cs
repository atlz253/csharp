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

        public Vareniki() : base()
        {
            this.filling = rnd.Next(1, 3);
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

        public override void Info()
        {
            base.Info();

            string str = "";

            switch (Filling)
            {
                case 1:
                    str = "варенье";
                    break;
                case 2:
                    str = "картошка";
                    break;
                case 3:
                    str = "творог";
                    break;
            }

            Console.WriteLine(str);
        }

        public override string ToString()
        {
            return "Вареники";
        }
    }
}
