using System;

namespace Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            double maas, zamOran, zamliMaas;
            Console.Write("Maaşı girin : ");
            maas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zam oranını girin (%) : ");
            zamOran = Convert.ToDouble(Console.ReadLine());
            zamliMaas = maas + (maas * zamOran / 100);
            Console.WriteLine("Zamlı maaş : {0}", zamliMaas);
            Console.ReadKey();
        }
    }
}
