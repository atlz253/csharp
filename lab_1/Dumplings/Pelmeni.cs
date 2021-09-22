using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumplings
{
    class Pelmeni : Dumplings
    {
        /*
            0. свинина
            1. говядина
            2. курица
            3. индейка    
        */
        private int meatType;
        private bool isFried = false;

        public int MeatType { get; }

        Pelmeni(int meatType) : base()
        {
            this.meatType = meatType;
        }

        Pelmeni(int meatType, double weight) : base(weight)
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
