namespace TextAdventure;
public class Program
{
    public static void Main()
    {

        Mining mining = new Mining();
        Inventory inventory = new Inventory();
        Woodcutting woodcutting = new Woodcutting();
        

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "1")
                {
                    mining.RollMiningTable(inventory);
                }
                else if (input == "2")
                {
                    woodcutting.RollWoodcuttingTable(inventory);
                }
                else if (input == "3")
                    break;
            }
        


         //tatic Player player = new Player();



    }
}