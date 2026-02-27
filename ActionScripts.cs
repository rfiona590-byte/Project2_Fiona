using Adventure;

class Actions()
{
    public static void Rest()
    {
        // clears console for new prompts
        Console.Clear();

        // rest prompt and choices
        Game.Dialouge("You decide to rest. You can either sleep normally, or you can sleep in one of your classic Maisy poses.", "white");
        Game.Dialouge("What do you do? Normal or unique?", "yellow");
        Game.choiceSelect = Console.ReadLine();
        //sees what is typed, and decides what happens from there
        if (Game.choiceSelect == "Normal" || Game.choiceSelect == "normal")
        {
            Console.Clear();
            Game.Dialouge("You decide to take a nap normally, as any normal dog would do.", "white");
            Game.Dialouge("Nobody makes fun of you. You gain 5 confidence points.", "green");
            Game.maisyConfidence += 5;
        }
        else
        {
            Game.Dialouge("                                                                                                    \r\n                  @@+@@@                                                                            \r\n                @ --  +++=    +@@@                                                                  \r\n               @ - +++++++++++++++ @@                                                               \r\n               @ +++++++++++++++++++- *     @@                                                      \r\n              @ ++++++++++++++++++++++ +++++++ @                                                    \r\n              @ *#+++++++#+#*++++++++++ ++++  - @                                                   \r\n             @ +++++++++++++++++++++++########## @                                                  \r\n             @   ++++++++     ++++++++ ###### ##*#@                                                 \r\n             @   +++++++ @     ++#++++++    =+ + - @                                                \r\n             @ +++++++++=    ++####+++++++++++++++: @                                               \r\n              @ +++++++++++++#######+++ ++++++++++++  @@                                            \r\n              @ +++++###############+  +++++++++++++++++ :@                                         \r\n             @ ++++++############  ++++++++++++++++++++++++ @                                       \r\n           :@ ++++++########## ###+++++++++++++++++++++++++++ @                                     \r\n          @ -:    =########## ###+++++++++++++++++++++++++++++ @                                    \r\n           @ -:  : ####++++  @@@@#+++++++++++++++++++++++++++++=+@                                  \r\n            @    ++++++++ @ @@@@@@+++++++++++++++++++++++++++++++ @                                 \r\n             -@        @@  @@@@@@@@@++++++++++++++++++++++++++++++ @                                \r\n                *@@@@@     @ @@@@@@@@@#####++++++++++++++++++++++++ @                               \r\n                            @ @@@@@@@#######++++++++++++++++++++++++ @                              \r\n                            @-@@@@@@@########++++++++++++++++++++++++@                              \r\n                             @@ @@@@@@ ######+++++++++ ++++++++++++++ @                             \r\n                               @ # @@@@ #####+++++++ ++++++  +++++++++    @@                        \r\n                                @ ##  @@@ ###++++++ ++++ =#+++++++++++ +++++ @                      \r\n                                @ ######:@:.#++++++ +++ #++++++++++++ ++++++ @                      \r\n                                 @ #####:@@@ +++++#:-  ##+++++++++++ @@% @@@                        \r\n                                  @-#### @@@ #+++*# - ###+++++++++++  ####+ @                       \r\n                                  @ #### @@@ ##### --#####+++++++++++*####### @@                    \r\n                                   @:### @@=#####     ######+++++++++########### +@.                \r\n                                   @ ### @@ #### @@@@@ ##########  @@@    :@@  ####@@               \r\n                                   @ ### @@#### @     *@@@@@@@@@              @ #%@@ @              \r\n                                  @@ ## @@ ### @                              @  @@ @               \r\n                                @ ####:@@ ###.@                                @@.@@                \r\n                               @ = @@@ @ #### @                                                     \r\n                               @  @  @@ #### @                                                      \r\n                                 -@  @ #### @                                                       \r\n                                    @+#### @                                                        \r\n                                   @ ##### @                                                        \r\n                                  @   # # @                                                         \r\n                                  @  @@ @ @                                                         \r\n                                   @   @@                                                           \r\n                                                                                                    ", "yellow");
            Game.Dialouge("You decide to push the laws of physics before you nap. You decide to choose between 3 poses.", "white");
            Game.Dialouge("1. Paralell legs   2. Loaf   3. Let fate decide", "yellow");
            Game.choiceSelect = Console.ReadLine();

            //selection prompts
            if (Game.choiceSelect == "1")
            {
                Game.Dialouge("You put alot of effort into making sure your front legs are perfectly parralell before you rest.", "white");
                Game.Dialouge("Everybody who passes you compliments you! They are shocked a dog is so good at geometry. Your confidence grows! You gain 15 confidence points.", "green");
                Game.Dialouge("The chickens aren't as good at math. Your legs humble them, and they lose 10 confidence points.", "red");
                Game.maisyConfidence += 15;
                Chicken.EnemyStrengthens(2,true);
            }
            else if (Game.choiceSelect == "2")
            {
                Game.Dialouge("You get inspired by your old cat pal. You decide to form a loaf in honor of him.", "white");
                Game.Dialouge("Nobody really notices. You gain 5 confidence points.", "green");
                Game.maisyConfidence += 5;
            }
            else if (Game.choiceSelect == "3")
            {
                Game.Dialouge("You flop around on the couch for a moment. After your done, you let whatever pose you're in be the pose you stick with.", "white");
                Game.Dialouge("People notice, and they laugh. They talk about how even the chickens can sit better than you. You're devastated, and you lose 10 confidence points.", "red");
                Game.Dialouge("The chickens overhear the conversation. They gain 5 confidence points.", "green");
                Game.maisyConfidence -= 10;
                Chicken.EnemyStrengthens(2);
            }
        }

        // calls continue or challenge prompt
        Game.Continue("resting");
    }

    public static void Observe()
    {
    // clears console for new prompts
        Console.Clear();

        // call observe prompt
        Game.Dialouge("You decide to observe your surroundings! Where do you observe?", "white");
        Game.Dialouge("Backyard or frontyard?", "yellow");
        Game.choiceSelect = Console.ReadLine();

        //back or front? results
        if (Game.choiceSelect == "Backyard" || Game.choiceSelect == "backyard")
        {
            Game.Dialouge("You  walk over to the back door. It is made of glass, so you can see through to the backyard.", "white");
            Game.Dialouge("There are so many creatures you can watch! Select the number of which creature you decide to watch.", "white");
            Game.Dialouge("1. Chickens   2. Birds   3. Tony   4. Squirrels ", "yellow");
            Game.choiceSelect = Console.ReadLine();

            //selection prompts
            if (Game.choiceSelect == "1")
            {
                Game.Dialouge("You look at the chickens. You notice one in particular, " + Game.name + ", and make eye contact with him.", "white");
                Game.Dialouge("You bark, to intimidate, but " + Game.name + " just finds it funny. You lose 15 confidence points.", "red");
                Game.Dialouge("The sad, pathetic look on your face makes " + Game.name + "'s confidence points get multiplied by 2!", "green");
                Game.maisyConfidence -= 15;
                Chicken.Confidence = Chicken.Confidence * 2;
            }
            else if (Game.choiceSelect == "3")
            {
                Game.Dialouge("Tony is doing dangerous tricks on a moterized vehicle in the backyard. You watch him, and imagine yourself in his place.", "white");
                Game.Dialouge("You imagine how intimadating you could be! The excitement alone makes you gain 30 confidence points!", "green");
                Game.Dialouge("Tony scares the life out of the chickens. " + Game.name + " is especially spooked, and notices that you saw the extent of that fear. Embarassed, " + Game.name + " loses confidence points.", "red");
                Game.maisyConfidence += 30;
                Chicken.EnemyStrengthens(8,true);
            }
            else if (Game.choiceSelect == "2" || Game.choiceSelect == "4")
            {
                Game.Dialouge("The backyard is especially barren. There is a distinct lack of birds or squirrels.", "white");
                Game.Dialouge("You immediatly get bored, and decide to do something else. Nobody gains confidence points.", "gray");
            }
        }
        else
        {
            Game.Dialouge("You go and sit on the top of the couch. It has a window at the perfect observing height.", "white");
            Game.Dialouge("There are an abundance of birds and squirrels in the front yard. You also notice soem chipmunks. Enter the number of what you want to watch.", "white");
            Game.Dialouge("1. Chipmunks   2. Birds   3. Squirrels ", "yellow");
            Game.choiceSelect = Console.ReadLine();

            if (Game.choiceSelect == "1")
            {
                Game.Dialouge("You spot a family of chipmunks. There is one parent, and three children.", "white");
                Game.Dialouge("You remember how recently you killed a chipmunk, and realize it must've belonged to that family. You feel guilty, and lose 10 confidence points.", "red");
                Chicken.EnemyStrengthens(3,true);
            }
            else if (Game.choiceSelect == "2")
            {
                Game.Dialouge("There are so many birds outside today! You watch them carefully, and begin to plan how you will rise up against " + Game.name + ".", "white");
                Game.Dialouge("safe to say, you have a pretty solid plan, and your confidence doubles!", "green");
                Game.Dialouge("In the backyard, " + Game.name + " feels an unexpected chill, like someone is planning evil things. " + Game.name + " loses 10 confidence points.", "red");
                Game.maisyConfidence = Game.maisyConfidence * 2;
                Chicken.EnemyStrengthens(3,true);
            }
            else if (Game.choiceSelect == "3")
            {
                Game.Dialouge("You notice a squirrel on a tree that you recognize, since it visits the front yard often. Sometimes, you both look at eachother.", "white");
                Game.Dialouge("At this point, you two are pretty much best friends! you assume that if you ever needed help, the squirrel would come help you. you gain 15 confidence points.", "green");
                Game.maisyConfidence += 15;
            }
        }

        // calls continue or challenge prompt
        Game.Continue("observing");
    }

    public static void Scavenge()
    {
        // clears console for new prompts
        Console.Clear();

        // call scavenge prompts
        Game.Dialouge("You are suddenly reminded that the kitchen exists. The thought of the kitchen makes you hungry! Do you wait for the automatic feeder to go off, or do you scavenge for food in the kitchen?", "white");
        Game.Dialouge("Wait or scavenge?", "yellow");
        Game.choiceSelect = Console.ReadLine();

        //selection prompts
        if (Game.choiceSelect == "Wait" || Game.choiceSelect == "wait")
        {
            Game.Dialouge("You decide to be a good little Maisy and wait for your food. When the sound eventually plays and your food drops down, you run to your bowl.", "white");
            Game.Dialouge("Tony yells at you to wait, and makes you do 5 spins in a row. You think you're getting food once you do the spins, but he tells you to sit and roll over 6 more times untill he lets you eat.", "white");
            Game.Dialouge(Game.name + " the chicken gathers all of the other chickens to watch you get bossed around. They all laugh, and you lose 20 confidence points.", "red");
            Game.Dialouge("Your public shaming raises " + Game.name + "'s confidence by 10 points.", "green");
            Game.maisyConfidence -= 20;
            Chicken.EnemyStrengthens(6);
        }
        else
        {
            Game.Dialouge("You decide to scavenge for food. You make your way into the kitchen, and notice that Fiona and Tony are making food.", "white");
            Game.Dialouge("You realize you could sniff around the floor for dropped scraps, or you could beg for a little treat.", "white");
            Game.Dialouge("What do you do? Beg or search?", "yellow");
            Game.choiceSelect = Console.ReadLine();

            // beg or search
            if (Game.choiceSelect == "Search" || Game.choiceSelect == "search")
            {
                Game.Dialouge("You put your dog abilities to work! You sniff around, hoping for a dropped piece of chicken or a shred of tomato.", "white");
                Game.Dialouge("You find something! You aren't sure what you found, but you eat it anyway. Tony notices and yells at you to drop it. You do, and " + Game.name + " notices, and laughs.", "white");
                Game.Dialouge("You're embarassed. The chickens don't have to listen to Tony. You lose 10 confidence points.", "red");
                Game.maisyConfidence -= 10;
            }
            else
            {
                Game.Dialouge("You decide to beg for food, as it is a particular skill of yours. You can either beg Tony or Fiona, as they're the only two in the kitchen.", "white");
                Game.Dialouge("Do you beg Tony or Fiona?", "yellow");
                Game.choiceSelect = Console.ReadLine();
                //fiona or tony results
                if (Game.choiceSelect == "Fiona" || Game.choiceSelect == "fiona")
                {
                    Game.Dialouge("You run up to Fiona. You get tangled in her legs and she stumbles over you.", "white");
                    Game.Dialouge("She instantly feels bad, and sneaks you a piece of chicken. This never happens! You arew so excited that you gain 25 confidence points!", "green");
                    Game.Dialouge(Game.name + " watches you eat the chicken, and shudders. " + Game.name + " loses 15 confidence points.", "red");
                    Game.maisyConfidence += 25;
                    Chicken.EnemyStrengthens(5);
                }
                else
                {
                    Game.Dialouge("You stare at Tony. He doesn't notice you. He continues to not notice you. Maybe he's doing it on purpose?", "white");
                    Game.Dialouge("You get bored waiting. You decdie to do soemthing else. Nobody gains or loses points.", "gray");
                }
            }
        }
        //calls challenge prompt
        Game.Continue("scavenging");
    }

    public static void Train()
    {
        // clears console for new prompts
        Console.Clear();

        // call train prompts
        Game.Dialouge("You have many toys that you can practice your battle moves against. There are no consiquences for what toy you chose, but some are better than others.", "white");
        Game.Dialouge("What toy do you choose? Type the number of the toy you chose.", "white");
        Game.Dialouge("1. LambChop    2. Old Cat Toys    3. Random Shoe    4. Well-Loved Squirrel", "yellow");
        Game.choiceSelect = Console.ReadLine();

        //toy results
        if (Game.choiceSelect == "1")
        {
            Game.Dialouge("You choose to practice on your LambChop toy.", "white");
            Game.Dialouge("It is easy to train! LambChop is about the size of " + Game.name + ".", "white");
            Game.Dialouge("Because it was so similar to your rival, you are filled with confidence, and gain 15 points!", "green");
            Game.maisyConfidence += 15;
        }
        else if (Game.choiceSelect == "2")
        {
            Game.Dialouge("You find some old cat toys under the couch. It belonged to your old pal Sushi. You decide to practice with the toys.", "white");
            Game.Dialouge("The toys don't help very much, but remembering Sushi makes you happy. You gain 5 confidence points.", "green");
            Game.maisyConfidence += 5;
        }
        else if (Game.choiceSelect == "3")
        {
            Game.Dialouge("You find a random, lonely shoe. It is made of a thick leather.", "white");
            Game.Dialouge("It is tough to train against. You push yourself harder and harder untill it is eventually easier to use your sick moves against it!", "white");
            Game.Dialouge("You properly trained your skills, and they have grown because of your unwillingness to give up. You gain 20 confidence points!", "green");
            Game.maisyConfidence += 20;
        }
        else
        {
            Game.Dialouge("You decide to train against your toy squirrel. Its been so loved by you that it is riddled with holes.", "white");
            Game.Dialouge("It is easy to train, but too easy. You still get your practice in, but it isn't as helpful.", "white");
            Game.Dialouge("You make sure you don't damage your toy. You still tried, so you gain 5 confidence points.", "green");
            Game.maisyConfidence += 5;
        }

        //calls challenge prompt
        Game.Continue("training");
    }
}