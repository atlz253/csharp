using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Dumpling
{
    class Pelmeni : Dumplings
    {
        /*
            1. свинина
            2. говядина
            3. курица
            4. индейка    
        */
        private int meatType;
        private bool isFried = false;

        public int MeatType 
        { 
            get
            {
                return meatType;
            }
        }

        public Pelmeni() : base()
        {
            this.meatType = rnd.Next(1, 4);
        }

        public Pelmeni(int meatType) : base()
        {
            this.meatType = meatType;
        }

        public void Fry()
        {
            isFried = true;
        }

        public override string Name()
        {
            return base.Name() + "пельмени";
        }

        public override void Info()
        {
            base.Info();

            string str = "";

            switch (MeatType)
            {
                case 1:
                    str = "свинина";
                    break;
                case 2:
                    str = "говядина";
                    break;
                case 3:
                    str = "курица";
                    break;
                case 4:
                    str = "индейка";
                    break;
            }

            Console.WriteLine(str);
        }

        public override string ToString()
        {
            return "Пельмени";
        }

        public override void Dispose()
        {
            Console.WriteLine("Был вызван метод Dispose класса Pelmeni");
            Console.ReadKey();
            Console.Clear();
        }

        ~Pelmeni()
        {
            Console.WriteLine("Был вызван деструктор класса Pelmeni");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
