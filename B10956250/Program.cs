using System;

namespace B10956250
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test = "test";
            var aaa = "test";
            const string tsetconst = "aaa";
            //testconst = "bb;
            int price = 100;
            bool isHappy = true;
            Console.WriteLine(!isHappy);


            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            int a;
            a = (int)(meal_cost + tip_percent+tax_percent);
            Console.WriteLine("總額" + a);

        }

    }
}
