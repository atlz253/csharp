using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumplings
{
    class Manti : Dumplings
    {
        /*
            0. соль
            1. перец
            2. паприка
            3. карри
        */
        private int[] spices;

        private int[] Spices { get; }

        Manti(int[] spices) : base()
        {
            this.spices = spices;
        }

        Manti(int[] spices, double weight) : base(weight)
        {
            this.spices = spices;
        }

        public bool IsHot()
        {
            foreach(int spice in spices)
                switch (spice)
                {
                    case 1:
                    case 3:
                        return true;
                }

            return false;
        }

        public override string Name()
        {
            return base.Name() + "манты";
        }
    }
}
