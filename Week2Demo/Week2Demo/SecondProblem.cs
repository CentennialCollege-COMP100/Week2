using System;
namespace Week2Demo
{
    public class SecondProblem
    {
        static void Main(string[] args)
        {

            double s1;
            double s2;
            double s3;
            double s4;
            double per;

            //    // double n1, n2, n3, sum, avg;
            Console.WriteLine("This is a program to calcualte the perimeter of a polygon ");

            Console.WriteLine("Enter 4 numbers, the sides of the polygon");

            Console.WriteLine("Enter First side ");
            s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second side ");
            s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third side ");
            s3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter forth side ");
            s4 = Convert.ToDouble(Console.ReadLine());


            per = s1 + s2 + s3 + s4;

            Console.WriteLine("the polygon's perimeter is " + per);


        }
    }

}
