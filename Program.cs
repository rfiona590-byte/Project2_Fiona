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
        static string confidenceCheck = "";
        static int maisyConfidence = 0;
        static string moveOn = "";
        static string choiceSelect = "";
        static string nameSelect = "";
        static string confidenceSelect = "";
        static int chickenConfidence = 0;
        static string name = "";

        //starting the game. introduces game and sets initial maisy conidence
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

        // asks about confidence, adjusts intial confidence based on answer
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
            Actions();
            choiceSelect = Console.ReadLine();

            //checks what is entered, sends prompts based on choice
            if (choiceSelect == "1")
            {
                // clears console for new prompts
                Console.Clear();

                // rest prompt and choices
                Dialouge("You decide to rest. You can either sleep normally, or you can sleep in one of your classic Maisy poses.", "white");
                Dialouge("What do you do? Normal or unique?", "yellow");
                choiceSelect = Console.ReadLine();
                //sees what is typed, and decides what happens from there
                if (choiceSelect == "Normal" || choiceSelect == "normal")
                {
                    Console.Clear();
                    Dialouge("You decide to take a nap normally, as any normal dog would do.", "white");
                    Dialouge("Nobody makes fun of you. You gain 5 confidence points.", "green");
                    maisyConfidence = maisyConfidence + 5;
                }
                else
                {
                    Dialouge("                                                                                                    \r\n                  @@+@@@                                                                            \r\n                @ --  +++=    +@@@                                                                  \r\n               @ - +++++++++++++++ @@                                                               \r\n               @ +++++++++++++++++++- *     @@                                                      \r\n              @ ++++++++++++++++++++++ +++++++ @                                                    \r\n              @ *#+++++++#+#*++++++++++ ++++  - @                                                   \r\n             @ +++++++++++++++++++++++########## @                                                  \r\n             @   ++++++++     ++++++++ ###### ##*#@                                                 \r\n             @   +++++++ @     ++#++++++    =+ + - @                                                \r\n             @ +++++++++=    ++####+++++++++++++++: @                                               \r\n              @ +++++++++++++#######+++ ++++++++++++  @@                                            \r\n              @ +++++###############+  +++++++++++++++++ :@                                         \r\n             @ ++++++############  ++++++++++++++++++++++++ @                                       \r\n           :@ ++++++########## ###+++++++++++++++++++++++++++ @                                     \r\n          @ -:    =########## ###+++++++++++++++++++++++++++++ @                                    \r\n           @ -:  : ####++++  @@@@#+++++++++++++++++++++++++++++=+@                                  \r\n            @    ++++++++ @ @@@@@@+++++++++++++++++++++++++++++++ @                                 \r\n             -@        @@  @@@@@@@@@++++++++++++++++++++++++++++++ @                                \r\n                *@@@@@     @ @@@@@@@@@#####++++++++++++++++++++++++ @                               \r\n                            @ @@@@@@@#######++++++++++++++++++++++++ @                              \r\n                            @-@@@@@@@########++++++++++++++++++++++++@                              \r\n                             @@ @@@@@@ ######+++++++++ ++++++++++++++ @                             \r\n                               @ # @@@@ #####+++++++ ++++++  +++++++++    @@                        \r\n                                @ ##  @@@ ###++++++ ++++ =#+++++++++++ +++++ @                      \r\n                                @ ######:@:.#++++++ +++ #++++++++++++ ++++++ @                      \r\n                                 @ #####:@@@ +++++#:-  ##+++++++++++ @@% @@@                        \r\n                                  @-#### @@@ #+++*# - ###+++++++++++  ####+ @                       \r\n                                  @ #### @@@ ##### --#####+++++++++++*####### @@                    \r\n                                   @:### @@=#####     ######+++++++++########### +@.                \r\n                                   @ ### @@ #### @@@@@ ##########  @@@    :@@  ####@@               \r\n                                   @ ### @@#### @     *@@@@@@@@@              @ #%@@ @              \r\n                                  @@ ## @@ ### @                              @  @@ @               \r\n                                @ ####:@@ ###.@                                @@.@@                \r\n                               @ = @@@ @ #### @                                                     \r\n                               @  @  @@ #### @                                                      \r\n                                 -@  @ #### @                                                       \r\n                                    @+#### @                                                        \r\n                                   @ ##### @                                                        \r\n                                  @   # # @                                                         \r\n                                  @  @@ @ @                                                         \r\n                                   @   @@                                                           \r\n                                                                                                    ", "yellow");
                    Dialouge("You decide to push the laws of physics before you nap. You decide to choose between 3 poses.", "white");
                    Dialouge("1. Paralell legs   2. Loaf   3. Let fate decide", "yellow");
                    choiceSelect = Console.ReadLine();

                    //selection prompts
                    if (choiceSelect == "1")
                    {
                        Dialouge("You put alot of effort into making sure your front legs are perfectly parralell before you rest.", "white");
                        Dialouge("Everybody who passes you compliments you! They are shocked a dog is so good at geometry. Your confidence grows! You gain 15 confidence points.", "green");
                        Dialouge("The chickens aren't as good at math. Your legs humble them, and they lose 10 confidence points.", "red");
                        maisyConfidence = maisyConfidence + 15;
                        chickenConfidence = chickenConfidence - 10;
                    }
                    else if (choiceSelect == "2")
                    {
                        Dialouge("You get inspired by your old cat pal. You decide to form a loaf in honor of him.", "white");
                        Dialouge("Nobody really notices. You gain 5 confidence points.", "green");
                        maisyConfidence = maisyConfidence + 5;
                    }
                    else if (choiceSelect == "3")
                    {
                        Dialouge("You flop around on the couch for a moment. After your done, you let whatever pose you're in be the pose you stick with.", "white");
                        Dialouge("People notice, and they laugh. They talk about how even the chickens can sit better than you. You're devastated, and you lose 10 confidence points.", "red");
                        Dialouge("The chickens overhear the conversation. They gain 5 confidence points.", "green");
                        maisyConfidence = maisyConfidence - 10;
                        chickenConfidence = chickenConfidence + 5;
                    }
                }

                // calls continue or challenge prompt
                Continue("resting");
            }
            else if (choiceSelect == "2")
            {
                // clears console for new prompts
                Console.Clear();

                // call observe prompt
                Dialouge("You decide to observe your surroundings! Where do you observe?", "white");
                Dialouge("Backyard or frontyard?", "yellow");
                choiceSelect = Console.ReadLine();

                //back or front? results
                if (choiceSelect == "Backyard" || choiceSelect == "backyard")
                {
                    Dialouge("You  walk over to the back door. It is made of glass, so you can see through to the backyard.", "white");
                    Dialouge("There are so many creatures you can watch! Select the number of which creature you decide to watch.", "white");
                    Dialouge("1. Chickens   2. Birds   3. Tony   4. Squirrels ", "yellow");
                    choiceSelect = Console.ReadLine();

                    //selection prompts
                    if (choiceSelect == "1")
                    {
                        Dialouge("You look at the chickens. You notice one in particular, " + name + ", and make eye contact with him.", "white");
                        Dialouge("You bark, to intimidate, but " + name + " just finds it funny. You lose 15 confidence points.", "red");
                        Dialouge("The sad, pathetic look on your face makes " + name + "'s confidence points get multiplied by 2!", "green");
                        maisyConfidence = maisyConfidence - 15;
                        chickenConfidence = chickenConfidence * 2;
                    }
                    else if (choiceSelect == "3")
                    {
                        Dialouge("Tony is doing dangerous tricks on a moterized vehicle in the backyard. You watch him, and imagine yourself in his place.", "white");
                        Dialouge("You imagine how intimadating you could be! The excitement alone makes you gain 30 confidence points!", "green");
                        Dialouge("Tony scares the life out of the chickens. " + name + " is especially spooked, and notices that you saw the extent of that fear. Embarassed, " + name + "loses 30 confidence points.", "red");
                        maisyConfidence = maisyConfidence + 30;
                        chickenConfidence = chickenConfidence - 30;
                    }
                    else if (choiceSelect == "2" || choiceSelect == "4")
                    {
                        Dialouge("The backyard is especially barren. There is a distinct lack of birds or squirrels.", "white");
                        Dialouge("You immediatly get bored, and decide to do something else. Nobody gains confidence points.", "gray");
                    }
                }
                else
                {
                    Dialouge("You go and sit on the top of the couch. It has a window at the perfect observing height.", "white");
                    Dialouge("There are an abundance of birds and squirrels in the front yard. You also notice soem chipmunks. Enter the number of what you want to watch.", "white");
                    Dialouge("1. Chipmunks   2. Birds   3. Squirrels ", "yellow");
                    choiceSelect = Console.ReadLine();

                    if (choiceSelect == "1")
                    {
                        Dialouge("You spot a family of chipmunks. There is one parent, and three children.", "white");
                        Dialouge("You remember how recently you killed a chipmunk, and realize it must've belonged to that family. You feel guilty, and lose 10 confidence points.", "red");
                        maisyConfidence = maisyConfidence - 10;
                    }
                    else if (choiceSelect == "2")
                    {
                        Dialouge("There are so many birds outside today! You watch them carefully, and begin to plan how you will rise up against " + name + ".", "white");
                        Dialouge("safe to say, you have a pretty solid plan, and your confidence doubles!", "green");
                        Dialouge("In the backyard, " + name + " feels an unexpected chill, like someone is planning evil things. " + name + " loses 10 confidence points.", "red");
                        maisyConfidence = maisyConfidence * 2;
                        chickenConfidence = chickenConfidence - 10;
                    }
                    else if (choiceSelect == "3")
                    {
                        Dialouge("You notice a squirrel on a tree that you recognize, since it visits the front yard often. Sometimes, you both look at eachother.", "white");
                        Dialouge("At this point, you two are pretty much best friends! you assume that if you ever needed help, the squirrel would come help you. you gain 15 confidence points.", "green");
                        maisyConfidence = maisyConfidence + 15;
                    }
                }

                // calls continue or challenge prompt
                Continue("observing");
            }
            else if (choiceSelect == "3")
            {
                // clears console for new prompts
                Console.Clear();

                // call scavenge prompts
                Dialouge("You are suddenly reminded that the kitchen exists. The thought of the kitchen makes you hungry! Do you wait for the automatic feeder to go off, or do you scavenge for food in the kitchen?", "white");
                Dialouge("Wait or scavenge?", "yellow");
                choiceSelect = Console.ReadLine();

                //selection prompts
                if (choiceSelect == "Wait" || choiceSelect == "wait")
                {
                    Dialouge("You decide to be a good little Maisy and wait for your food. When the sound eventually plays and your food drops down, you run to your bowl.", "white");
                    Dialouge("Tony yells at you to wait, and makes you do 5 spins in a row. You think you're getting food once you do the spins, but he tells you to sit and roll over 6 more times untill he lets you eat.", "white");
                    Dialouge(name + " the chicken gathers all of the other chickens to watch you get bossed around. They all laugh, and you lose 20 confidence points.", "red");
                    Dialouge("Your public shaming raises " + name + "'s confidence by 10 points.", "green");
                    maisyConfidence = maisyConfidence - 20;
                    chickenConfidence = chickenConfidence + 10;
                }
                else
                {
                    Dialouge("You decide to scavenge for food. You make your way into the kitchen, and notice that Fiona and Tony are making food.", "white");
                    Dialouge("You realize you could sniff around the floor for dropped scraps, or you could beg for a little treat.", "white");
                    Dialouge("What do you do? Beg or search?", "yellow");
                    choiceSelect = Console.ReadLine();

                    // beg or search
                    if (choiceSelect == "Search" || choiceSelect == "search")
                    {
                        Dialouge("You put your dog abilities to work! You sniff around, hoping for a dropped piece of chicken or a shred of tomato.", "white");
                        Dialouge("You find something! You aren't sure what you found, but you eat it anyway. Tony notices and yells at you to drop it. You do, and " + name + " notices, and laughs.", "white");
                        Dialouge("You're embarassed. The chickens don't have to listen to Tony. You lose 10 confidence points.", "red");
                        maisyConfidence = maisyConfidence - 10;
                    }
                    else
                    {
                        Dialouge("You decide to beg for food, as it is a particular skill of yours. You can either beg Tony or Fiona, as they're the only two in the kitchen.", "white");
                        Dialouge("Do you beg Tony or Fiona?", "yellow");
                        choiceSelect = Console.ReadLine();
                        //fiona or tony results
                        if (choiceSelect == "Fiona" || choiceSelect == "fiona")
                        {
                            Dialouge("You run up to Fiona. You get tangled in her legs and she stumbles over you.", "white");
                            Dialouge("She instantly feels bad, and sneaks you a piece of chicken. This never happens! You arew so excited that you gain 25 confidence points!", "green");
                            Dialouge(name + " watches you eat the chicken, and shudders. " + name + " loses 15 confidence points.", "red");
                            maisyConfidence = maisyConfidence + 25;
                            chickenConfidence = chickenConfidence - 15;
                        }
                        else
                        {
                            Dialouge("You stare at Tony. He doesn't notice you. He continues to not notice you. Maybe he's doing it on purpose?", "white");
                            Dialouge("You get bored waiting. You decdie to do soemthing else. Nobody gains or loses points.", "gray");
                        }
                    }
                }
                //calls challenge prompt
                Continue("scavenging");
            }
            else if (choiceSelect == "4")
            {
                // clears console for new prompts
                Console.Clear();

                // call train prompts
                Dialouge("You have many toys that you can practice your battle moves against. There are no consiquences for what toy you chose, but some are better than others.", "white");
                Dialouge("What toy do you choose? Type the number of the toy you chose.", "white");
                Dialouge("1. LambChop    2. Old Cat Toys    3. Random Shoe    4. Well-Loved Squirrel", "yellow");
                choiceSelect = Console.ReadLine();

                //toy results
                if (choiceSelect == "1")
                {
                    Dialouge("You choose to practice on your LambChop toy.", "white");
                    Dialouge("It is easy to train! LambChop is about the size of " + name + ".", "white");
                    Dialouge("Because it was so similar to your rival, you are filled with confidence, and gain 15 points!", "green");
                    maisyConfidence = maisyConfidence + 15;
                }
                else if (choiceSelect == "2")
                {
                    Dialouge("You find some old cat toys under the couch. It belonged to your old pal Sushi. You decide to practice with the toys.", "white");
                    Dialouge("The toys don't help very much, but remembering Sushi makes you happy. You gain 5 confidence points.", "green");
                    maisyConfidence = maisyConfidence + 5;
                }
                else if (choiceSelect == "3")
                {
                    Dialouge("You find a random, lonely shoe. It is made of a thick leather.", "white");
                    Dialouge("It is tough to train against. You push yourself harder and harder untill it is eventually easier to use your sick moves against it!", "white");
                    Dialouge("You properly trained your skills, and they have grown because of your unwillingness to give up. You gain 20 confidence points!", "green");
                    maisyConfidence = maisyConfidence + 20;
                }
                else
                {
                    Dialouge("You decide to train against your toy squirrel. Its been so loved by you that it is riddled with holes.", "white");
                    Dialouge("It is easy to train, but too easy. You still get your practice in, but it isn't as helpful.", "white");
                    Dialouge("You make sure you don't damage your toy. You still tried, so you gain 5 confidence points.", "green");
                    maisyConfidence = maisyConfidence + 5;
                }

                //calls challenge prompt
                Continue("training");
            }
            else if (choiceSelect == "5")
            {
                // clears console for new prompts
                Console.Clear();
                Challenge();
            }
            else
            {
                Console.Clear();
                Dialouge("That's not an option. Try again.", "red");
                MainGame();
            }

        }

        //challenging the chicken!
        static void Challenge()
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

        //ending
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

        //action options, also shoes confidence points, and reads what option is picked
        static void Actions()
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

        // after action is done, prompt for if you want to keep doing things or if you want to challenge
        static void Continue(string choiceOption)
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

        //setting text color
        static void Dialouge(string message, string color)
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