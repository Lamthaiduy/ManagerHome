using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Manager
{
    class Program : contract
    {
        static void Main(string[] args)
        {

            Program P = new Program();
            P.ChooseHouse();
            Console.ReadKey();

        }
        public void ChooseHouse()
        {
            ArrayList ArrPerson = new ArrayList();
            ArrPerson.Add(new Customer());
            Console.WriteLine("Please choose house you want:\n 1.NormalHouse: \n 2.LuxuryHome: \n 3.Villa: \n");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    NormalHouse N = new NormalHouse();
                    Console.WriteLine("Report");
                    foreach (Customer item in ArrPerson)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    N.gethouse();
                    break;
                case 2:
                    LuxuryHome L = new LuxuryHome();
                    L.gethouse();
                    Console.WriteLine("Report");
                    foreach (Customer item in ArrPerson)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    L.gethouse();
                    break;
                case 3:
                    Villa V = new Villa();
                    Console.WriteLine("Report");
                    foreach (Customer item in ArrPerson)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    V.gethouse();
                    break;

            }

        }
    }
}
