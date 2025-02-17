using System;
using System.Collections;
using System.Threading;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Random random = new Random();

        Console.WriteLine("(Player Vs AI press 1)");
        Console.WriteLine("(AI Vs Player press 2)");
        Console.WriteLine("(After selecting Game mode hit enter)");

        string gameMode = Console.ReadLine();
        theGameMode();

        void theGameMode()
        {
            if (gameMode == "1")
            {
                PlayerVsAI();
            }
            else if (gameMode == "2")
            {
                AIVsPlayer();
            }
        }

        void PlayerVsAI()
        {
            int playerNum;
            int aiGuessNumberAmount = 5;

            Console.Clear();
            Console.WriteLine("Pick your number for the AI to guess (1 out of 10)");
            playerNum = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("(The AI will get 5 guesses)");
            Console.WriteLine("(Enter to continue)");
            Console.ReadLine();
            Console.Clear();
            int randomIndex = random.Next(list.Count);
            int AIguess = (int)list[randomIndex];
            Console.WriteLine("AI Guesses: " + AIguess);
            checkAVP();
            AIguess = (int)list[randomIndex];
            Console.WriteLine("This time the AI Guesses: " + AIguess);
            checkAVP();
            AIguess = (int)list[index: randomIndex];
            Console.WriteLine("The AI Guesses: " + AIguess);
            checkAVP();
            AIguess = (int)list[randomIndex];
            Console.WriteLine("AI Guesses: " + AIguess);
            checkAVP();
            AIguess = (int)list[randomIndex];
            Console.WriteLine("This time the AI Guesses: " + AIguess);
            checkAVP();

            void checkAVP()
            {
                if (AIguess == playerNum)
                {
                    Console.WriteLine("(You lost...)");
                    Console.WriteLine("(Thanks for playing) (This will close in 7 seconds)");
                    Thread.Sleep(7000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("(The ai guessed wrong)");
                    aiGuessNumberAmount--;
                    list.Remove(AIguess);

                    if (aiGuessNumberAmount <= 0)
                    {
                        Console.WriteLine("(You win!)");
                        Console.WriteLine("(Thanks for playing (Enter to quit))");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("(Enter to continue)");
                        Console.ReadLine();
                    }
                }
            }
        }

        void AIVsPlayer()
        {
            int playerGuessNumberAmount = 5;
            int playerNumGuess;
            Console.Clear();
            Console.WriteLine("AI has picked its number");
            int randomIndex = random.Next(list.Count);
            int AInum = (int)list[randomIndex];
            Console.WriteLine("(Enter to continue)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("(You will get 5 guesses)");
            Console.WriteLine("(Enter to continue)");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Type Your guess: ");
            playerNumGuess = int.Parse(Console.ReadLine());
            checkPVA();
            Console.Write("Type Your guess: ");
            playerNumGuess = int.Parse(Console.ReadLine());
            checkPVA();
            Console.Write("Type Your guess: ");
            playerNumGuess = int.Parse(Console.ReadLine());
            checkPVA();
            Console.Write("Type Your guess: ");
            playerNumGuess = int.Parse(Console.ReadLine());
            checkPVA();
            Console.Write("Type Your guess: ");
            playerNumGuess = int.Parse(Console.ReadLine());
            checkPVA();

            void checkPVA()
            {
                if (playerNumGuess == AInum)
                {
                    Console.WriteLine("(You Win! (You have guessed the AI's number))");
                    Console.WriteLine("(Thanks for playing) (This will close in 7 seconds)");
                    Thread.Sleep(7000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("(You guessed wrong)");
                    playerGuessNumberAmount--;

                    if (playerGuessNumberAmount <= 0)
                    {
                        Console.WriteLine("(You lose...)");
                        Console.WriteLine("(Thanks for playing (Enter to quit))");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("(Enter to continue)");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}