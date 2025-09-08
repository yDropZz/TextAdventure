namespace TextAdventure;
public class Program
{
    public static void Main()
    {
        Mining mining = new Mining();
        Inventory inventory = new Inventory();
        Woodcutting woodcutting = new Woodcutting();
        Player player = new Player();
        //NewGame(player);

        while (true)
        {
            
            
            Console.Clear();
            UI.ConsoleDefault();
            UI.WriteLine("What do you do?");
            UI.WriteLine("1. Adventure");
            UI.WriteLine("2. Mine");
            UI.WriteLine("3. Woodcutting");
            Console.WriteLine("4. Inventory");
            Console.WriteLine("5. Town");
            Console.WriteLine("6. Rest");
            Console.WriteLine("7. Help");
            Console.WriteLine("8. Exit");
            
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
                        Console.Clear();
                        Console.WriteLine("You did not enter a valid input");
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
                Console.Clear();
                Console.WriteLine("You did not enter a valid input");
                Console.ReadKey();
            }

        }
    }

    private static void NewGame(Player player)
    {
        Console.Write("Enter your name: ");
        string input = Console.ReadLine();
        player.Name = input;
        Console.Clear();
        
        Console.WriteLine($"{player.Name} wakes up in a clearing, forest all around them.");
        Console.ReadKey();
    }
}