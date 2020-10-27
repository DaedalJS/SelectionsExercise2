using System;

namespace SelectionsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what's your favorite school subject?");
            string subject = Console.ReadLine();
            int subNum = 6;
            subject = subject.ToLower();

            if (subject == "math")
            {
                subNum = 1;
            }
            else if (subject == "history")
            {
                subNum = 2;
            }
            else if (subject == "art")
            {
                subNum = 3;
            }
            else if (subject == "pe")
            {
                subNum = 4;
            }
            else if (subject == "science")
            {
                subNum = 5;
            }
           

            switch (subNum)
            {
                case 1:
                    Console.WriteLine($"{subject}, you like to play with them numbers huh?");
                    break;
                case 2:
                    Console.WriteLine($"{subject}, you like hearing about them has beens huh?");
                    break;
                case 3:
                    Console.WriteLine($"{subject}, ah... gonna major in 'do you want fries with that' huh?");
                    break;
                case 4:
                    Console.WriteLine($"{subject}, you're the type who just can't sit still huh?");
                    break;
                case 5:
                    Console.WriteLine($"{subject}, you like being a know it all huh?");
                    break;
                default:
                    Console.WriteLine($"{subject}, yea... like that's interesting.");
                    break;

            }
        }
    }
}
