using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumpling
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
    }
}
