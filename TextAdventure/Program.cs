namespace TextAdventure;
public class Program
{
    
    
    public static async void PlayIntroTest()
    {
        Console.Clear();
        // AScii text generator credit: https://patorjk.com/software/taag/
        
        await Task.Delay(250);
        Console.WriteLine(".___________. __________   ___ .___________.        ___       _______  ____    ____  _______ .__   __. .___________. __    __  .______       _______ ");
        await Task.Delay(250);
        Console.WriteLine("|           ||   ____\\  \\ /  / |           |       /   \\     |       \\ \\   \\  /   / |   ____||  \\ |  | |           ||  |  |  | |   _  \\     |   ____|");
        await Task.Delay(250);
        Console.WriteLine("`---|  |----`|  |__   \\  V  /  `---|  |----`      /  ^  \\    |  .--.  | \\   \\/   /  |  |__   |   \\|  | `---|  |----`|  |  |  | |  |_)  |    |  |__   ");
        await Task.Delay(250);
        Console.WriteLine("    |  |     |   __|   >   <       |  |          /  /_\\  \\   |  |  |  |  \\      /   |   __|  |  . `  |     |  |     |  |  |  | |      /     |   __|  ");
        await Task.Delay(250);
        Console.WriteLine("    |  |     |  |____ /  .  \\      |  |         /  _____  \\  |  '--'  |   \\    /    |  |____ |  |\\   |     |  |     |  `--'  | |  |\\  \\----.|  |____ ");
        await Task.Delay(250);
        Console.WriteLine("    |__|     |_______/__/ \\__\\     |__|        /__/     \\__\\ |_______/     \\__/     |_______||__| \\__|     |__|      \\______/  | _| `._____||_______|\n");

        Console.ReadLine();
            
    }
    public static void Main()
    {
        Mining mining = new Mining();
        Inventory inventory = new Inventory();
        Woodcutting woodcutting = new Woodcutting();
        Player player = new Player();
        NewGame(player);
        PlayIntroTest();

        while (true)
        {
            
            
            Console.Clear();
            UI.ConsoleDefault();
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
                        UI.ConsoleDefault();
                        UI.WriteLine("You did not enter a valid input");
                        Console.ReadKey();
                    }
                }
            }
            else if (input == "4" || input == "inventory")
            {
                
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
                UI.ConsoleDefault();
                UI.WriteLine("You did not enter a valid input");
                Console.ReadKey();
            }

        }
    }

    private static void NewGame(Player player)
    {
        

        /*
        Console.Write("Enter your name: ");
        string input = Console.ReadLine();
        player.Name = input;
        Console.Clear();

        Console.WriteLine($"{player.Name} wakes up in a clearing, forest all around them.");
        Console.ReadKey();*/
    }

    public async void PlayIntro()
    {
        Console.Clear();
        // AScii text generator credit: https://patorjk.com/software/taag/
        
            Console.WriteLine(".___________. __________   ___ .___________.        ___       _______  ____    ____  _______ .__   __. .___________. __    __  .______       _______ ");
            await Task.Delay(250);
            Console.WriteLine("|           ||   ____\\  \\ /  / |           |       /   \\     |       \\ \\   \\  /   / |   ____||  \\ |  | |           ||  |  |  | |   _  \\     |   ____|");
            await Task.Delay(250);
            Console.WriteLine("`---|  |----`|  |__   \\  V  /  `---|  |----`      /  ^  \\    |  .--.  | \\   \\/   /  |  |__   |   \\|  | `---|  |----`|  |  |  | |  |_)  |    |  |__   ");
            await Task.Delay(250);
            Console.WriteLine("    |  |     |   __|   >   <       |  |          /  /_\\  \\   |  |  |  |  \\      /   |   __|  |  . `  |     |  |     |  |  |  | |      /     |   __|  ");
            await Task.Delay(250);
            Console.WriteLine("    |  |     |  |____ /  .  \\      |  |         /  _____  \\  |  '--'  |   \\    /    |  |____ |  |\\   |     |  |     |  `--'  | |  |\\  \\----.|  |____ ");
            await Task.Delay(250);
            Console.WriteLine("    |__|     |_______/__/ \\__\\     |__|        /__/     \\__\\ |_______/     \\__/     |_______||__| \\__|     |__|      \\______/  | _| `._____||_______|\n");

            Console.ReadLine();
            
    }
}