using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverload
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, y;
            string holder;

            Console.WriteLine("Enter the first employee's ID: ");
            holder = Console.ReadLine();
            x = Convert.ToInt32(holder);

            Console.WriteLine("Enter the second employee's ID: ");
            holder = Console.ReadLine();
            y = Convert.ToInt32(holder);


            Employee idX = new Employee(x);
            Employee idY = new Employee(y);

            if(idX==idY)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.ReadLine();
        }
    }
}
