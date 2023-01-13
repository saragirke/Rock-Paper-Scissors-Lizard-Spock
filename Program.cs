using System;
#nullable disable

public class Program

{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        //Variabel will be used in while-loop
        bool gameStart = true;

        //Both the player and computer have 0 point when the game starts
        int playerScore = 0;
        int computerScore = 0;

        //Welcome-message
        Console.WriteLine("Welcome to the game Rock, Paper, Scissors, Lizard, Spock game. Enter your name:");

        //Store the players name
        string name = Console.ReadLine();


        //while gameStart is true it will loop
        while (gameStart)
        {
            Console.WriteLine("Choose a number to play");
            //Player can chose between these numbers to play
            Console.WriteLine(Environment.NewLine + "1.Rock");
            Console.WriteLine("2.Paper");
            Console.WriteLine("3.Scissors");
            Console.WriteLine("4.Lizard");
            Console.WriteLine("5.Spock");

            //Creating a variable of user input
            string playerNum = Console.ReadLine();

            //Control if input is a number with a bool
            bool success = playerNum.All(Char.IsDigit);
            // If bool is false
            if (!success)
            {
                Console.WriteLine(Environment.NewLine + "Please choose a number");
            }
            else
            {

                //Convert the players number to an integer to controll it
                int playerNumInt = int.Parse(playerNum);

                //The number must be between 1 and 5 to play
                if (playerNumInt > 5 | playerNumInt < 1)
                {
                    Console.WriteLine(Environment.NewLine + "Number must be between 1 and 5 ");

                }

                //Create a random number between 1 and 6, which the computer plays with
                Random randomNum = new Random();
                int computerNum = randomNum.Next(1, 6);

                // Switch statement with the random number
                switch (computerNum)
                {
                    /***********ROCK*****************
                    ******************************/
                    case 1:
                        if (playerNum == "1")
                        {
                            Console.WriteLine(Environment.NewLine + $"{name} chose Rock");
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine("It is a tie.");
                        }

                        else if (playerNum == "2")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Paper");
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine($"Paper covers Rock, {name} wins!");
                            //player gets a point
                            playerScore++;
                        }
                        else if (playerNum == "3")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Scissors");
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine("Rock crushes Scissors, computer wins!");
                            //computer gets a point
                            computerScore++;
                        }
                        else if (playerNum == "4")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Lizard");
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine("Rock crushes Lizard, computer wins!");
                            computerScore++;
                        }
                        else if (playerNum == "5")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Spock");
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine($"Spock vaporizes rock, {name} wins!");
                            playerScore++;
                        }
                        break;

                    /***********PAPER*****************
                    ******************************/
                    case 2:
                        if (playerNum == "1")
                        {

                            Console.WriteLine(Environment.NewLine +  $"{name} chose Rock");
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine($"Paper covers Rock, computer wins");
                            computerScore++;
                        }

                        else if (playerNum == "2")
                        {
                            Console.WriteLine(Environment.NewLine + $"{name} chose Paper");
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("It is a tie!");
                            //player get point

                        }
                        else if (playerNum == "3")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Scissors");
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("Scissors cuts paper, computer wins");
                            computerScore++;
                        }
                        else if (playerNum == "4")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Lizard");
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine($"Lizard eats paper,{name} wins");
                            playerScore++;
                        }
                        else if (playerNum == "5")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Spock");
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("Paper disproves Spock, computer wins");
                            computerScore++;
                        }
                        break;

                    /***********SCISSORS*****************
                    ******************************/
                    case 3:
                        if (playerNum == "1")
                        {

                            Console.WriteLine(Environment.NewLine +  $"{name} chose Rock");
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine($"Rock crushes scissors, {name} wins");
                            //player get point
                            playerScore++;
                        }

                        else if (playerNum == "2")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Paper");
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("Scissors cuts paper, computer wins");
                            computerScore++;
                        }
                        else if (playerNum == "3")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Scissors");
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("It is a tie");
                        }
                        else if (playerNum == "4")
                        {
                            Console.WriteLine(Environment.NewLine + $"{name} chose Lizard");
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("Scissors decapitates lizard, computer wins");
                            computerScore++;
                        }
                        else if (playerNum == "5")
                        {
                            Console.WriteLine(Environment.NewLine + $"{name} chose Spock");
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine($"Spock smashes scissors, {name} wins");
                            playerScore++;
                        }
                        break;
                    /***********LIZARD*****************
                    ******************************/
                    case 4:
                        if (playerNum == "1")
                        {
                            Console.WriteLine(Environment.NewLine + $"{name} chose Rock");
                            Console.WriteLine("Computer chose Lizard");
                            Console.WriteLine($"Rock crushes Lizard, {name} wins");
                            //player gets point
                            playerScore++;
                        }

                        else if (playerNum == "2")
                        {
                            Console.WriteLine(Environment.NewLine + $"{name} chose Paper");
                            Console.WriteLine("Computer chose Lizard");
                            Console.WriteLine("Lizard eats paper, computer wins");
                            computerScore++;
                        }
                        else if (playerNum == "3")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Scissors");
                            Console.WriteLine("Computer chose Lizard");
                            Console.WriteLine("Scissors decapitates lizard, computer wins");
                            computerScore++;
                        }
                        else if (playerNum == "4")
                        {
                            Console.WriteLine(Environment.NewLine + $"{name} chose Lizard");
                            Console.WriteLine("Computer chose Lizard");
                            Console.WriteLine("It is a tie");

                        }
                        else if (playerNum == "5")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Spock");
                            Console.WriteLine("Computer chose Lizard");
                            Console.WriteLine($"Lizard poisons Spock, computer wins");
                            computerScore++;
                        }
                        break;

                    /***********SPOCK*****************
                    ******************************/
                    case 5:
                        if (playerNum == "1")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Rock");
                            Console.WriteLine("Computer chose Spock");
                            Console.WriteLine("Spock vaporizes rock, computer wins");
                            //computer gets point
                            computerScore++;
                        }

                        else if (playerNum == "2")
                        {
                            Console.WriteLine(Environment.NewLine + $"{name} chose Paper");
                            Console.WriteLine("Computer chose Spock");
                            Console.WriteLine($"Paper disproves Spock, {name} wins");
                            playerScore++;
                        }
                        else if (playerNum == "3")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Scissors");
                            Console.WriteLine("Computer chose Spock");
                            Console.WriteLine("Spock smashes scissors, computer wins");
                            computerScore++;
                        }
                        else if (playerNum == "4")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Lizard");
                            Console.WriteLine("Computer chose Spock");
                            Console.WriteLine($"Lizard poisons Spock, {name} wins");
                            playerScore++;

                        }
                        else if (playerNum == "5")
                        {
                            Console.WriteLine(Environment.NewLine +  $"{name} chose Spock");
                            Console.WriteLine("Computer chose Spock");
                            Console.WriteLine("It is a tie!");

                        }
                        break;

                }
            }

            //Restart the game?
            Console.WriteLine(Environment.NewLine + "Press any key to play again, or X to end game");

            // Store player´s answer
            string answer = Console.ReadLine();

            //If player enters X the gameStart-variable will change to "false" and the loop will stop
            if (answer == "X" || answer == "x")
            {
                gameStart = false;
                Console.WriteLine($"{name} got {playerScore} points. Computer got {computerScore} points");

                //Message if player got the highest score
                if (playerScore > computerScore)
                {
                    Console.WriteLine(Environment.NewLine + $"Congratulations {name}, you got the most points!");
                }
            }

        }
    }
}