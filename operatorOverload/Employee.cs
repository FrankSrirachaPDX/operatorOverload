using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverload
{
    public class Employee
    {
        int id;
        public Employee()
        {
            id = 0;
        }
        public Employee(int x)
        {
            id = x;
        }

        public static bool operator == (Employee x, Employee y)
        {
            if (x.id == y.id) { return true; }
            else
                return false;
        }
        public static bool operator != (Employee x, Employee y)
        {
            if(x.id != y.id) { return true; }
            else
                return false;
        }
        public int getValue()
        {
            return id;
        }
    }
}
