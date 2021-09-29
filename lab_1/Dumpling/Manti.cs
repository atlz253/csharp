using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Dumpling
{
    class Manti : Dumplings
    {
        private bool salt;
        private bool pepper;
        private bool paprika;
        private bool karri;

        public Manti() : base() 
        {
            salt = rnd.Next(100) <= 50;
            pepper = rnd.Next(100) <= 50;
            paprika = rnd.Next(100) <= 50;
            karri = rnd.Next(100) <= 50;
        }

        public Manti(double weight, bool salt, bool pepper, bool paprika, bool karri) : base(weight) 
        {
            this.salt = salt;
            this.pepper = pepper;
            this.paprika = paprika;
            this.karri = karri;
        }

        public override string Name()
        {
            return base.Name() + "манты";
        }

        public override string ToString()
        {
            string str = "";

            if (!exist)
                str += "помянем ";

            str += "манты ";

            if (salt)
                str += "соленые ";
            if (pepper)
                str += "перченые ";
            if (paprika)
                str += "с добавлением папрки ";
            if (karri)
                str += "с подсыпанным карри ";

            return str;
        }
    }
}
