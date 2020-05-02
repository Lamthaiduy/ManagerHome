using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class Villa : HomeForRent
    {
        static string service;
        public Villa()
        {
            NameHouse = "The Royal";
            HouseAddress = "100 Toluca Lake,Los Angeles, USA";
            Price = 5000;
            Service[1] = service;
            Service[2] = service;
        }
        public override void gethouse()
        {
            Console.WriteLine("NameHouse:{0}", NameHouse);
            Console.WriteLine("HouseAddress:{0}", HouseAddress);
            Console.WriteLine("Price:{0}", Price);
            Console.WriteLine("Service:{0}", service);

            string i = "C:/text/text4.txt";
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
