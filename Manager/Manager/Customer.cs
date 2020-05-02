using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class Customer : contract
    {

        private string Name;
        private string Address;
        private Nullable<int> Age;
        private string NumberPhone;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string address
        {
            get { return Address; }
            set
            {
                Address = value;
            }
        }
        public Nullable<int> age
        {
            get { return Age; }
            set { Age = value; }
        }
        public string numberphone
        {
            get { return NumberPhone; }
            set { NumberPhone = value; }
        }
        public Customer()
        {
            Console.WriteLine("Please input your name: ");
            this.Name = Console.ReadLine();
            if (Name == "")
            {
                Console.WriteLine("Input name again: ");
                this.Name = Console.ReadLine();
            }
            Console.WriteLine("Please input your Adderss: ");
            this.Address = Console.ReadLine();
            if (Address == "")
            {
                Console.WriteLine("Input Address again: ");
                this.Address = Console.ReadLine();
            }
            Console.WriteLine("Please input your Age: ");
            this.Age = Convert.ToInt32(Console.ReadLine());
            if (Age <= 20 || Age == null)
            {
                Console.WriteLine("Input Age again: ");
                this.Age = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Please input your NumberPhone: ");
            this.NumberPhone = Console.ReadLine();
            if (NumberPhone == "")
            {
                Console.WriteLine("Input NumberPhone again: ");
                this.NumberPhone = Console.ReadLine();
            }
        }

        public override string ToString()
        {
            Newfile("C:/text/text2.txt");
            return ("Name: " + Name + "|Address: " + Address + "| Age: " + Age + "|NumberPhone: " + NumberPhone);
        }
    }
}
