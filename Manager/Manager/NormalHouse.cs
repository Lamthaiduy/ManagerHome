using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manager
{
    class NormalHouse : HomeForRent
    {
        public NormalHouse()
        {
            NameHouse = "Ron";
            HouseAddress = "234 Wall Street";
            Price = 100;

        }
        public override void gethouse()
        {
            Console.WriteLine("NameHouse:{0}", NameHouse);
            Console.WriteLine("HouseAddress:{0}", HouseAddress);
            Console.WriteLine("Price:{0}", Price);

            string i = "C:/text/text1.txt";
            if (!File.Exists(i))
            {
                using (StreamWriter sw = File.CreateText(i))
                {
                    sw.WriteLine("NameHouse:{0}", NameHouse);
                    sw.WriteLine("HouseAddress:{0}", HouseAddress);
                    sw.WriteLine("Price:{0}$", Price);
                }
            }
            Newfile(i);
        }

    }
}
