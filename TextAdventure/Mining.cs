namespace TextAdventure;




public class Mining
{
    private int miningXP = 0;
    private int miningXPReq = 20;
    private int miningLevel = 1;

    private void AddMiningExperience(int amount)
    {
        miningXP += amount;

        if (miningXP >= miningXPReq)
        {
            miningXP -= miningXPReq;
            miningLevel++;

            miningXPReq += 4;
            Console.WriteLine("You leveled up mining! You are now level: " + miningLevel);
        }
    }
    public void Mine( Inventory inventory)
    {
        Console.Clear();
        Console.Write("You enter the mines, after awhile you return with: ");
        RollMiningTable(inventory);
    }

    private void RollMiningTable(Inventory inventory)
    {
        int rolls = 1;
        
            
            if (inventory.GetItem("stonepickaxe") == 1)
            {
                rolls++;
                if (inventory.GetItem("copperpickaxe") == 1)
                {
                    rolls++;
                    if (inventory.GetItem("ironpickaxe") == 1)
                    {
                        rolls++;
                        if (inventory.GetItem("mithrilpickaxe") == 1)
                        {
                            rolls++;
                        }
                    }
                }
            }

            Random random = new Random();
            
            int tempFlint = 0;
            int tempStone = 0;
            int tempCopper = 0;
            int tempIron = 0;
            int tempMithril = 0;
            int tempAmethyst = 0;
            int tempSapphire = 0;
            int tempTopaz = 0;
            int tempRuby = 0;
            int tempDiamond = 0;
            

            for (int i = 0; i < rolls; i++)
            {
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 500 + miningLevel * 3)
                    {
                        tempFlint++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 250 + miningLevel * 4)
                    {
                        tempStone++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 125 + miningLevel*3)
                    {
                        tempCopper++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 75 + miningLevel *2)
                    {
                        tempIron++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 35 + miningLevel)
                    {
                        tempMithril++;
                    }
                    else
                    {
                        break;
                    }
                }
                // Gems
                //--------------------------------------
                
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 250 + miningLevel * 3)
                    {
                        tempAmethyst++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 125 + miningLevel * 4)
                    {
                        tempSapphire++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 75 + miningLevel*3)
                    {
                        tempTopaz++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 30 + miningLevel *2)
                    {
                        tempRuby++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    int x = random.Next(1, 1001);
                    if (x < 10 + miningLevel)
                    {
                        tempDiamond++;
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            // UI STUFF BELOW
            // Ores
            //-------------------------------------------------
            
            Console.WriteLine("");
            Console.WriteLine($"you got {tempFlint} flint ");
            Console.WriteLine($"you got {tempStone} stone ");
            Console.WriteLine($"you got {tempCopper} copper ");
            Console.WriteLine($"you got {tempIron} iron ");
            Console.WriteLine($"you got {tempMithril} mithril ");
            
            inventory.AddItem("flint", tempFlint);
            inventory.AddItem("stone", tempStone);
            inventory.AddItem("copper", tempCopper);
            inventory.AddItem("iron", tempIron);
            inventory.AddItem("mithril", tempMithril);
            
            // Gems
            //--------------------------------------------------
            
            Console.WriteLine("");
            Console.WriteLine($"you got {tempAmethyst} amethyst ");
            Console.WriteLine($"you got {tempSapphire} sapphire ");
            Console.WriteLine($"you got {tempTopaz} topaz ");
            Console.WriteLine($"you got {tempRuby} ruby ");
            Console.WriteLine($"you got {tempDiamond} diamond ");
            
            inventory.AddItem("amethyst", tempAmethyst);
            inventory.AddItem("sapphire", tempSapphire);
            inventory.AddItem("topaz", tempTopaz);
            inventory.AddItem("ruby", tempRuby);
            inventory.AddItem("diamond", tempDiamond);

            int miningExperienceToReceive = (tempFlint * 1) + (tempStone * 2) + (tempCopper * 3) + (tempIron * 4) + (tempMithril * 5) + 
                                      (tempAmethyst * 2) + (tempSapphire * 4) +  (tempTopaz * 6) + (tempRuby * 8) + (tempDiamond * 10);
            
            Console.WriteLine("");
            Console.WriteLine("You received a total of " + miningExperienceToReceive + "xp!");
            
            
            AddMiningExperience(miningExperienceToReceive);
            
            Console.WriteLine("");
            
            Console.WriteLine($"You have a total of: {inventory.GetItem("flint")} flint, {inventory.GetItem("stone")} stone, {inventory.GetItem("copper")} copper, {inventory.GetItem("iron")} iron, {inventory.GetItem("mithril")}  mithril");
            Console.WriteLine($"You have a total of: {inventory.GetItem("amethyst")} amethyst, {inventory.GetItem("sapphire")} sapphire, {inventory.GetItem("topaz")} topaz, {inventory.GetItem("ruby")} ruby, {inventory.GetItem("diamond")}  diamond");
            Console.WriteLine(miningXP + "/" + miningXPReq);
            Console.ReadKey();
    }


    
    
    
}