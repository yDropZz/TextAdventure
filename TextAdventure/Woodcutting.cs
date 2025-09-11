namespace TextAdventure;




public class Woodcutting
{
    private int woodcuttingXP = 0;
    private int woodcuttingXPReq = 20;
    private int woodcuttingLevel = 1;
    public int WoodcuttingLevel { get => woodcuttingLevel; set => woodcuttingLevel = value; }
    public int WoodcuttingXp { get => woodcuttingXP; set => woodcuttingXP = value; }
    public int WoodcuttingXPREQ { get => woodcuttingXPReq; set => woodcuttingXPReq = value; }

    private void AddWoodcuttingExperience(int amount)
    {
        woodcuttingXP += amount;

        if (woodcuttingXP >= woodcuttingXPReq)
        {
            woodcuttingXP -= woodcuttingXPReq;
            woodcuttingLevel++;

            woodcuttingXPReq += 4;
            Console.WriteLine("You leveled up wood cutting! You are now level: " + woodcuttingLevel);
        }
    }
    public void CutWood(Inventory inventory)
    {
        Console.Clear();
        Console.Write("You enter the forest, after awhile you return with: ");
        RollWoodcuttingTable(inventory);
    }

    private void RollWoodcuttingTable(Inventory inventory)
    {
        int rolls = 1000;
        
            
            if (inventory.GetItem("stoneaxe") == 1)
            {
                rolls++;
                if (inventory.GetItem("copperaxe") == 1)
                {
                    rolls++;
                    if (inventory.GetItem("ironaxe") == 1)
                    {
                        rolls++;
                        if (inventory.GetItem("mithrilaxe") == 1)
                        {
                            rolls++;
                        }
                    }
                }
            }

            Random random = new Random();
            
            int tempLog = 0;
            int tempBirch = 0;
            int tempSpruce = 0;
            int tempOak = 0;
            int tempDarkoak = 0;

            for (int i = 0; i < rolls; i++)
            {
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 500 + woodcuttingLevel * 3)
                    {
                        tempLog++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 250 + woodcuttingLevel * 4)
                    {
                        tempBirch++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 125 + woodcuttingLevel*3)
                    {
                        tempSpruce++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 75 + woodcuttingLevel *2)
                    {
                        tempOak++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 35 + woodcuttingLevel)
                    {
                        tempDarkoak++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            // UI STUFF BELOW
            // Wood
            //-------------------------------------------------
        
            Console.WriteLine($"you got {tempLog} log ");
            Console.WriteLine($"you got {tempBirch} birch ");
            Console.WriteLine($"you got {tempSpruce} spruce ");
            Console.WriteLine($"you got {tempOak} oak ");
            Console.WriteLine($"you got {tempDarkoak} dark oak ");
            
            inventory.AddItem("log", tempLog);
            inventory.AddItem("birchlog", tempBirch);
            inventory.AddItem("sprucelog", tempSpruce);
            inventory.AddItem("oaklog", tempOak);
            inventory.AddItem("darkoaklog", tempDarkoak);

            int woodcuttingExperienceToReceive = (tempLog * 1) + (tempBirch * 2) + (tempSpruce * 3) + (tempOak * 4) +
                                              (tempDarkoak * 5);
            
            Console.WriteLine("");
            Console.WriteLine("You received a total of " + woodcuttingExperienceToReceive + "xp!");
            
            
            AddWoodcuttingExperience(woodcuttingExperienceToReceive);
            
            Console.WriteLine("");
            
            Console.WriteLine($"You have a total of: {inventory.GetItem("log")} logs, {inventory.GetItem("birchlog")} birch logs, {inventory.GetItem("sprucelog")} spruce logs, {inventory.GetItem("oaklog")} oak logs, {inventory.GetItem("darkoaklog")}  dark oak logs");
            Console.WriteLine(woodcuttingXP + "/" + woodcuttingXPReq);
            Console.ReadKey();
    }


    
    
    
}