using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class LuxuryHome : HomeForRent
    {
        static string service;
        public LuxuryHome()
        {
            NameHouse = "Luxury";
            HouseAddress = "20 Lihue Hawaii 96766, USA";
            Price = 2000;
            Service[0] = service;
        }
        public override void gethouse()
        {
            Console.WriteLine("NameHouse:{0}", NameHouse);
            Console.WriteLine("HouseAddress:{0}", HouseAddress);
            Console.WriteLine("Price:{0}", Price);
            Console.WriteLine("Service:{0}", service);

            string i = "C:/text/text3.txt";
            if (!File.Exists(i))
            {
                using (StreamWriter sw = File.CreateText(i))
                {
                    sw.WriteLine("NameHouse:{0}", NameHouse);
                    sw.WriteLine("HouseAddress:{0}", HouseAddress);
                    sw.WriteLine("Price:{0}$", Price);
                    sw.WriteLine("Service:{0}", service);
                }
            }
            Newfile(i);
        }
    }
}
