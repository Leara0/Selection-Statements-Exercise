namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's play a number guessing game! I'll think of a number and your challenge");
            Console.WriteLine("is to guess it. I'll let you know whether your guess is too high or too low.");
            Console.WriteLine("\nIf you'd like to stop at any time, just type 'exit'");
            Console.WriteLine("\nBefore we begin, can you help me decide on a range for my number? What do you");
            Console.WriteLine("think would be a good starting point?");

            int[] userInput = GetUserInput();
            if (userInput[1] == 1)
                return;
            int lowerBound = userInput[0];

            Console.WriteLine($"Great! The lowest number I might pick is {lowerBound}");
            Console.WriteLine("What do you think would be a good maximum value to set as the upper limit?");

            userInput = GetUserInput();
            if (userInput[1] == 1)
                return;
            int upperBound = userInput[0];
            while (upperBound <= lowerBound)
            {
                Console.WriteLine("I'm sorry, the maximum value must be higher than the minimum value. ");
                Console.WriteLine($"Please enter a new maximum value.");
                userInput = GetUserInput();
                if (userInput[1] == 1)
                    break;
                upperBound = userInput[0];
            }
            if (userInput[1] == 1)
                return;

            string reply;
            int difference = upperBound - lowerBound;

            switch (difference)
            {
                case <= 10:
                    reply = " - a conservative and excellent choice, this game shouldn't take too long.";
                    break;
                case <= 100:
                    reply = " - oh, looks like you're feeling a bit adventurous. How exciting!";
                    break;
                case < 1000:
                    reply = "! Wow! You're feeling audacious! We better get started because this may take a while!";
                    break;
                default:
                    reply = "!?! I'm at a loss for words! We've got a long road ahead!";
                    break;
            }

            Console.WriteLine($"{upperBound}{reply}");

            Random generator = new Random();
            int computerNumber = generator.Next(lowerBound, upperBound + 1);

            Console.WriteLine("\rPlease enter your first guess");
            int userGuess;
            do
            {
                userInput = GetUserInput();
                if (userInput[1] == 1)
                    break;
                userGuess = userInput[0];

                if (userGuess > upperBound || userGuess < lowerBound)
                {
                    Console.WriteLine("That's an odd guess... it's outside of the range you gave me for picking an number.");
                    Console.WriteLine($"Please try a guess that is between {lowerBound} and {upperBound}");
                }
                else if (userGuess > computerNumber)
                    Console.WriteLine("That guess is too high. Give it another try with a lower number.");
                else
                    Console.WriteLine("That guess is too low. Try a higher number.");


            } while (userGuess != computerNumber);
            if (userInput[1] == 1)
                return;
            Console.WriteLine("   (        +                    +                  ");
            Console.WriteLine("    )  .         )    *                (    +   ");
            Console.WriteLine(".  (       .    (                .      )           ");
            Console.WriteLine("    +            )      +     (        (              ");
            Console.WriteLine(" *        (                    )          .         ");
            Console.WriteLine("           )       +         .      *          ");
            Console.WriteLine($"You did it! You guessed {computerNumber} which is my number!");
           

        }
        public static int[] GetUserInput()
        {
            string reply = Console.ReadLine();
            bool validInput = int.TryParse(reply, out int result);
            int[] userInput = { 0, 0 };  // spot 0 will store user's input, spot 1 will be check for 'exit'
            do
            {
                if (reply.ToLower().Trim() == "exit")
                {
                    userInput[1] = 1;  // 
                    return userInput;
                }
                else if (validInput)
                {
                    userInput[0] = result;
                    return userInput;
                }
                Console.WriteLine("I'm sorry, you didn't enter a valid input. Please either enter an integer");
                Console.WriteLine("Or type 'exit' to quit");
                reply = Console.ReadLine();
                validInput = int.TryParse(reply, out result);
            } while (true);
            return userInput;
        }
    }
}
