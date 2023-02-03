    using System;
    public class ProductOfNumber
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
     
            int result = 0;
            int i = 0;
     
            while (i < y)
            {
                result = result + x;
                i++;
            }
     
            Console.WriteLine("Product of {0} and {1} is {2}", x, y, result);
        }
    }