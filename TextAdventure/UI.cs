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

    public static void ConsoleDefault(Enemy enemy = null)
    {

        Mining mining;
    
        
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
        Console.Write("Player (7/10)");
        Console.Write("                    ");
        Console.WriteLine("");
//--------- Row 2 -------------
        Console.Write("                                                                                              ");
        Console.Write("『▮▮▮▮▮▮▮▯▯▯ 』");

       Console.WriteLine("");
//--------- Row 3 -------------
        Console.WriteLine("");
//--------- Row 4 -------------
        Console.WriteLine("");
        Console.Write("            ");
        Console.Write($"⸕ Mining: {} (15/35)⸕");
        Console.Write("                  ");
        Console.Write("✎ Woodcutting: 51 (48/108)✎");
        Console.Write("                  ");
        Console.Write("❦ Melee: 10 (12/32)❦");
        Console.Write("                  ");
        Console.Write("✯ Magic: 12 (14/38)✯");
        Console.Write("                  ");
        Console.WriteLine("↠ Range: 21 (37/56)↠ ");
        Console.WriteLine("");
        //Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.Write("                    ");
        Console.Write("");

        Console.WriteLine("");
        Console.WriteLine("");
        if (enemy != null)
        {
            Console.WriteLine("Goblin (2/5)  『▮▮▯▯▯ 』");
        }
        else
            Console.WriteLine("");
        
        Console.WriteLine("");
        Console.WriteLine("");
    }
    
    
    

}
