using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumpling
{
    class Khinkali : Dumplings
    {
        private int meat;

        private bool soup = false;

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

        public override int Dough 
        { 
            get
            {
                return dough;
            }

            set
            {
                if (value < 100)
                {
                    dough = value;
                    meat = 100 - dough;
                }
                else
                {
                    dough = 100;
                    meat = 0;
                }
            }
        }
        
        public int FoldNum { get; }

        public Khinkali() : base()
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

        public int Drink()
        {
            if (soup && exist)
            {
                soup = false;

                return 0;
            }
            else if (!isCooked)
            {
                return 1;
            }
            else if (!soup)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        public override int Cook()
        {
            if (!IsCooked)
            {
                isCooked = true;
                soup = true;

                return 0;
            }
            else
            {
                exist = false;

                return 1;
            }
        }

        public override int Eat()
        {
            if (IsCooked && exist)
            {
                exist = false;
                soup = false;

                return 0;
            }
            else if (!exist)
            {
                return 1;
            }
            else if (!IsCooked)
            {
                return 2;
            }
            else
            {
                return -1;
            }
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

        public override string Name()
        {
            return base.Name() + "хинкали";
        }
    }
}
