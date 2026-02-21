using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adventure
{
    class Chicken
    {
        //attributes for chicken you challenge at end
        public string Name; //chicken/mortal enemy name
        public string StartingConfidence;
        public int Confidence;

        //constructs chicken
        public Chicken(string selectName, string inputChickenConfidence)
        {
            Name = selectName;
            StartingConfidence = inputChickenConfidence;
            Confidence = int.Parse(inputChickenConfidence);
        }

    }
    class Program
    {
        static void Main()
        {
            //starting point
            Game.StartGame();
            Console.Clear();
            Game.MainGame();
            Console.ReadKey();
        }
    }
    public static class Game
    {
        //setting up variables
        public static string confidenceCheck = "";
        public static int maisyConfidence = 0;
        public static string moveOn = "";
        public static string choiceSelect = "";
        public static string nameSelect = "";
        public static string confidenceSelect = "";
        public static int chickenConfidence = 0;
        public static string name = "";

        /// <summary>
        /// starting the game. introduces game and sets initial maisy conidence
        /// </summary>
        public static void StartGame()
        {
            Dialouge("Welcome to a Maisey Misadventure!", "cyan");
            Console.WriteLine("--------------------------------");
            //maisy art
            Dialouge("                                                                        :@@@@@@@@                  \r\n                     @@@@@@@@+              @@@@@@@@@ @@@@@@@@:       @@@  ++++    @@@@             \r\n                @@@@    .+++  @@@@@    :@@@   ++++      ++++:  @@@@@@@  ++++  #######- @@@          \r\n             @@@  ######### +++++   +@@  +++#+#++++++++++++#+##+++  ++++++ ############## @@        \r\n           @@ :#############..+++++++ ++++++#+#+++++++++++#++#++++++ ++++ ################  @@      \r\n         @@ ################## ++++ ++    ++++++++++++++++++++++    + =+ ################### @@     \r\n         @ #################### + ++ @@     .+++++++++++++++++ @ @@   + .################## @@      \r\n         @  #################### ++          +++++++++++++++++ @      ++ ###############- @@@       \r\n          @@ ################## +++++   +++++++++++++++++++++++++     +++ ############# @@          \r\n            @@ ############### #++++++++++++++++  ::::::  ++++++++++++++++ ########### @@           \r\n              @@ ############ ###+++++++++++++ ::: ::::::::: ++++++*#####++         # @@            \r\n                @@          + ####++++++++++ ::     ::::    :..++++######++ +++++++= @              \r\n                  @@ ++++++++ ###########+++ :.     :::     :: ++++#######+   ++++ *@               \r\n                    @@       :##########+++++- ::::::::::::::: ++++######## @@@@@@@@                \r\n                      @@@@@@@@ ########+++++++++  :::::::  =++++++++####### @                       \r\n                            @@ ########+++++++++++ ::::  +++++++++++####### @                       \r\n                            @@ ########+++++++++++++  +++++++++++++++###### @                       \r\n                            @@ ########++++++++++++++++++++++++++++++*##### @                       \r\n                             @ #######+ ++++++++++++++++++++++++++++ +##### @                       \r\n                            @@ #######* ++++++++  +++++++++ +++++++.=##### @@                       \r\n                            @ +++######       +++++++++++++++  +++ +####* @@                        \r\n                           =@ ++++######++++++++++++++++++++++++++#####+.@@                         \r\n                           %@ +++++######++++++++++++++++++++ +#######++ @@                         \r\n                            @ ++++++########++++*   ##################+++@@                         \r\n                            @@ +++++++###############################++++ @                         \r\n                             @ +++++++++############################+++++ @                         \r\n                             @@ ++++++++++########################++++++=@@                         \r\n                              @@ ++++++++++######################+++++++ @@                         \r\n                               @@  ++++++++++#####@@@@@@########++++++  : @                         \r\n                              @@ :: # ++++++++##@@@@@@@@@@@@@@%++++ :::::: @=                       \r\n                              @ ::: # :  +++++++@@@@@@@@@@@@@@@  ::::  :::: @                       \r\n                             @@ :: ### :::::    .          ## ::::::::: ::: @@                      \r\n                             @% :: ###:::::::::::::::::::::## :::::::::: :: @@                      \r\n                            @ ++ : ## :::::::::::::::::::: ###::::::::::    @@                      \r\n                          @@ ++++  # ::::::::::::::::::::::### :::::::  ++++ @@                     \r\n                         @@ ++++++  ++    ::::::::::::::::: ## ::  ++++++++++ @@                    \r\n                        %@ +++++++++++++++++++-       ::::: ###@++++++++++++++ @@                   \r\n                        @ ++++++++++++++++++++++@@@@@@@@@@@@  @++++++++++++++++ @@                  \r\n                       @@ +++++++++++++++++++++++@@@@@@@@@@@@@@+++++++++++++++++ @#                 \r\n                       @%+++++++++++@++++++++++++@@@@@@@@@@@@@@+++++++###++++++++ @                 \r\n                       @@ +++++++++####++++++++++*@@@@@@@@@@@@@###########+++++++-@@                \r\n                        @ +++++++#######*+++++++++@@@@@@@@@@@@@############+++++++ @@               \r\n                                                                                                   ", "yellow");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("All your life, you've been haunted by the chickens that live in your backyard.");
            Console.WriteLine("Is today the day you finally win?!?");
            Dialouge("Press enter to start!", "yellow");
            moveOn = Console.ReadLine();
            SetConfidence();
        }

        /// <summary>
        /// asks about confidence, adjusts intial confidence based on answer
        /// </summary>
        static void SetConfidence()
        {
            Console.Clear();
            Dialouge("The day begins! Are you feeling confident?", "yellow");
            Console.WriteLine("  ");
            Console.WriteLine("Yes/No");
            Console.WriteLine("  ");
            confidenceCheck = Console.ReadLine();

            // sets initial maisy confidence
            if (confidenceCheck == "Yes" || confidenceCheck == "yes")
            {
                maisyConfidence = 10;
            }
            else
            {
                maisyConfidence = 5;
            }

            Console.WriteLine("  ");
            Dialouge("You start your day with " + maisyConfidence + " confidence points.", "green");
            Console.WriteLine("Each action you make will either add or subtract from your confidence. Choice wisely, your actions can have consequences!!");
            // creates chicken character
            Console.WriteLine("   ");
            Console.WriteLine("Before we begin, you must tell us the name of your mortal enemy. Enter it below.");
            nameSelect = Console.ReadLine();
            Dialouge("Now, from a scale of 1-75... How badly do you hate them??? Enter below.", "yellow");
            confidenceSelect = Console.ReadLine();
            Chicken enemy = new Chicken(nameSelect, confidenceSelect);
            chickenConfidence = enemy.Confidence;
            name = enemy.Name;
            Dialouge("   _\r\n _/ }\r\n`>' \\\r\n `|  \\\r\n  |  /'-.    .-.\r\n  \\'   ';`--' .'\r\n   \\'.   `'-./\r\n    '.`\"-..-;`\r\n      `;-..'\r\n      _| _|\r\n       /` /`", "red");
            Dialouge("Starting " + name + " the chicken confidence points: " + chickenConfidence, "cyan");
            Console.WriteLine("");
            Dialouge("Press enter to continue.", "yellow");
            moveOn = Console.ReadLine();
            Console.Clear();

        }

        //main game
        public static void MainGame()
        {
            Console.Clear();
            ShowActions();
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Actions.Rest();
                    break;

                case 2:
                    Actions.Observe();
                    break;

                case 3:
                    Actions.Scavenge();
                    break;

                case 4:
                    Actions.Train();
                    break;

                case 5:
                    // clears console for new prompts
                    Console.Clear();
                    Challenge();
                    break;

                default:
                    Console.Clear();
                    Dialouge("That's not an option. Try again.", "red");
                    MainGame();
                    break;

            }


        }

        /// <summary>
        /// challenging the chicken!
        /// </summary>
        public static void Challenge()
        {
            Console.Clear();
            Dialouge("IT IS TIME! Do you have what it takes??", "white");
            Dialouge("Below are the current point standings.", "white");
            Dialouge("    ", "red");
            Dialouge("Your points : " + maisyConfidence, "cyan");
            Dialouge(name + " the chicken points : " + chickenConfidence, "cyan");
            Dialouge("    ", "white");
            Dialouge("This is your last chance. Are you truly ready? Or are you having second thoughts?", "white");
            Dialouge("Continue training? Yes/no", "yellow");
            choiceSelect = Console.ReadLine();
            if (choiceSelect == "No" || choiceSelect == "no")
            {
                Console.Clear();
                Dialouge("You run out into the yard, ready to defend yourself!", "white");
                Dialouge("For the final time, you ask yourself: Are you confident? Yes or no?", "yellow");
                choiceSelect = Console.ReadLine();
                //yes or no, getting a boost if yes
                if (choiceSelect == "No" || choiceSelect == "no")
                {
                    Dialouge("You decide to just go into it, without anymore confidence. Youy don't gain any confidence points.", "gray");
                }
                else
                {
                    Dialouge("You get a final boost of confidence! Your confidents gets a bonus 15 points!!", "green");
                    maisyConfidence = maisyConfidence + 15;
                }
                Dialouge("    ", "white");
                Dialouge("You enter the battle with " + maisyConfidence + " confidence points. Press enter to see who wins!", "white");
                moveOn = Console.ReadLine();
                Console.Clear();
                //deciding what happens!
                int confidenceDiff = chickenConfidence - maisyConfidence;
                if (confidenceDiff < 0)
                {
                    Dialouge("your confidence is significantally higher than " + name + "'s!", "white");
                    Dialouge("What partakes is barely even a battle. You clown on " + name + " so hard that once the battle is done, the chickens disowns them!", "white");
                    Dialouge("YOU WIN!!! Hit enter to recieve your prize!", "green");
                    moveOn = Console.ReadLine();
                    Ending("win");
                }
                else if (confidenceDiff >= 0 && confidenceDiff <= 25)
                {
                    Dialouge("You run into the battle, and your confidence is evenly matched.", "white");
                    Dialouge("A tough, long fight ensues. You gather an audience. The chcikens cheer for " + name + ", and everyone else cheers for you.", "white");
                    Dialouge("The fight is so close it has to be determined by a coin flip!!! A coin is promptly flipped. Do you call heads or tails?", "yellow");
                    choiceSelect = Console.ReadLine();
                    if (choiceSelect == "heads" || choiceSelect == "Heads")
                    {
                        Dialouge("You call heads, and the coin lands on..... Heads!!!!", "white");
                        Dialouge("You win the coin toss, and in turn you win!!!", "green");
                        Dialouge(name + " accepts the loss, fair and square. The chickens retreat to their shed.", "white");
                        Dialouge("Hit enter to claim your prize!", "white");
                        moveOn = Console.ReadLine();
                        Ending("win");
                    }
                    else
                    {
                        Dialouge("You call tails, and the coin lands on..... Heads. Uh oh.", "white");
                        Dialouge("You lost the coin toss. " + name + " wins.", "red");
                        Dialouge("You walk away, a sad song playing in your head. Press enter to continue.", "white");
                        moveOn = Console.ReadLine();
                        Ending("loss");
                    }
                }
                else if (confidenceDiff > 25)
                {
                    Dialouge("your confidence is lower than " + name + "'s.", "white");
                    Dialouge("You don't even stand a chamnce. After about 45 seconds, you retreat back to the house with your stubby tail tucked between your legs.", "white");
                    Dialouge("You lost. You barely even stood a chance. Hit enter to continue.", "green");
                    moveOn = Console.ReadLine();
                    Ending("loss");
                }
            }
            else
            {
                Console.Clear();
                MainGame();
            }
        }

        /// <summary>
        ///  ending
        /// </summary>
        /// <param name="result"> reads "win" if the player won the game, anything less if the player lost the game.</param>
        static void Ending(string result)
        {
            Console.Clear();
            //checks if win or loss
            if (result == "win")
            {
                Dialouge("CONGRATULATIONS! YOU WON!", "green");
                Dialouge("You now have infinte confidence! Nobody can get you down!", "white");
                Dialouge("Everyone was so impressed that they rewarded you an entire chicken thigh!", "white");
                Dialouge("You enjoy your prize happily. You are a new dog now.", "white");
                Dialouge("GAME END!", "red");
            }
            else
            {
                Dialouge("You lost. Better luck next time.", "red");
                Dialouge("   _\r\n _/ }\r\n`>' \\\r\n `|  \\\r\n  |  /'-.    .-.\r\n  \\'   ';`--' .'\r\n   \\'.   `'-./\r\n    '.`\"-..-;`\r\n      `;-..'\r\n      _| _|\r\n       /` /`", "red");
                Dialouge("Not everything is bad, though. Tomorrow is another day. Do you try again, or just accept how pitiful you are?", "white");
                Dialouge("Try again? Yes/no", "yellow");
                choiceSelect = Console.ReadLine();
                if (choiceSelect == "Yes" || choiceSelect == "yes")
                {
                    Dialouge("You don't let this get you down! you go to bed, ready to start tomorrow a fresh new Maisey.. Hit enter to try again!", "white");
                    maisyConfidence = 0;
                    moveOn = Console.ReadLine();
                    Console.Clear();
                    MainGame();
                }
                else
                {
                    Dialouge("You give up, officially. Hopefully nobody remembers this day. But you will.", "white");
                    Dialouge("You always will. And so will" + name + ".", "white");
                    Dialouge("GAME END!", "red");
                }
            }
        }

        /// <summary>
        /// Displays action options, also shows confidence points.
        /// </summary>
        static void ShowActions()
        {
            Console.Clear();
            Console.WriteLine(" ");
            Dialouge("Right now, here are the current point standings:", "white");
            Console.WriteLine(" ");
            Dialouge("Your points : " + maisyConfidence, "cyan");
            Dialouge(name + " the chicken points : " + chickenConfidence, "cyan");
            Console.WriteLine(" ");
            Dialouge("As a dog, you have many activities you can partake in.", "white");
            Dialouge("Type the number to select one of the actvities below.", "white");

            //list of dialouge options
            string[] initialChoices =
            {
                "1. Rest",
                "2. Observe",
                "3. Scavenge",
                "4. Train",
                "5. Challenge!"
            };

            //for loop displaying each option
            foreach (string choice in initialChoices)
            {
                Dialouge(choice, "yellow");
            }
        }

        /// <summary>
        /// after action is done, prompt for if you want to keep doing things or if you want to challenge
        /// </summary>
        /// <param name="choiceOption"> The name of the action that was just done. </param>
        public static void Continue(string choiceOption)
        {
            Console.WriteLine("---------------------------");
            Dialouge("You finished " + choiceOption + "!", "white");
            //Displays current point standings
            Console.WriteLine(" ");
            Dialouge("Right now, here are the current point standings:", "white");
            Console.WriteLine(" ");
            Dialouge("Your points : " + maisyConfidence, "cyan");
            Dialouge(name + " the chicken points : " + chickenConfidence, "cyan");
            Console.WriteLine(" ");

            Dialouge("Do you want to continue with your day, or do you think you are finally ready to challenge the chickens?!", "yellow");
            Dialouge("Continue with your day? Yes/no", "white");
            choiceSelect = Console.ReadLine();
            //if yes, goes to challenge screen. if no, then go back to choice select
            if (choiceSelect == "No" || choiceSelect == "no")
            {
                Console.Clear();
                Challenge();
            }
            else
            {
                Console.Clear();
                MainGame();

            }
        }

        /// <summary>
        /// Displays a string to the console of the chosen color
        /// </summary>
        /// <param name="message"> The sting to be Displayed. </param>
        /// <param name="color"> The desired color of the text. Use all lowercase. </param>
        public static void Dialouge(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; } // used for losing points
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; } // used for gaining points
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; } // used for prompts
            else if (color == "cyan")
            { Console.ForegroundColor = ConsoleColor.Cyan; } // used to display maisy and chicken confidence
            else if (color == "gray")
            { Console.ForegroundColor = ConsoleColor.DarkGray; } // used neutral events
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}