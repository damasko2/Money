using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_H
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(2);
            Money money2 = new Money(45);

            Money money3 = money + money2;
            Console.WriteLine(money3.ToString());

            Money money4 = money - money2;
            Console.WriteLine(money4.ToString());

            Money money5 = money * money2;
            Console.WriteLine(money5.ToString());

            Money money6 = money / money2;
            Console.WriteLine(money6.ToString());

            money3++;
            Console.WriteLine(money3.ToString());

            money5--;
            Console.WriteLine(money5.ToString());

            if (money>money2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            if (money==money2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
