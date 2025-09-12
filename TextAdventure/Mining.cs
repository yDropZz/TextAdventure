namespace TextAdventure;




public class Mining
{
    private int miningXP = 0;
    private int miningXPReq = 20;
    private int miningLevel = 1;
    public int MiningXP { get => miningXP; set => miningXP = value; }
    public int MiningXPReq { get => miningXPReq; set => miningXPReq = value; }
    public int MiningLevel { get => miningLevel; set => miningLevel = value; }

    private void AddMiningExperience(int amount)
    {
        miningXP += amount;

        if (miningXP >= miningXPReq)
        {
            miningXP -= miningXPReq;
            miningLevel++;

            miningXPReq += 4;
            UI.WriteLine("You leveled up mining! You are now level: " + miningLevel);
        }
    }
    public void Mine(Player player, Woodcutting woodcutting, Inventory inventory)
    {
        Console.Clear();
        UI.ConsoleDefault(player,woodcutting,this,inventory,null);
        UI.Write("You enter the mines, after awhile you return with: ");
        RollMiningTable(player, woodcutting, inventory);
    }

    private void RollMiningTable(Player player, Woodcutting woodcutting, Inventory inventory)
    {
        int rolls = 1;
        
            
            if (inventory.GetItem("stonepickaxe") >= 1)
            {
                rolls=2;
                
            }
            if (inventory.GetItem("copperpickaxe") >= 1)
            {
                rolls=3;
                    
            }
            if (inventory.GetItem("ironpickaxe") >= 1)
            {
                rolls=4;
                        
            }
            if (inventory.GetItem("mithrilpickaxe") >= 1)
            {
                rolls=5;
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
            UI.ConsoleDefault(player,woodcutting,this,inventory,null);
            // Ores
            //-------------------------------------------------
            
            UI.WriteLine("");
            UI.WriteLine($"you got {tempFlint} flint ");
            UI.WriteLine($"you got {tempStone} stone ");
            UI.WriteLine($"you got {tempCopper} copper ");
            UI.WriteLine($"you got {tempIron} iron ");
            UI.WriteLine($"you got {tempMithril} mithril ");
            
            inventory.AddItem("flint", tempFlint);
            inventory.AddItem("stone", tempStone);
            inventory.AddItem("copper", tempCopper);
            inventory.AddItem("iron", tempIron);
            inventory.AddItem("mithril", tempMithril);
            
            // Gems
            //--------------------------------------------------
            
            UI.WriteLine("");
            UI.WriteLine($"you got {tempAmethyst} amethyst ");
            UI.WriteLine($"you got {tempSapphire} sapphire ");
            UI.WriteLine($"you got {tempTopaz} topaz ");
            UI.WriteLine($"you got {tempRuby} ruby ");
            UI.WriteLine($"you got {tempDiamond} diamond ");
            
            inventory.AddItem("amethyst", tempAmethyst);
            inventory.AddItem("sapphire", tempSapphire);
            inventory.AddItem("topaz", tempTopaz);
            inventory.AddItem("ruby", tempRuby);
            inventory.AddItem("diamond", tempDiamond);

            int miningExperienceToReceive = (tempFlint * 1) + (tempStone * 2) + (tempCopper * 3) + (tempIron * 4) + (tempMithril * 5) + 
                                      (tempAmethyst * 2) + (tempSapphire * 4) +  (tempTopaz * 6) + (tempRuby * 8) + (tempDiamond * 10);
            
            UI.WriteLine("");
            UI.WriteLine("You received a total of " + miningExperienceToReceive + "xp!");
            
            
            AddMiningExperience(miningExperienceToReceive);
            
            UI.WriteLine("");
            
            UI.WriteLine($"You have a total of: {inventory.GetItem("flint")} flint, {inventory.GetItem("stone")} stone, {inventory.GetItem("copper")} copper, {inventory.GetItem("iron")} iron, {inventory.GetItem("mithril")}  mithril");
            UI.WriteLine($"You have a total of: {inventory.GetItem("amethyst")} amethyst, {inventory.GetItem("sapphire")} sapphire, {inventory.GetItem("topaz")} topaz, {inventory.GetItem("ruby")} ruby, {inventory.GetItem("diamond")}  diamond");
            UI.WriteLine(miningXP + "/" + miningXPReq);
            UI.WriteLine("");
    }


    
    
    
}