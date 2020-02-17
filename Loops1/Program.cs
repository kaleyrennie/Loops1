using System;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old is my dog?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = age == 3;

            do
            {
                switch (age)
                {
                    case 1:
                        Console.WriteLine("He is not 1.");
                        Console.WriteLine("How old is my dog?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("He is not 2");
                        Console.WriteLine("How old is my dog?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("yes! He is 3!");
                        isGuessed = true;
                        break;
                    default:
                        Console.Write("He is not that old.");
                        Console.WriteLine("How old is my dog?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.ReadLine();

        }
    }
}
