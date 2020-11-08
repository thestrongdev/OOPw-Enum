using System;

namespace oopEx64_66
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises 64-66 + Bonus 4

            var checkEnumEntry = new Validator();

            Console.WriteLine("enter yes or no");
            string userInput = Console.ReadLine();
            userInput = userInput.ToUpper();

            Console.WriteLine(checkEnumEntry.ParseYesNo(userInput));
        }
    }
}
