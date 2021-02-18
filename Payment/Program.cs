using System;

namespace Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" WELCOME TO SALARY INCREASE CALCULATOR  ");
            double salary, raiserate, increasedsalary;
            Console.Write("Please Enter Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Raise Rate (%) : ");
            raiserate = Convert.ToDouble(Console.ReadLine());
            increasedsalary = salary + (salary * raiserate / 100);
            Console.WriteLine("Zamlı maaş : {0}", increasedsalary);
            Console.ReadKey();
        }
    }
}
