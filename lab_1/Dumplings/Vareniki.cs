using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumplings
{
    class Vareniki: Dumplings
    {
        private char filling;

        public char Filling { get; }

        Vareniki(char filling): base()
        {
            this.filling = filling;
        }

        Vareniki(char filling, double weight): base(weight)
        {
            this.filling = filling;
        }
    }
}
