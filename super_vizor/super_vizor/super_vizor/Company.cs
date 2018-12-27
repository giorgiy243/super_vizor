using System;
using System.Collections.Generic;
using System.Text;

namespace super_vizor
{
    class Company
    {

        public Company(string name)
        {
            Name = name;
        }
        private string Name;

        public string ShowComp()
        {
            return Name;
        }
    }
}
