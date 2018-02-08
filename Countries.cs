using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Countries
    {
        string name;

        public Countries()
        {

        }

        public Countries(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

    }
}
