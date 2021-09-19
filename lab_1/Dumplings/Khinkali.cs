using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumplings
{
    class Khinkali : Dumplings
    {
        private int meat;
        private int dough;

        public int Meat 
        { 
            get
            {
                return meat;
            }

            set
            {
                if (value < 100)
                {
                    meat = value;
                    dough = 100 - value;
                }
                else
                {
                    meat = 100;
                    dough = 0;
                }
            }
        }

        public int FoldNum { get; }

        public Khinkali(): base()
        {
            FoldNum = rnd.Next(4, 9);
            Meat = rnd.Next(50, 90);
        }

        public Khinkali(int meat, double weight) : base(weight)
        {
            Meat = meat;
        }

        public Khinkali(int meat, double weight, int foldNum) : this(meat, weight)
        {
            FoldNum = foldNum;
        }

        public int[] Ratio() // придумать какой-нибудь другой метод
        {
            int one = (Meat + Dough) / 100;
            return new int[2] { Meat/one, 100 - Meat/one };
        }

        static public int[] IdealRatio()
        {
            return new int[2] { 80, 20 };
        }

        public override string ToString()
        {
            string str = "";

            if (!exist)
                str += "Помянем ";
            else if (IsCooked)
                str += "Приготовленные ";
            else
                str += "Сырые ";

            str += $"хинкали весом {Weight}г [Соотношение мяса к тесту {meat}/{dough}]";

            return str;
        }
    }
}
