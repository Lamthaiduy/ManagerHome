using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class HomeForRent : contract
    {
        public string NameHouse;
        public string HouseAddress;
        public int Price;
        public string[] Service = new string[] { "Swim pool", "Cinema", "Tennis court, golf course" };
        public HomeForRent()
        {

        }
        public virtual void gethouse()
        {

        }

    }
}
