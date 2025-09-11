namespace TextAdventure;
public class Program
{
    

    public static void Main()
    {
        Enemy enemy = new Enemy();
        Mining mining = new Mining();
        Inventory inventory = new Inventory();
        Woodcutting woodcutting = new Woodcutting();
        Player player = new Player();
        NewGame(player);

        while (true)
        {
            
            
            Console.Clear();
            UI.ConsoleDefault(player, woodcutting, mining, enemy);
            UI.WriteLine("Well.. What's your next move!?");
            UI.WriteLine("");
            UI.WriteLine("1. Adventure");
            UI.WriteLine("2. Mine");
            UI.WriteLine("3. Woodcutting");
            UI.WriteLine("4. Inventory");
            UI.WriteLine("5. Town");
            UI.WriteLine("6. Rest");
            UI.WriteLine("7. Help");
            UI.WriteLine("8. Exit");
            
            string input = Console.ReadLine().Trim().ToLower();
            Console.WriteLine(input);
            if (input == "1" || input == "adventure")
            {
                
            }
            else if (input == "2" || input == "mine")
            {
                mining.Mine(inventory);
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Mine again?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No"); 
                    input = Console.ReadLine().Trim().ToLower();

                    if (input == "1" || input == "yes")
                    {
                        mining.Mine(inventory);
                    }
                    else if (input == "2" || input == "no")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You did not enter a valid input");
                        Console.ReadKey();
                    }
                }
            }
            else if (input == "3" || input == "woodcutting")
            {
                woodcutting.CutWood(inventory);
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Cut again?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No"); 
                    input = Console.ReadLine().Trim().ToLower();

                    if (input == "1" || input == "yes")
                    {
                        woodcutting.CutWood(inventory);
                    }
                    else if (input == "2" || input == "no")
                    {
                        break;
                    }
                    else
                    {
                        UI.ConsoleDefault(player, woodcutting, mining, enemy);
                        UI.WriteLine("You did not enter a valid input");
                        Console.ReadKey();
                    }
                }
            }
            else if (input == "4" || input == "inventory")
            {
                inventory.PrintInventory();
                Console.ReadKey();
            }
            else if (input == "5" || input == "town")
            {
                
            }
            else if (input == "6" || input == "rest")
            {
                
            }
            else if (input == "7" || input == "help")
            {
                
            }
            else if (input == "8" || input == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                UI.ConsoleDefault(player, woodcutting, mining, enemy);
                UI.WriteLine("You did not enter a valid input");
                Console.ReadKey();
            }

        }
    }

    private static void NewGame(Player player)
    {
        // Prologue story, ran once and never again.
        
        string choice = null;
        
        PlayIntro();
        
        // 5 Empty lines
        Console.Clear();
        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");

        UI.TypeWriteLine($"Hey! ... Who are you?");
        UI.TypeWrite("Enter your name: ");
        player.Name = Console.ReadLine();
        UI.TypeWriteLine($"Oh... Hey {player.Name}... I'm glad you're okay!");
        UI.TypeWriteLine("");
        UI.TypeWriteLine("1. What happened?");
        UI.TypeWriteLine("2. Who are you?");
        UI.TypeWriteLine("");
        UI.TypeWrite("Enter your choice: ");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            UI.TypeWriteLine("I don't know.. I heard a loud sound and then saw you falling from high above..");
        }
        else if (choice == "2")
        {
            UI.TypeWriteLine("I'm the elven mage of Isakeya, you're currently in the forest of Hitoria.");
        }

        choice = null;

        UI.TypeWriteLine("*I seem to remember nothing of my life, where I'm at, or anything but my name.*");
        UI.TypeWriteLine("I suppose you wish to know how you ended up here..");
        UI.TypeWriteLine("");
        UI.TypeWriteLine("1. Yes, of course");
        UI.TypeWriteLine("2. No.");
        UI.TypeWriteLine("");
        UI.TypeWrite("Enter your choice: ");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            UI.TypeWriteLine("I'm afraid you'll have to figure that out by yourself.");
        }

        if (choice == "2")
        {
            return;
        }

        choice = null;
        
        UI.TypeWriteLine("");
        UI.TypeWriteLine("1. So what am I even supposed to do?");
        UI.TypeWriteLine("2. Well.. I'll get going then ¯\\_(ツ)_/¯");
        UI.TypeWriteLine("");
        UI.TypeWrite("Enter your choice: ");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            UI.TypeWriteLine("Well, there's lots of thing you can do here in Hitoria!");
            UI.TypeWriteLine("For example! We need lots of help with monsters roaming the area.");
            UI.TypeWriteLine("On top of that, you seem rather weak at the moment, you can train that up!");
            UI.TypeWriteLine("You can mine ores/gems and chop wood for different forms of logs");
            UI.TypeWriteLine("You can use these resources to craft new weapons and other stuff");
            UI.TypeWriteLine("");
            UI.TypeWriteLine("1. Alright, Thanks for your help!");
            UI.TypeWriteLine("2. I'll get going then");
            UI.TypeWriteLine("");
            UI.TypeWrite("Enter your choice: ");
            choice = Console.ReadLine();
        }








    }

    public static void PlayIntro()
    {
        Console.Clear();
        // AScii text generator credit: https://patorjk.com/software/taag/
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                              .___________. __________   ___ .___________.        ___       _______  ____    ____  _______ .__   __. .___________. __    __  .______       _______ ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("                              |           ||   ____\\  \\ /  / |           |       /   \\     |       \\ \\   \\  /   / |   ____||  \\ |  | |           ||  |  |  | |   _  \\     |   ____|");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("                              `---|  |----`|  |__   \\  V  /  `---|  |----`      /  ^  \\    |  .--.  | \\   \\/   /  |  |__   |   \\|  | `---|  |----`|  |  |  | |  |_)  |    |  |__   ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("                                  |  |     |   __|   >   <       |  |          /  /_\\  \\   |  |  |  |  \\      /   |   __|  |  . `  |     |  |     |  |  |  | |      /     |   __|  ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("                                  |  |     |  |____ /  .  \\      |  |         /  _____  \\  |  '--'  |   \\    /    |  |____ |  |\\   |     |  |     |  `--'  | |  |\\  \\----.|  |____ ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("                                  |__|     |_______/__/ \\__\\     |__|        /__/     \\__\\ |_______/     \\__/     |_______||__| \\__|     |__|      \\______/  | _| `._____||_______|\n");
            System.Threading.Thread.Sleep(2500);
    }

    public void CreateEnemy(Enemy enemy)
    {
        Enemy x = new Enemy();
        x.GenerateEnemy("goblin");
        enemy = x;
    }
}