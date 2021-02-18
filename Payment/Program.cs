using System;

namespace Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            Char Lowpage;
        OMERFDEV:
            Console.Write(" WELCOME TO SALARY INCREASE CALCULATOR  ");
            double salary, raiserate, increasedsalary;
            Console.Write("Please Enter Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Raise Rate (%) : ");
            raiserate = Convert.ToDouble(Console.ReadLine());
            increasedsalary = salary + (salary * raiserate / 100);
            Console.WriteLine("Zamlı maaş : {0}", increasedsalary);
            Console.ReadKey();
            Console.WriteLine("1-Return Main Page");
            Console.WriteLine("2-Exit");
            Console.WriteLine("Select 1 or 2");
            Lowpage = Convert.ToChar(Console.ReadLine());

            if (Lowpage == '1')
            {
                Console.Clear();
                goto OMERFDEV;
            }
            else if (Lowpage == '2')
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong Command.");
                goto OMERFDEV;
            }
        }
    }
}

