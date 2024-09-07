using System.Diagnostics.CodeAnalysis;

namespace MyFirstProgram {
    class Program {
        static void Main(string[] args)
        {
            /*Random random = new Random();
            int a = 0;
            int b = 0;
            int score = 1;
            Console.Write("enter number: ");
            do {
                b = random.Next(6)+1;
                a = Convert.ToInt32(Console.ReadLine());
                if (a != b)
                {
                    Console.Write("guess again: ");
                    score++;
                }
            } while (a != b);
            Console.WriteLine("you are correct");
            Console.WriteLine("you guessed: " + score + " times");*/
            Human human1 = new Human();
            human1.Age = 10;
            Console.WriteLine(human1.Age);
            Console.ReadKey();
        }
    }
}