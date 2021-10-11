using System;

namespace HelloChatter
{

    class Functions
    {
        #region
        public static int add(int a, int b) =>
            a + b;

        public static int mult(int a, int b) =>
            a * b;

        public static int sub(int a, int b) =>
            a - b;

        public static int div(int a, int b) =>
            a / b;

        public static int guessBirthDate(int currentYear, int age)
        {
            return currentYear - age;
        }
            

        #endregion
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // window

            Console.Title = "skyn3t's AI";
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Hey! Im skyn3t's AI, whats your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name}!\n");
            Console.WriteLine("Whats your age?");
            var age = Console.ReadLine();
            var newAge = Int32.Parse(age);
            Console.WriteLine($"Wow! I didn't know you were {age} years old! That means you were born in... hmm let me guess...{Functions.guessBirthDate(2021, newAge)}");
            Console.WriteLine($"So, {name}, what do you do as a hobby?");
            var hobby = Console.ReadLine();
            Console.WriteLine($"You {hobby}? Thats really cool. I wish I could do that too!");
            Console.ReadKey();
        }
    }
}
