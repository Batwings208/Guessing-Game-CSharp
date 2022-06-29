using System; // this is for older versions but new versions of CSharp don't need this anymore


namespace GuessingGame
{
    class Program // classic name people choose, didn't want anything really fancy tbh
    {

        static void Main()
        {
            int guesses; // later used in code
            int usrguess; // later used in code

            guesses = 0;

            Random rand = new Random();
            int randnum = rand.Next(0, 101); // once made randnum will stay that number

            Console.WriteLine("Hello, Welcome to... the Guessing Game!");
            Thread.Sleep(1000); // stop for 3 seconds
            Console.WriteLine("You will recieve 5 tries to guess the number I'm thinking.");
            Thread.Sleep(1000);
            Console.WriteLine("Everytihng I you answer, I will tell you if you were too high or too low.");
            Thread.Sleep(1000);
            Console.WriteLine("Good Luck, and let the games begin!");
            Thread.Sleep(1000);


            while (guesses < 5)
            {
                Console.Write("What is your Guess?: "); // input guess

                string s1 = Console.ReadLine(); // putting input guess in string
                usrguess = int.Parse(s1); // to convert the users guess from a string to a integer

                if (usrguess == randnum)
                {
                    guesses += 1; // added a guess because its not added right after input
                    Console.WriteLine("Congratulations!! You have beaten me! Good Job!");
                    Console.WriteLine($"You have beaten me in: {guesses}");
                    break; // to end the program once you have won
                }

                else if (usrguess > randnum)
                {
                    Console.WriteLine("Your guess is higher than the number");
                    guesses += 1; // adding guess
                }
                else if (usrguess < randnum)
                {
                    Console.WriteLine("Your guess is lower than the number");
                    guesses += 1; // adding guess
                }
                else
                {
                    Console.WriteLine("I do not understand your input, Guess not counted."); // incase of incorrect input such as alphabets
                }

            }
        }
    }
}
