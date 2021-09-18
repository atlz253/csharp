using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    abstract class Flour
    {
        protected static readonly Random rnd = new Random();

        private int dough;

        protected bool exist = true;
        private bool isCooked = false;

        public double Weight { get; set; }

        public int Dough
        {
            get
            {
                return dough;
            }

            set
            {
                if (value < 100)
                    dough = value;
                else
                    dough = 100;
            }
        }

        public bool Exist
        {
            get
            {
                return exist;
            }
        }

        public bool IsCooked
        {
            get
            {
                return isCooked;
            }
        }

        public Flour()
        {
            Weight = rnd.Next(200, 500);
        }

        public Flour(double weight) : this()
        {
            Weight = weight;
        }

        public int Cook()
        {
            if (!isCooked)
            {
                isCooked = true;

                return 0;
            }
            else
            {
                exist = false;

                return 1;
            }
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
    }
}
