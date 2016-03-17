using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Please Enter Your Name!");

            string NameFirst = Console.ReadLine();
            

            Console.WriteLine("Please Enter Your Last Name!");

            string NameLast = Console.ReadLine();

            Console.WriteLine("Enter your birth date");

            string BirthDate = Console.ReadLine();

            Console.WriteLine("Enter your Social Security Number");

            int Social = Convert.ToInt32(Console.ReadLine());


            Customer luke = new Customer(NameFirst, NameLast, BirthDate, Social, 1003, 100000, 78, "5/9/15");
            Customer mike = new Customer("Mike", "Johnson", "1/3/78", 3984567, 1990, 10000, 700, "12/8/16");
            Banker jim = new Banker("Jim", "Schmidt", "4/11/78", 389745678, 20, "3/3/93", 1, 50000);
            Teller bob = new Teller("Bob", "Lopez", "4/11/78", 389745677, 20, "3/3/93", 2, 14);
            Manager dick = new Manager("Dick", "Morrison", "9/11/81", 39845933, 19, "11/5/09", 00, 100000, 10000, 25);

            double newBalance = mike.AdjustAccountBalance();
            
            Console.WriteLine(newBalance);

            double mikeCreditScore = mike.CalculateCreditScore();
            Console.WriteLine(mikeCreditScore);

           List<Person> people = new List<Person>();
            people.Add(luke);
            people.Add(mike);
            people.Add(jim);
            people.Add(bob);
            people.Add(dick);

            foreach (Person item in people)
            {

                Console.WriteLine(item.nameFirst +" " + item.nameLast);
            }
            List<Person> supervisors = new List<Person>();
            supervisors.Add(jim);
            supervisors.Add(bob);
            supervisors.Add(dick);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
