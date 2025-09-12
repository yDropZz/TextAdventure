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
            UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
            UI.WriteLine("Well.. What's your next move!?");
            UI.WriteLine("");
            UI.WriteLine("1. Adventure");
            UI.WriteLine("2. Mine");
            UI.WriteLine("3. Woodcutting");
            UI.WriteLine("4. Inventory");
            UI.WriteLine("5. Craft");
            UI.WriteLine("6. Town");
            UI.WriteLine("7. Rest");
            UI.WriteLine("8. Exit");
            
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "1" || input == "adventure")
            {
                Adventure(player, woodcutting, mining, inventory,enemy);
            }
            else if (input == "2" || input == "mine")
            {
                mining.Mine(player, woodcutting, inventory);
                while (true)
                {
                    UI.WriteLine("Mine again?");
                    UI.WriteLine("1. Yes");
                    UI.WriteLine("2. No"); 
                    input = Console.ReadLine().Trim().ToLower();

                    if (input == "1" || input == "yes")
                    {
                        mining.Mine(player, woodcutting, inventory);
                    }
                    else if (input == "2" || input == "no")
                    {
                        break;
                    }
                    else
                    {
                        UI.ConsoleDefault(player, woodcutting, mining, inventory, null);
                        UI.WriteLine("You did not enter a valid input");
                        Console.ReadKey();
                    }
                }
            }
            else if (input == "3" || input == "woodcutting")
            {
                woodcutting.CutWood(player, mining, inventory);
                while (true)
                {
                    UI.WriteLine("Cut again?");
                    UI.WriteLine("1. Yes");
                    UI.WriteLine("2. No"); 
                    input = Console.ReadLine().Trim().ToLower();

                    if (input == "1" || input == "yes")
                    {
                        woodcutting.CutWood(player, mining, inventory);
                    }
                    else if (input == "2" || input == "no")
                    {
                        break;
                    }
                    else
                    {
                        UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
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
            else if (input == "5" || input == "craft")
            {
                inventory.PrintCraftingMenu(player, woodcutting, mining, inventory);
            }
            else if (input == "6" || input == "town")
            {
                inventory.PrintShop(player,woodcutting,mining,inventory);
            }
            else if (input == "7" || input == "rest")
            {
                UI.ConsoleDefault(player,woodcutting, mining, inventory, null);
                UI.TypeWriteLine($"{player.Name} rested and regained their health.");
                player.HP = player.HPMax;
                Console.ReadKey();
            }
            else if (input == "8" || input == "exit")
            {
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
                UI.WriteLine("You did not enter a valid input");
                Console.ReadKey();
            }

        }
    }

    private static void Adventure(Player player, Woodcutting  woodcutting, Mining mining, Inventory inventory, Enemy enemy)
    {
        
        //Forest
        UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
        UI.TypeWriteLine($"{player.Name} enters the forest, might be a few dangerous along the way before you reach the next part...");
        Console.ReadKey();
        Console.Clear();
        for (int i = 0; i < 5; i++)
        {
            UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
            UI.TypeWriteLine($"As {player.Name} wanders through the forest they hear a sound..!");
            enemy.GenerateEnemy("forest");
            CombatChoices(player, enemy, inventory, woodcutting, mining);
            Console.Clear();
            if (player.IsDead)
            {
                return;
            }
        }
        UI.TypeWriteLine($"{player.Name} manage to push forward and make it through the forest...");
        Console.ReadKey();
        while (true)
        {
            Console.Clear();
            UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
            UI.TypeWriteLine("Do you wanna continue?");
            UI.WriteLine("1. Yes");
            UI.WriteLine("2. No");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "1" || input == "yes")
            {
                break;
            }
            else if (input == "2" || input == "no")
            {
                return;
            }
            else
            {
                UI.WriteLine("You did not enter a valid input, try again.");
                Console.ReadKey();
            }
        }
        //Dark forest
        Console.Clear();
        UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
        UI.TypeWriteLine($"{player.Name} continues forward and enters the Dark forest, even stronger dangerous will now be in your path...");
        Console.ReadKey();
        Console.Clear();
        for (int i = 0; i < 5; i++)
        {
            UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
            UI.TypeWriteLine($"As {player.Name} tread carefully through the Dark forest they hear a screech..!");
            enemy.GenerateEnemy("darkforest");
            CombatChoices(player, enemy, inventory, woodcutting, mining);
            Console.Clear();
            if (player.IsDead)
            {
                return;
            }
        }
        UI.TypeWriteLine($"{player.Name} manage to make it out alive and makes it through the Dark forest...");
        Console.ReadKey();
        while (true)
        {
            Console.Clear();
            UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
            UI.TypeWriteLine("Do you wanna continue?");
            UI.WriteLine("1. Yes");
            UI.WriteLine("2. No");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "1" || input == "yes")
            {
                break;
            }
            else if (input == "2" || input == "no")
            {
                return;
            }
            else
            {
                UI.WriteLine("You did not enter a valid input, try again.");
                Console.ReadKey();
            }
        }
        //Dark dungeon
        Console.Clear();
        UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
        UI.TypeWriteLine($"{player.Name} cut through the forest and stumble upon an entrance to a dungeon, a stench of evil linger...");
        Console.ReadKey();
        Console.Clear();
        for (int i = 0; i < 4; i++)
        {
            UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
            UI.TypeWriteLine($"As {player.Name} take brave steps through the dungeon were they hear a roar..!");
            enemy.GenerateEnemy("darkdungeon");
            CombatChoices(player, enemy, inventory, woodcutting, mining);
            Console.Clear();
            if (player.IsDead)
            {
                return;
            }
        }
        // Dragon
        UI.TypeWriteLine($"{player.Name} get to the end of the dungeon were a sleeping dragon guards an ominous gate...");
        Console.ReadKey();
        Console.Clear();
        UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
        enemy.GenerateEnemy("demongate");
        CombatChoices(player, enemy, inventory, woodcutting, mining);
        Console.Clear();
        if (player.IsDead)
        {
            return;
        }
        UI.TypeWriteLine($"{player.Name} best the dragon and now the gate is yours to enter...");
        Console.ReadKey();
        Console.Clear();
        while (true)
        {
            Console.Clear();
            UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
            UI.TypeWriteLine("Do you wanna continue?");
            UI.WriteLine("1. Yes");
            UI.WriteLine("2. No");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "1" || input == "yes")
            {
                break;
            }
            else if (input == "2" || input == "no")
            {
                return;
            }
            else
            {
                UI.WriteLine("You did not enter a valid input, try again.");
                Console.ReadKey();
            }
        }
        //Demon realm
        Console.Clear();
        UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
        UI.TypeWriteLine($"{player.Name} enters the gate. Hellfire surrounds them as they stand in a ruined castled.");
        UI.TypeWriteLine($"Long in front of them sits a creature covered in ragged nobel drapes upon a burnt throne. A strong sense of overpowering evil emits from the creature...");
        Console.ReadKey();
        Console.Clear();
        UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
        UI.TypeWriteLine($"[Mysterious creature] You dare enter MY REALM, who do you think you are you low life. I will crush you into a million PIECES! FOR I AM THE DARK DEMON LORD!!");
        Console.ReadKey();
        Console.Clear();
        UI.TypeWriteLine($"The Demon lord jumps down from his throne, landing just a few meters away from you... prepare for combat..!");
        Console.ReadKey();
        Console.Clear();
        for (int i = 0; i < 1; i++)
        {
            UI.ConsoleDefault(player, woodcutting, mining,inventory, null);
            enemy.GenerateEnemy("demonrealm");
            CombatChoices(player, enemy, inventory, woodcutting, mining);
            Console.Clear();
            if (player.IsDead)
            {
                return;
            }
        }
        UI.TypeWriteLine($"...");
        Console.ReadKey();
        Console.Clear();
        UI.TypeWriteLine($"The Demon lord lays before you, clawing at the ground as it curses you.");
        UI.TypeWriteLine($"[Demon lord] How... how did you... how dare you..! I will claw away your flesh as i gut your insides. And as your begging for mercy i will..!");
        UI.TypeWriteLine($"");
        Console.ReadKey();
        Console.Clear();
        UI.TypeWriteLine($"...");
        Console.ReadKey();
        UI.TypeWriteLine($"Silence echoes throughout the chambers as you plunge your weapon into the Demon lord for a final time... You had now defeated the ruler of the demon realm...");
        UI.TypeWriteLine($"But was it worth it? Your now the strongest there... you had no choice but the kill the Demon lord or did you..?");
        Console.ReadKey();
        UI.TypeWriteLine($"The throne now stands empty before you...");
        UI.TypeWriteLine($"What do you do..?");
        Console.ReadKey();
        Console.Clear();
        
    }

    private static void NewGame(Player player)
    {
        // Prologue story, ran once and never again.
        
        string choice = null;
        
        PlayIntro();
        
        // 5 Empty lines
        Console.Clear();
        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");

        UI.TypeWriteLine($"[Mysterious person] Hey! ... Who are you?");
        UI.TypeWrite("Enter your name: ");
        player.Name = Console.ReadLine();
        UI.TypeWriteLine($"[Mysterious person] Oh... Hey {player.Name}... I'm glad you're okay!");
        UI.TypeWriteLine("");
        UI.TypeWriteLine("1. What happened?");
        UI.TypeWriteLine("2. Who are you?");
        UI.TypeWriteLine("");
        UI.TypeWrite("Enter your choice: ");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            UI.TypeWriteLine("[Mysterious person] I don't know.. I heard a loud sound and then saw you falling from high above..");
        }
        else if (choice == "2")
        {
            UI.TypeWriteLine("[Mysterious person] I'm the elven mage of Isakeya, you're currently in the forest of Hitoria.");
        }
        else if (choice == "skip")
            return;

        choice = null;

        UI.TypeWriteLine("*I seem to remember nothing of my life, where I'm at, or anything but my name.*");
        UI.TypeWriteLine("[Mysterious person] I suppose you wish to know how you ended up here..");
        UI.TypeWriteLine("");
        UI.TypeWriteLine("1. Yes, of course");
        UI.TypeWriteLine("2. No.");
        UI.TypeWriteLine("");
        UI.TypeWrite("Enter your choice: ");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            UI.TypeWriteLine("[Mysterious person] I'm afraid you'll have to figure that out by yourself.");
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
            UI.TypeWriteLine("[Mysterious person] Well, there's lots of thing you can do here in Hitoria!");
            UI.TypeWriteLine("[Mysterious person] For example! We need lots of help with monsters roaming the area.");
            UI.TypeWriteLine("[Mysterious person] On top of that, you seem rather weak at the moment, you can train that up!");
            UI.TypeWriteLine("[Mysterious person] You can mine ores/gems and chop wood for different forms of logs");
            UI.TypeWriteLine("[Mysterious person] You can use these resources to craft new weapons and other stuff");
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

    private static void CombatChoices(Player player, Enemy enemy, Inventory inventory, Woodcutting woodcutting, Mining mining)
    {
        while (true)
        {
            bool fleed = false;
            while (!enemy.IsDead && !player.IsDead)
            {
                UI.ConsoleDefault(player, woodcutting, mining, inventory, enemy);
                UI.WriteLine("1. Melee");
                UI.WriteLine("2. Range");
                UI.WriteLine("3. Magic");
                UI.WriteLine("4. Block");
                UI.WriteLine("5. Retreat");

                string choice = Console.ReadLine().Trim().ToLower();

                if (choice == "1" || choice == "melee")
                {
                    Console.Clear();
                    int damage = player.CalculateDamage("melee", player, enemy, inventory);
                    enemy.RemoveHp(damage);
                    UI.ConsoleDefault(player,woodcutting, mining, inventory, enemy);
                    UI.WriteLine($"{enemy.Name} took {damage} damage.");
                    player.AddXp(damage *2,1);
                    Console.ReadKey();
                    break;
                }
                else if (choice == "2" || choice == "range")
                {
                    Console.Clear();
                    int damage = player.CalculateDamage("range", player, enemy, inventory);
                    enemy.RemoveHp(damage);
                    UI.ConsoleDefault(player,woodcutting, mining, inventory, enemy);
                    UI.WriteLine($"{enemy.Name} took {damage} damage.");
                    player.AddXp(damage *2,2);
                    Console.ReadKey();
                    break;
                }
                else if (choice == "3" || choice == "magic")
                {
                    Console.Clear();
                    int damage = player.CalculateDamage("magic", player, enemy, inventory);
                    enemy.RemoveHp(damage);
                    UI.ConsoleDefault(player,woodcutting, mining, inventory, enemy);
                    UI.WriteLine($"{enemy.Name} took {damage} damage.");
                    player.AddXp(damage *2,3);
                    Console.ReadKey();
                    break;
                }
                else if (choice == "4" || choice == "block")
                {
                    Console.Clear();
                    UI.ConsoleDefault(player,woodcutting, mining, inventory, enemy);
                    UI.TypeWrite("You try to block.. Nothing happens..");
                    Console.ReadKey();
                    break;
                }
                else if (choice == "5" || choice == "retreat")
                {
                    Console.Clear();
                    UI.ConsoleDefault(player,woodcutting, mining, inventory, enemy);
                    UI.WriteLine($"{player.Name} fleed...");
                    fleed = true;
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.Clear();
                    UI.ConsoleDefault(player,woodcutting, mining, inventory, enemy);
                    UI.WriteLine("Invalid input. Please try again.");
                    UI.WriteLine("");
                }
            }
            Console.Clear();
            if (fleed)
            {
                player.IsDead = true;
                return;
            }
            
            if (enemy.IsDead)
            {
                Console.Clear();
                UI.ConsoleDefault(player,woodcutting, mining, inventory, null);
                UI.WriteLine($"{player.Name} slayed {enemy.Name}");
                player.AddXp(enemy.HPMax,0);
                Console.ReadKey();
                return;
            }
            else
            {
                int enemyDamage = enemy.CalculateDamage(null, enemy, player, null);
                player.RemoveHp(enemyDamage);
                UI.ConsoleDefault(player,woodcutting, mining, inventory, enemy);
                UI.WriteLine($"{player.Name} took {enemyDamage} damage.");
                Console.ReadKey();
            }
            
            if (player.IsDead)
            {
                Console.Clear();
                UI.ConsoleDefault(player,woodcutting, mining, inventory, null);
                UI.WriteLine($"{player.Name} manage to flee from {enemy.Name}, just escaping death.");
                UI.WriteLine("But lost some xp along the way...");
                Console.ReadKey();
                Console.Clear();
                UI.ConsoleDefault(player,woodcutting, mining, inventory, null);
                UI.TypeWriteLine($"When {player.Name} got back to base they passed out until they fully rested.");
                player.HP = player.HPMax;
                Console.ReadKey();
                return;
            }
            
        }
    }
}