using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Exercise
{

    class Two
    {
        public void equal()
        {
            Console.WriteLine("Input 1st number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
                Console.WriteLine($"{a} and {b} are equal");
            else Console.WriteLine($"{a} and {b} are not equal");
        }

        public void even()
        {
            Console.WriteLine("Input number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} is an {1} integer",a, a % 2 == 0 ? "even" : "odd");

        }
        public void positive()
        {
            Console.WriteLine("Input number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} is a {1} number", a, a <0 ? "negative" : "positive");


        }
        public void leap()
        {
            //A year is a leap year if the following conditions are satisfied: 
            //    The year is multiple of 400.
            //    The year is multiple of 4 and not multiple of 100.

            Console.WriteLine("Input year:");
            int y = Convert.ToInt32(Console.ReadLine());
            string res;
            if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
                res = "a leap";
            else res = "not a leap";

            Console.WriteLine("{0} is {1} year", y, res);

        }
        public void vote()
        {
            Console.WriteLine("Input age:");
            int age = Convert.ToInt32(Console.ReadLine());

            string success = "Congratulations! You are eligible for casting your vote.";
            string failed = "Sorry, You are not eligible for casting your vote.";

            Console.WriteLine(age>=18?success:failed);
        }
        public void mn()
        {
            Console.WriteLine("Input integer m:");
            int m = Convert.ToInt32(Console.ReadLine());
            int n;
            if (m > 0) n = 1;
            else if (m == 0) n = 0;
            else n = -1;

            Console.WriteLine("The value of n = " +n);

        }
        public void height()
        {
            Console.WriteLine("Input height in cm:");
            int h = Convert.ToInt32(Console.ReadLine());
            string res;
            if (h >= 170)
                res = "Tall";
            else if (h >= 140)
                res = "of Average height";
            else 
                res = "a Dwarf";
            Console.WriteLine("the person is {0}.", res);

        }
        public void largest()
        {
            Console.WriteLine("Input the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number:");
            int c = Convert.ToInt32(Console.ReadLine());
            string largest = "";
            if (a > b && a > c) largest = "1st";
            else if (b > a && b > c) largest = "2nd";
            else largest = "3rd";
           
            Console.WriteLine($"The {largest} Number is the greatest among three");

        }
        public void quad()
        {
            Console.WriteLine("Input the value for X coordinate");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value for Y coordinate");
            int y = Convert.ToInt32(Console.ReadLine());
            string quad;

            if (y > 0)
            {
                if (x > 0) { quad = "First"; }
                else quad = "Second";
            }
            else
            {
                if (x > 0) { quad = "Fourth"; }
                else quad = "Third";
            }

            Console.WriteLine($"The coordinate point ({x},{y}) lies in the {quad} quadrant.");

        }
        public void admission()
        {
            Console.WriteLine("Input the marks obtained in Physics: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics: ");
            int m = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((m >= 65 && p >= 55 && c >= 50 && p + c + m >= 180) || (m + p >= 140) || (m + c >= 140))
                res = "eligible";
            else res = "not eligible";
            Console.WriteLine($"The candidate is {res} for admission.");
        }

        public void cube()
        {
            Console.WriteLine("Input number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<n+1; i++)
            Console.WriteLine($"Number is : {i} and cube of the {i} is :{i*i*i}");
        }

        public void table()
        {
            Console.WriteLine("Input the number (Table to be calculated) : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
                Console.WriteLine($"{n} X {i} = {n*i}");
        }

        public void table2()
        {
            Console.WriteLine("Input upto the table number starting from 1 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < n + 1; j++)
                    Console.Write($"{j} X {i} = {j * i},");
                Console.Write("\n");

            }
        }

        public void odd()
        {
            Console.WriteLine("Input number of terms :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The odd numbers are :");
            int sum=0;
            for (int i = 1; i < n * 2; i += 2)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine($"The Sum of odd Natural Number upto {n} terms : {sum}");


        }


        public void asterisk(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i+1; j++)
                    Console.Write("*");
                Console.Write("\n");

            }
        }

        public void tree1(int n)
        {

            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < i+1; j++)
                    Console.Write(j);
                Console.Write("\n");

            }
        }

        public void tree2(int n)
        {

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                    Console.Write(i);
                Console.Write("\n");

            }
        }

        public void tree3(int n)
        {
            int k = 1;
            for (int i = 1; i < n + 1; i++)
            { 
                for (int j = k; j <k+ i ; j++)
                    Console.Write(j+" " );
                k += i;
                Console.Write("\n");

            }
        }

        public void tree4(int n)
        {
            int k = 1;
            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = k; j < k + i; j++)
                    Console.Write(j + " ");
                k += i;
                Console.Write("\n");

            }
        }

        public void tree5(int n)
        {
            int k = 1;
            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = k; j < k + i; j++)
                    Console.Write("* ");
                k += i;
                Console.Write("\n");
            }
        }

    }



    internal class Exe2
    {

        public static void Main()
        {
            Two two = new Two();
            Console.WriteLine("1.compare");
            two.equal();
            Console.WriteLine("2.odd even");
            two.even();
            Console.WriteLine("3.positive");
            two.positive();
            Console.WriteLine("4.leap");
            two.leap();
            Console.WriteLine("5.vote");
            two.vote();
            Console.WriteLine("6.mn");
            two.mn();
            Console.WriteLine("7.height");
            two.height();
            Console.WriteLine("8.largest");
            two.largest();
            Console.WriteLine("9.quad");
            two.quad();
            Console.WriteLine("10.admission");
            two.admission();
            Console.WriteLine("11.cube");
            two.cube();
            Console.WriteLine("12.table");
            two.table();
            Console.WriteLine("13.table2");
            two.table2();
            Console.WriteLine("14.odd");
            two.odd();
            Console.WriteLine("15.tree");
            two.asterisk(5);
            Console.WriteLine("16.tree1");
            two.tree1(5);
            Console.WriteLine("17.tree2");
            two.tree2(5);
            Console.WriteLine("18.tree3");
            two.tree3(5);
            Console.WriteLine("19.tree4");
            two.tree4(4);
            Console.WriteLine("20.tree5");
            two.tree5(5);
            Console.ReadKey();

        }

    }
}
