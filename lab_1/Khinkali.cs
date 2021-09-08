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
        public double Meat { get; set; }
        public double Dough { get; set; }
        public double Weight { get; set; }
        public int FoldNum { get; }

        public Khinkali()
        {
            Weight = rnd.Next(200, 500);
            FoldNum = rnd.Next(4, 9);
        }

        public Khinkali(double meat, double weight) : this()
        {
            Meat = meat;
            Weight = weight;
        }

        public Khinkali(double meat, double weight, int foldNum) : this(meat, weight)
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
            string str = "хинкаль весом " + Weight.ToString() + "мг";

            if (!isCooked)
                str = "приготовленный" + str;
            if (!exist)
                str = "помянем" + str;

            return str;
        }
    }
}
