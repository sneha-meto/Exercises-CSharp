using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Exercise
{
    class One
    {
        public void hello(string name)
        {
            Console.WriteLine("1.");
            Console.WriteLine($"Hello: {name}");
        }

        public void sum(int a, int b)
        {
            Console.WriteLine("2.");
            Console.WriteLine($"{a} + {b} = {a+b}");
        }

        public void div(int a, int b)
        {
            Console.WriteLine("3.");
            Console.WriteLine($"{a} / {b} = {a / b}");
            
        }

        public void calculate()
        {
            Console.WriteLine("4.");
            Console.WriteLine($"-1 + 4 * 6 = {-1 + 4 * 6}");
            Console.WriteLine($"( 35+ 5 ) % 7 = {(35 + 5) % 7}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");

        }

        public void swap()
        {
            Console.WriteLine("5.");
            Console.WriteLine("input first no to swap:");
            string  x = Console.ReadLine();
            int a = Convert.ToInt32(x);
            Console.WriteLine("input second no to swap:");
            string y = Console.ReadLine();
            int b = Convert.ToInt32(y);
           
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("first no: {0}",a);
            Console.WriteLine("second no: {0}",b);

        }

        public void mult()
        {
            Console.WriteLine("6.");
            Console.WriteLine("Input the first number to multiply:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}x{1}x{2} = {3}",a,b,c,a*b*c);

            ;
        }

        public void math()
        {
            Console.WriteLine("7.");
            Console.WriteLine("Input the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }

        public void table()
        {
            Console.WriteLine("8. mult table");
            Console.WriteLine("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
                Console.WriteLine($"{a} x {i} = {a*i}");
        }

        public void average()
        {
            Console.WriteLine("9. average");
            Console.WriteLine("Input the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the fourth number:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"average of {a}, {b}, {c}, {d} is: {(a + b + c + d) / 4}");

        }

        public void output()
        {
            Console.WriteLine("10.");
            Console.WriteLine("Input the first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, ({x}+{y}).{z} is {(x + y) * z} and {x}.{y} + {y}.{z} is {(x * y) + (y * z)}");

        }


    }
    internal class Exe1
    {

        public static void Main2()
        {
            One one = new One();
            one.hello("Sneha");
            one.sum(3, 4);
            one.div(8, 2);
            one.calculate();
            one.swap();
            one.mult();
            one.math();
            one.table();
            one.average();
            one.output();




            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
