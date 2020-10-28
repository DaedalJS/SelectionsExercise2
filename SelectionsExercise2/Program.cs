using System;

namespace SelectionsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what's your favorite school subject?");
            string subject = Console.ReadLine();
            subject = subject.ToLower();     

            switch (subject)
            {
                case "math":
                    Console.WriteLine($"{subject}, you like to play with them numbers huh?");
                    break;
                case "history":
                    Console.WriteLine($"{subject}, you like hearing about them has beens huh?");
                    break;
                case "art":
                    Console.WriteLine($"{subject}, ah... gonna major in 'do you want fries with that' huh?");
                    break;
                case "pe":
                    Console.WriteLine($"{subject}, you're the type who just can't sit still huh?");
                    break;
                case "science":
                    Console.WriteLine($"{subject}, you like being a know it all huh?");
                    break;
                default:
                    Console.WriteLine($"{subject}, yea... like that's interesting.");
                    break;

            }
        }
    }
}
