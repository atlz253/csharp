using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumpling
{
    abstract class Dumplings
    {
        protected static readonly Random rnd = new Random();

        protected int dough;

        protected bool exist = true;
        protected bool isCooked = false;

        public double Weight { get; set; }

        public virtual int Dough
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

        public Dumplings()
        {
            Weight = rnd.Next(200, 500);
        }

        public Dumplings(double weight) : this()
        {
            Weight = weight;
        }

        public virtual int Cook()
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

        public virtual int Eat()
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

        public virtual string Name()
        {
            return "класс пельменеобразное ";
        }
    }
}
