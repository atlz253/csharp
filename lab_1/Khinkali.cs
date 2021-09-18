using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Khinkali
    {
        private static readonly Random rnd = new Random();
        private bool isCooked = false;
        private bool exist = true;
        private int meat;
        private int dough;

        public bool IsCooked
        { 
            get
            {
                return isCooked;
            }
        }

        public bool Exist
        { 
            get
            {
                return exist;
            }
        }

        public int Meat 
        { 
            get
            {
                return meat;
            }

            set
            {
                if (value > 100)
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

        public int Dough 
        { 
            get
            {
                return dough;
            }

            set
            {
                if (value > 100)
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
        public double Weight { get; set; }
        public int FoldNum { get; }

        public Khinkali()
        {
            Weight = rnd.Next(200, 500);
            FoldNum = rnd.Next(4, 9);
        }

        public Khinkali(int meat, double weight) : this()
        {
            Meat = meat;
            Weight = weight;
        }

        public Khinkali(int meat, double weight, int foldNum) : this(meat, weight)
        {
            FoldNum = foldNum;
        }

        public void Cook()
        {
            isCooked = true;
        }

        public int Eat()
        {
            if (isCooked && exist)
            {
                exist = false;
                return 0;
            }
            else if (!exist)
            {
                return 1;
            }
            else if (!isCooked)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        public double[] Ratio()
        {
            double one = (Meat + Dough) / 100;
            return new double[2] { Meat/one, 100 - Meat/one };
        }

        static public double[] IdealRatio()
        {
            return new double[2] { 80, 20 };
        }

        public override string ToString()
        {
            string str = "";

            if (!exist)
                str += "Помянем ";
            if (!isCooked)
                str += "Приготовленные ";
            else
                str += "Сырые ";

            str += $"хинкали весом {Weight}г [Соотношение мяса к тесту {meat}/{dough}]";

            return str;
        }
    }
}
