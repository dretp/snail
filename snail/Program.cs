using System;

namespace snail
{
    class Program
    {
        static void Main(string[] args)
        {
            snail Gray = new snail();
            snail Larry = new snail();
            //setting snail name
            Gray.Name = "gary";
            Larry.Name = "Larry";
            //setting snail length
           Gray.length = 6;
           Larry.length = 8;

            //setting snail age 
                Gray.age = 12;
                Larry.age = 16;

            Console.WriteLine(Gray.Name);
            Console.ReadLine();
        }
    }
}
