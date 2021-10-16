using lab_1.Dough;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumpling
{
    abstract class Dumplings : IEatable
    {
        protected static readonly Random rnd = new Random();

        protected int dough;
        protected double weight;

        protected bool exist = true;
        protected bool isCooked = false;

        public double Weight 
        { 
            get
            {
                return weight;
            }
            
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("          _ ._  _ , _ ._");
                    Console.WriteLine("        (_ ' ( `  )_  .__)");
                    Console.WriteLine("      ( (  (    )   `)  ) _)");
                    Console.WriteLine("     (__ (_   (_ . _) _) ,__)");
                    Console.WriteLine("         `~~`\\ ' . /`~~`");
                    Console.WriteLine("              ;   ;");
                    Console.WriteLine("              /   \\");
                    Console.WriteLine("_____________/_ __ \\_____________\n");
                    Console.WriteLine("Были слеплены хинкали из антиматерии.");
                    Console.WriteLine("Все живое, включая вселенную, вымерло");
                    Console.WriteLine("Теперь вы довольны?");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }

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
            if (!isCooked && exist)
            {
                isCooked = true;

                return 0;
            }
            else if (isCooked)
            {
                exist = false;

                return 1;
            }
            else
            {
                return -1;
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

        public virtual void Info()
        {
            Console.WriteLine(Name());
            Console.WriteLine(exist ? "Слепленные" : "Съеденные");
            Console.WriteLine(IsCooked ? "Приготовленные" : "Сырые");
            Console.WriteLine($"Вес: {Weight}г");
            Console.WriteLine($"% теста: {dough}");
        }

        public override string ToString()
        {
            return "Пельменеобразное";
        }
    }
}
