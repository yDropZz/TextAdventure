namespace TextAdventure;

public class UI
{


    public static void Write(string input)
    {
        Console.Write("                         | " + input);
    }
    
    public static void WriteLine(string input)
    {
        Console.WriteLine("                         | " + input);
    }

    
    // TypeWrite Functions taken from https://stackoverflow.com/questions/25337336/how-to-make-text-be-typed-out-in-console-application user: mwk
    public static void TypeWrite(string line)
    {
        {
            Console.Write("                         | ");
            for (int i = 0; i < line.Length; i++) { 
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(50); // Sleep for 150 milliseconds
            }
        }
    }
    public static void TypeWriteLine(string line)
    {
        {
            Console.Write("                         | ");
            for (int i = 0; i < line.Length; i++) { 
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(50); // Sleep for 150 milliseconds
            }
            Console.WriteLine("");
        }
    }
    public static void TypeWriteClear(string line)
    {
        {
            for (int i = 0; i < line.Length; i++) {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(50); // Sleep for 150 milliseconds
            }
        }
    }

    public static void ConsoleDefault(Player player, Woodcutting woodcutting, Mining mining, Enemy enemy)
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
// Base stuff here
// There's exactly 209 - signs in a row on school computer
// Using 20 spaces to offset to right

//---------- Row 1 ------------

        Console.Write("                                                                                              ");
        Console.Write($"{player.Name} ({player.HP}/{player.HPMax})");
        Console.Write("                    ");
        Console.WriteLine("");
//--------- Row 2 -------------
        Console.Write(PrintHP(player));
        Console.WriteLine("");
//--------- Row 3 -------------
        Console.WriteLine("");
//--------- Row 4 -------------
        Console.WriteLine("");
        Console.Write("            ");
        Console.Write($"⸕ Mining: {mining.MiningLevel} ({mining.MiningXP}/{mining.MiningXPReq})⸕");
        Console.Write("                  ");
        Console.Write($"✎ Woodcutting: {woodcutting.WoodcuttingLevel} ({woodcutting.WoodcuttingXp}/{woodcutting.WoodcuttingXPREQ})✎");
        Console.Write("                  ");
        Console.Write($"❦ Melee: {player.Melee} ({player.MeleeXp}/{player.MeleeXPreq})❦");
        Console.Write("                  ");
        Console.Write($"✯ Magic: {player.Magic} ({player.MagicXp}/{player.MagicXpReq})✯");
        Console.Write("                  ");
        Console.WriteLine($"↠ Range: {player.Range} ({player.RangeXp}/{player.RangeXPreq})↠ ");
        Console.WriteLine("");
        //Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.Write("                    ");
        Console.Write("");

        Console.WriteLine("");
        Console.WriteLine("");
        if (enemy != null)
        {
            Console.Write("                                                                                              ");
            Console.WriteLine($"{enemy.Name} ({enemy.HP}/{enemy.HPMax})");
            Console.WriteLine(PrintHP(enemy));
        }
        else
            Console.WriteLine("");
        
        Console.WriteLine("");
        Console.WriteLine("");
    }

    static private string PrintHP(Entity sourcEntity)
    {
        float y = 100f-(0.5f*sourcEntity.HPMax);
        int x = (int)y;
        for (int i = 0; i < y; i++)
        {
            Console.Write(" ");
        }
        Console.Write("『");
        for (int i = 0; i < sourcEntity.HP; i++)
        {
            Console.Write("▮");
        }
        int z = sourcEntity.HPMax - sourcEntity.HP;
        for (int i = 0; i < z; i++)
        {
            Console.Write("▯");
        }
        Console.Write("』");
        return "";
    }
    
    

}
