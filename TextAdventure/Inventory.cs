using System.Diagnostics;

namespace TextAdventure;

public class Inventory
{
    private Player player;
    
    
    
    //Minerals
    //--------------------
    private int flint = 0;
    private int stone = 0;
    private int copper = 0;
    private int iron = 0;

    private int mithril = 0;

    //Gems
    //----------------------
    private int amethyst = 0;
    private int sapphire = 0;
    private int topaz = 0;
    private int ruby = 0;

    private int diamond = 0;

    //Wood
    //----------------------
    private int log = 0;
    private int birchlog = 0;
    private int sprucelog = 0;
    private int oaklog = 0;

    private int darkoaklog = 0;

    //Melee
    //-----------------------
    private int flintdagger = 0;
    private int stonemace = 0;
    private int copperspear = 0;
    private int ironsword = 0;

    private int mithrillongsword = 0;

    //Magic
    //-----------------------
    private int wand = 0;
    private int magicsigil = 0;
    private int staff = 0;
    private int spellbook = 0;

    private int darkgrimoire = 0;

    //Ranged
    //-----------------------
    private int slingshot = 0;
    private int bow = 0;
    private int crossbow = 0;
    private int longbow = 0;

    private int warbow = 0;

    //Pickaxes
    //-----------------------
    private int flintpickaxe = 0;
    private int stonepickaxe = 0;
    private int copperpickaxe = 0;
    private int ironpickaxe = 0;

    private int mithrilpickaxe = 0;

    //Axes
    //-----------------------
    private int flintaxe = 0;
    private int stoneaxe = 0;
    private int copperaxe = 0;
    private int ironaxe = 0;

    private int mithrilaxe = 0;

    //General
    //-----------------------
    private int coins = 0;

    public int Coins
    {
        get => coins;
        set => coins = value;
    }


    public void AddItem(string item, int amount)
    {
        switch (item)
        {
            case "flint":
                flint += amount;
                break;
            case "stone":
                stone += amount;
                break;
            case "copper":
                copper += amount;
                break;
            case "iron":
                iron += amount;
                break;
            case "mithril":
                mithril += amount;
                break;
            case "amethyst":
                amethyst += amount;
                break;
            case "sapphire":
                sapphire += amount;
                break;
            case "topaz":
                topaz += amount;
                break;
            case "ruby":
                ruby += amount;
                break;
            case "diamond":
                diamond += amount;
                break;
            case "log":
                log += amount;
                break;
            case "birchlog":
                birchlog += amount;
                break;
            case "sprucelog":
                sprucelog += amount;
                break;
            case "oaklog":
                oaklog += amount;
                break;
            case "darkoaklog":
                darkoaklog += amount;
                break;
            case "flintdagger":
                flintdagger += amount;
                break;
            case "stonemace":
                stonemace += amount;
                break;
            case "copperspear":
                copperspear += amount;
                break;
            case "ironsword":
                ironsword += amount;
                break;
            case "mithrillongsword":
                mithrillongsword += amount;
                break;
            case "wand":
                wand += amount;
                break;
            case "magicsigil":
                magicsigil += amount;
                break;
            case "staff":
                staff += amount;
                break;
            case "spellbook":
                spellbook += amount;
                break;
            case "darkgrimoire":
                darkgrimoire += amount;
                break;
            case "slingshot":
                slingshot += amount;
                break;
            case "bow":
                bow += amount;
                break;
            case "crossbow":
                crossbow += amount;
                break;
            case "longbow":
                longbow += amount;
                break;
            case "warbow":
                warbow += amount;
                break;
            case "flintpickaxe":
                flintpickaxe += amount;
                break;
            case "stonepickaxe":
                stonepickaxe += amount;
                break;
            case "copperpickaxe":
                copperpickaxe += amount;
                break;
            case "ironpickaxe":
                ironpickaxe += amount;
                break;
            case "mithrilpickaxe":
                mithrilpickaxe += amount;
                break;
            case "flintaxe":
                flintaxe += amount;
                break;
            case "stoneaxe":
                stoneaxe += amount;
                break;
            case "copperaxe":
                copperaxe += amount;
                break;
            case "ironaxe":
                ironaxe += amount;
                break;
            case "mithrilaxe":
                mithrilaxe += amount;
                break;
            case "coin":
                coins += amount;
                break;
        }
    }
    
    public void RemoveItem(string item, int amount)
    {
        switch (item)
        {
            case "flint":
                flint -= amount;
                break;
            case "stone":
                stone -= amount;
                break;
            case "copper":
                copper -= amount;
                break;
            case "iron":
                iron -= amount;
                break;
            case "mithril":
                mithril -= amount;
                break;
            case "amethyst":
                amethyst -= amount;
                break;
            case "sapphire":
                sapphire -= amount;
                break;
            case "topaz":
                topaz -= amount;
                break;
            case "ruby":
                ruby -= amount;
                break;
            case "diamond":
                diamond -= amount;
                break;
            case "log":
                log -= amount;
                break;
            case "birchlog":
                birchlog -= amount;
                break;
            case "sprucelog":
                sprucelog -= amount;
                break;
            case "oaklog":
                oaklog -= amount;
                break;
            case "darkoaklog":
                darkoaklog -= amount;
                break;
            case "flintdagger":
                flintdagger -= amount;
                break;
            case "stonemace":
                stonemace -= amount;
                break;
            case "copperspear":
                copperspear -= amount;
                break;
            case "ironsword":
                ironsword -= amount;
                break;
            case "mithrillongsword":
                mithrillongsword -= amount;
                break;
            case "wand":
                wand -= amount;
                break;
            case "magicsigil":
                magicsigil -= amount;
                break;
            case "staff":
                staff -= amount;
                break;
            case "spellbook":
                spellbook -= amount;
                break;
            case "darkgrimoire":
                darkgrimoire -= amount;
                break;
            case "slingshot":
                slingshot -= amount;
                break;
            case "bow":
                bow -= amount;
                break;
            case "crossbow":
                crossbow -= amount;
                break;
            case "longbow":
                longbow -= amount;
                break;
            case "warbow":
                warbow -= amount;
                break;
            case "flintpickaxe":
                flintpickaxe -= amount;
                break;
            case "stonepickaxe":
                stonepickaxe -= amount;
                break;
            case "copperpickaxe":
                copperpickaxe -= amount;
                break;
            case "ironpickaxe":
                ironpickaxe -= amount;
                break;
            case "mithrilpickaxe":
                mithrilpickaxe -= amount;
                break;
            case "flintaxe":
                flintaxe -= amount;
                break;
            case "stoneaxe":
                stoneaxe -= amount;
                break;
            case "copperaxe":
                copperaxe -= amount;
                break;
            case "ironaxe":
                ironaxe -= amount;
                break;
            case "mithrilaxe":
                mithrilaxe -= amount;
                break;
            case "coin":
                coins -= amount;
                break;
        }
    }

    public int GetItemValue(string item)
    {
        switch (item)
        {
            case "flint":
                return 1;
            case "stone":
                return 2;
            case "copper":
                return 5;
            case "iron":
                return 20;
            case "mithril":
                return 100;
            case "amethyst":
                return 2;
            case "sapphire":
                return 4;
            case "topaz":
                return 20;
            case "ruby":
                return 40;
            case "diamond":
                return 200;
            case "log":
                return 1;
            case "birchlog":
                return 2;
            case "sprucelog":
                return 5;
            case "oaklog":
                return 20;
            case "darkoaklog":
                return 100;
        }

        return 0;
    }
    

    public int GetItem(string item)
    {
        switch (item)
        {
            case "flint":
                return flint;
            case "stone":
                return stone;
            case "copper":
                return copper;
            case "iron":
                return iron;
            case "mithril":
                return mithril;
            case "amethyst":
                return amethyst;
            case "sapphire":
                return sapphire;
            case "topaz":
                return topaz;
            case "ruby":
                return ruby;
            case "diamond":
                return diamond;
            case "log":
                return log;
            case "birchlog":
                return birchlog;
            case "sprucelog":
                return sprucelog;
            case "oaklog":
                return oaklog;
            case "darkoaklog":
                return darkoaklog;
            case "flintdagger":
                return flintdagger;
            case "stonemace":
                return stonemace;
            case "copperspear":
                return copperspear;
            case "ironsword":
                return ironsword;
            case "mithrillongsword":
                return mithrillongsword;
            case "wand":
                return wand;
            case "magicsigil":
                return magicsigil;
            case "staff":
                return staff;
            case "spellbook":
                return spellbook;
            case "darkgrimoire":
                return darkgrimoire;
            case "slingshot":
                return slingshot;
            case "bow":
                return bow;
            case "crossbow":
                return crossbow;
            case "longbow":
                return longbow;
            case "warbow":
                return warbow;
            case "flintpickaxe":
                return flintpickaxe;
            case "stonepickaxe":
                return stonepickaxe;
            case "copperpickaxe":
                return copperpickaxe;
            case "ironpickaxe":
                return ironpickaxe;
            case "mithrilpickaxe":
                return mithrilpickaxe;
            case "flintaxe":
                return flintaxe;
            case "stoneaxe":
                return stoneaxe;
            case "copperaxe":
                return copperaxe;
            case "ironaxe":
                return ironaxe;
            case "mithrilaxe":
                return mithrilaxe;
            case "coin":
                return coins;
        }

        return 0;
    }

    public float GetWeaponValue(string type)
    {
        if (type == "melee")
        {
            float value = 1;
            if (GetItem("flintdagger") == 1)
            {
                value = 2;
            }

            if (GetItem("stonemace") == 1)
            {
                value = 3;
            }
    
            if (GetItem("copperspear") == 1)
            {
                value = 4;
            }

            if (GetItem("ironsword") == 1)
            {
                value = 5;
            }

            if (GetItem("mithrillongsword") == 1)
            {
                value = 6;
            }

            return value;
        }
        else if (type == "magic")
        {
            float value = 1;
            if (GetItem("wand") == 1)
            {
                value = 2;
            }

            if (GetItem("magicsigil") == 1)
            {
                value = 3;
            }

            if (GetItem("staff") == 1)
            {
                value = 4;
            }

            if (GetItem("spellbook") == 1)
            {
                value = 5;
            }

            if (GetItem("darkgrimoire") == 1)
            {
                value = 6;
            }

            return value;
        }
        else if (type == "range")
        {
            float value = 1;
            if (GetItem("slingshot") == 1)
            {
                value = 2;
            }

            if (GetItem("bow") == 1)
            {
                value = 3;
            }

            if (GetItem("crossbow") == 1)
            {
                value = 4;
            }

            if (GetItem("longbow") == 1)
            {
                value = 5;
            }

            if (GetItem("warbow") == 1)
            {
                value = 6;
            }

            return value;
        }

        return 0f;
    }

    public float GetToolValue(string type)
    {
        if (type == "pickaxe")
        {
            float value = 1;
            if (GetItem("flintpickaxe") == 1)
            {
                value = 2;
            }

            if (GetItem("stonepickaxe") == 1)
            {
                value = 3;
            }

            if (GetItem("copperpickaxe") == 1)
            {
                value = 4;
            }

            if (GetItem("ironpickaxe") == 1)
            {
                value = 5;
            }

            if (GetItem("mithrillpickaxe") == 1)
            {
                value = 6;
            }

            return value;
        }
        else if (type == "axe")
        {
            float value = 1;
            if (GetItem("flintaxe") == 1)
            {
                value = 1;
            }

            if (GetItem("stoneaxe") == 1)
            {
                value = 2;
            }

            if (GetItem("copperaxe") == 1)
            {
                value = 3;
            }

            if (GetItem("ironaxe") == 1)
            {
                value = 4;
            }

            if (GetItem("mithrilaxe") == 1)
            {
                value = 5;
            }

            return value;
        }

        return 0;
    }

    public void PrintInventory()
    {
        UI.WriteLine("[Resources]");
        UI.WriteLine($"Flint: {flint}, Stone: {stone}, Copper: {copper}, Iron: {iron}, Mithril: {mithril}");
        UI.WriteLine($"Amethyst: {amethyst}, Sapphire: {sapphire}, Topaz: {topaz}, Ruby: {ruby}, Diamond: {diamond}");
        UI.WriteLine($"Log: {log}, Birch logs: {birchlog}, Spruce logs: {sprucelog}, Oak logs: {oaklog}, Dark oak logs: {darkoaklog}");
        UI.WriteLine("");
        UI.WriteLine($"[Tools]");
        UI.WriteLine($"Axes: Flint Axe: {flintaxe}, Stone Axe: {stoneaxe}, Copper Axe: {copperaxe}, Iron Axe: {ironaxe}, Mithril Axe: {mithrilaxe}");
        UI.WriteLine($"Pickaxes: Flint Pickaxe: {flintpickaxe}, Stone Pickaxe: {stonepickaxe}, Copper Pickaxe: {copperpickaxe}, Iron Pickaxe: {ironpickaxe}, Mithril Pickaxe: {mithrilpickaxe}");
        UI.WriteLine("");
        UI.WriteLine($"[Weapons]");
        UI.WriteLine($"Melee Weapons: Flint Dagger: {flintdagger}, Stone Mace: {stonemace}, Copper Spear: {copperspear}, Iron Sword: {ironsword}, Mithril Longsword: {mithrillongsword} ");
        UI.WriteLine($"Range Weapons: Slingshot: {slingshot}, Bow: {bow}, Crossbow: {crossbow}, Longbow: {longbow}, Warbow: {warbow}");
        UI.WriteLine($"Magic Weapons: Wand: {wand}, Staff: {staff}, magicsigil: {magicsigil}, spellbook: {spellbook}, darkgrimoire: {darkgrimoire}");
        UI.WriteLine("[Misc]");
        UI.WriteLine($"Coins: {coins}");
        
    }

    public void PrintShop(Player player, Woodcutting woodcutting, Mining mining, Inventory inventory)
    {
        UI.ConsoleDefault(player, woodcutting, mining, inventory, null);
        UI.TypeWriteLine($"Hello Traveler! how may i help you?");
        UI.TypeWriteLine("1. Buy");
        UI.TypeWriteLine("2. Sell");
        UI.TypeWriteLine("3. Exit");
        string mode = Console.ReadLine().Trim().ToLower();
        UI.ConsoleDefault(player, woodcutting, mining, inventory, null);

        if (mode == "3")
        {
            return;
        }
        
        // Print store
        if (mode == "buy" || mode =="1")
        {
            UI.WriteLine("[Resources]" + "                 You have " + coins + "⛃ ");
            UI.WriteLine($"1. Flint [2⛃ ] ");
            UI.WriteLine($"2. Stone [4⛃ ]");
            UI.WriteLine("3. Copper [10⛃ ]");
            UI.WriteLine("4. Iron [40⛃ ]");
            UI.WriteLine("5. Mithril [200⛃ ]");
            UI.WriteLine("6. Amethyst [4⛃ ]");
            UI.WriteLine("7. Sapphire [8⛃ ]");
            UI.WriteLine("8. Topaz [20⛃ ]");
            UI.WriteLine("10. Ruby [80⛃ ]");
            UI.WriteLine("11. Diamond [400⛃ ]");
            UI.WriteLine("11. Log [2⛃ ]");
            UI.WriteLine("12. Birch log [4⛃ ]");
            UI.WriteLine("13. Spruce log [10⛃ ]");
            UI.WriteLine("14. Oak log [40⛃ ]");
            UI.WriteLine("15. Dark oak logs [200⛃ ]");
            UI.WriteLine("16. Exit");
            UI.WriteLine("");
            UI.TypeWrite("What would you like to buy: ");
            
            string buyInput = Console.ReadLine().Trim().ToLower();
            
            string buyInputName = "item";

            int itemValue = 0;

            string actualItemToBuy = "tempItem";

            if (buyInput == "1" || buyInput == "flint")
            {
                itemValue = GetItemValue("flint");
                buyInputName = "Flint";
                actualItemToBuy = "flint";

            }
            else if (buyInput == "2" || buyInput == "stone")
            {
                itemValue = GetItemValue("stone");
                buyInputName = "Stone";
                actualItemToBuy = "stone";
            }
            else if (buyInput == "3" || buyInput == "copper")
            {
                itemValue = GetItemValue("copper");
                buyInputName = "Copper";
                actualItemToBuy = "copper";
            }
            else if (buyInput == "4" || buyInput == "iron")
            {
                itemValue = GetItemValue("iron");
                buyInputName = "Iron";
                actualItemToBuy = "iron";
            }
            else if (buyInput == "5" || buyInput == "mithril")
            {
                itemValue = GetItemValue("mithril");
                buyInputName = "Mithril";
                actualItemToBuy = "mithril";
            }
            else if (buyInput == "6" || buyInput == "amethyst")
            {
                itemValue = GetItemValue("amethyst");
                buyInputName = "Amethyst";
                actualItemToBuy = "amethyst";
            }
            else if (buyInput == "7" || buyInput == "sapphire")
            {
                itemValue = GetItemValue("sapphire");
                buyInputName = "Sapphire";
                actualItemToBuy = "sapphire";
            }
            else if (buyInput == "8" || buyInput == "topaz")
            {
                itemValue = GetItemValue("topaz");
                buyInputName = "Topaz";
                actualItemToBuy = "topaz";
            }
            else if (buyInput == "9" || buyInput == "ruby")
            {
                itemValue = GetItemValue("ruby");
                buyInputName = "Ruby";
                actualItemToBuy = "ruby";
            }
            else if (buyInput == "10" || buyInput == "diamond")
            {
                itemValue = GetItemValue("diamond");
                buyInputName = "Diamond";
                actualItemToBuy = "diamond";
            }
            else if (buyInput == "11" || buyInput == "log")
            {
                itemValue = GetItemValue("log");
                buyInputName = "Log";
                actualItemToBuy = "log";
            }
            else if (buyInput == "12" || buyInput == "birch log" || buyInput == "birch")
            {
                itemValue = GetItemValue("birchlog");
                buyInputName = "Birch Log";
                actualItemToBuy = "birchlog";
            }
            else if (buyInput == "13" || buyInput == "spruce log" || buyInput == "spruce")
            {
                itemValue = GetItemValue("sprucelog");
                buyInputName = "Spruce Log";
                actualItemToBuy = "sprucelog";
            }
            else if (buyInput == "14" || buyInput == "oak log" || buyInput == "oak")
            {
                itemValue = GetItemValue("oaklog");
                buyInputName = "Oak Log";
                actualItemToBuy = "oaklog";
            }
            else if (buyInput == "15" || buyInput == "darkoak log" || buyInput == "darkoak" || buyInput == "dark oak" ||
                     buyInput == "dark oak log")
            {
                itemValue = GetItemValue("darkoaklog");
                buyInputName = "DarkOak Log";
                actualItemToBuy = "darkoaklog";
            }
            else if (buyInput == "16" || buyInput == "exit")
            {
                return;
            }
            
            UI.TypeWrite($"How many {buyInputName} would you like to buy: ");
            int buyAmount = int.Parse(Console.ReadLine().Trim().ToLower());

            int totalPrice = itemValue * buyAmount * 2;
            
            UI.TypeWriteLine("");
            UI.TypeWriteLine($"Would you like to buy {buyAmount} {buyInputName} for {totalPrice} [⛃ ]?");
            UI.TypeWriteLine("1. Yes");
            UI.TypeWrite("2. No");
            
            int z = int.Parse(Console.ReadLine().Trim().ToLower());

            if (z == 1)
            {
                // If u cna afford it
                if (coins >= totalPrice)
                {
                    coins -= totalPrice;
                    AddItem(actualItemToBuy, buyAmount);

                    UI.TypeWriteLine("Purchase Complete! Would you like to buy something else?");
                    UI.TypeWriteLine("1. Yes");
                    UI.TypeWrite("2. No");
                    int y = int.Parse(Console.ReadLine().Trim().ToLower());
                    if (y == 1)
                    {
                        UI.ConsoleDefault(player, woodcutting, mining, inventory, null);
                        PrintShop(player, woodcutting, mining, inventory);
                    }
                    else if (y == 2)
                    {
                        return;
                    }
                }
                else
                { 
                    UI.TypeWriteLine("You don't have enough coins to buy this!");
                    UI.ConsoleDefault(player, woodcutting, mining, inventory, null);
                    PrintShop(player, woodcutting, mining, inventory);
                    Console.ReadKey();
                }
            }
            else if (z == 2)
            {
                return;
            }




        }

        if (mode == "sell" || mode == "2")
        {
            UI.WriteLine("[Resources]" + "                 You have " + coins + "⛃ ");
            UI.WriteLine($"1. Flint: {flint} [1⛃ ] ");
            UI.WriteLine($"2. Stone: {stone} [2⛃ ]");
            UI.WriteLine($"3. Copper: {copper} [5⛃ ]");
            UI.WriteLine($"4. Iron: {iron} [20⛃ ]");
            UI.WriteLine($"5. Mithril: {mithril} [100⛃ ]");
            UI.WriteLine($"6. Amethyst: {amethyst} [2⛃ ]");
            UI.WriteLine($"7. Sapphire: {sapphire} [4⛃ ]");
            UI.WriteLine($"8. Topaz: {topaz} [10⛃ ]");
            UI.WriteLine($"10. Ruby: {ruby} [40⛃ ]");
            UI.WriteLine($"11. Diamond: {diamond} [200⛃ ]");
            UI.WriteLine($"11. Log: {log} [1⛃ ]");
            UI.WriteLine($"12. Birch log: {birchlog} [2⛃ ]");
            UI.WriteLine($"13. Spruce log: {sprucelog} [5⛃ ]");
            UI.WriteLine($"14. Oak log: {oaklog} [20⛃ ]");
            UI.WriteLine($"15. Dark oak logs: {darkoaklog} [100⛃ ]");
            UI.WriteLine("16. Exit");
            UI.WriteLine("");
            UI.TypeWrite("What would you like to buy: ");

            string sellInput = Console.ReadLine().Trim().ToLower();

            string sellInputName = "item";

            int itemValue = 0;

            string actualItemToSell = "tempItem";

            int itemAmountYouHave = 0;

            if (sellInput == "1" || sellInput == "flint")
            {
                itemValue = GetItemValue("flint");
                sellInputName = "Flint";
                actualItemToSell = "flint";

            }
            else if (sellInput == "2" || sellInput == "stone")
            {
                itemValue = GetItemValue("stone");
                sellInputName = "Stone";
                actualItemToSell = "stone";
            }
            else if (sellInput == "3" || sellInput == "copper")
            {
                itemValue = GetItemValue("copper");
                sellInputName = "Copper";
                actualItemToSell = "copper";
            }
            else if (sellInput == "4" || sellInput == "iron")
            {
                itemValue = GetItemValue("iron");
                sellInputName = "Iron";
                actualItemToSell = "iron";
            }
            else if (sellInput == "5" || sellInput == "mithril")
            {
                itemValue = GetItemValue("mithril");
                sellInputName = "Mithril";
                actualItemToSell = "mithril";
            }
            else if (sellInput == "6" || sellInput == "amethyst")
            {
                itemValue = GetItemValue("amethyst");
                sellInputName = "Amethyst";
                actualItemToSell = "amethyst";
            }
            else if (sellInput == "7" || sellInput == "sapphire")
            {
                itemValue = GetItemValue("sapphire");
                sellInputName = "Sapphire";
                actualItemToSell = "sapphire";
            }
            else if (sellInput == "8" || sellInput == "topaz")
            {
                itemValue = GetItemValue("topaz");
                sellInputName = "Topaz";
                actualItemToSell = "topaz";
            }
            else if (sellInput == "9" || sellInput == "ruby")
            {
                itemValue = GetItemValue("ruby");
                sellInputName = "Ruby";
                actualItemToSell = "ruby";
            }
            else if (sellInput == "10" || sellInput == "diamond")
            {
                itemValue = GetItemValue("diamond");
                sellInputName = "Diamond";
                actualItemToSell = "diamond";
            }
            else if (sellInput == "11" || sellInput == "log")
            {
                itemValue = GetItemValue("log");
                sellInputName = "Log";
                actualItemToSell = "log";
            }
            else if (sellInput == "12" || sellInput == "birch log" || sellInput == "birch")
            {
                itemValue = GetItemValue("birchlog");
                sellInputName = "Birch Log";
                actualItemToSell = "birchlog";
            }
            else if (sellInput == "13" || sellInput == "spruce log" || sellInput == "spruce")
            {
                itemValue = GetItemValue("sprucelog");
                sellInputName = "Spruce Log";
                actualItemToSell = "sprucelog";
            }
            else if (sellInput == "14" || sellInput == "oak log" || sellInput == "oak")
            {
                itemValue = GetItemValue("oaklog");
                sellInputName = "Oak Log";
                actualItemToSell = "oaklog";
            }
            else if (sellInput == "15" || sellInput == "darkoak log" || sellInput == "darkoak" ||
                     sellInput == "dark oak" ||
                     sellInput == "dark oak log")
            {
                itemValue = GetItemValue("darkoaklog");
                sellInputName = "DarkOak Log";
                actualItemToSell = "darkoaklog";
            }
            else if (sellInput == "16" || sellInput == "exit")
            {
                return;
            }


            UI.TypeWriteLine($"How many {sellInputName} would you like to sell: ");
            int sellAmount = int.Parse(Console.ReadLine().Trim().ToLower());

            if (GetItem(actualItemToSell) < sellAmount)
            {
                UI.TypeWriteLine("Sorry! You do not have enough " + sellInputName);
                UI.ConsoleDefault(player, woodcutting, mining, inventory, null);
                PrintShop(player, woodcutting, mining, inventory);
            }

            int totalPrice = itemValue * sellAmount;

            UI.TypeWriteLine("");
            UI.TypeWriteLine($"Would you like to sell {sellAmount} {sellInputName} for {totalPrice} [⛃ ]?");
            UI.TypeWriteLine("1. Yes");
            UI.TypeWrite("2. No");

            int z = int.Parse(Console.ReadLine().Trim().ToLower());

            if (z == 1)
            {
                // If u  want to sell

                coins += totalPrice;
                RemoveItem(actualItemToSell, sellAmount);

                UI.TypeWriteLine("Items has been sold! Would you like to sell something else?");
                UI.TypeWriteLine("1. Yes");
                UI.TypeWrite("2. No");
                int y = int.Parse(Console.ReadLine().Trim().ToLower());
                if (y == 1)
                {
                    UI.ConsoleDefault(player, woodcutting, mining, inventory, null);
                    PrintShop(player, woodcutting, mining, inventory);
                }
                else if (y == 2)
                {
                    return;
                }

            }
            else if (z == 2)
            {
                UI.ConsoleDefault(player, woodcutting, mining, inventory, null);
                PrintShop(player, woodcutting, mining, inventory);
            }






        }
    }

    public void PrintCraftingMenu(Player player, Woodcutting woodcutting, Mining mining, Inventory inventory)
    {
        UI.ConsoleDefault(player, woodcutting, mining, inventory, null);
        UI.WriteLine("{ Crafting Menu }");
        UI.WriteLine("");
        UI.WriteLine("[Pickaxes]");
        UI.WriteLine("1. Flint Pickaxe: 10 Flint + 10 Logs");
        UI.WriteLine("2. Stone Pickaxe: 20 Stone + 20 Birch Logs");
        UI.WriteLine("3. Copper Pickaxe: 30 Copper + 30 Spruce Logs");
        UI.WriteLine("4. Iron Pickaxe: 40 Iron + 40 Oak Logs");
        UI.WriteLine("5. Mithril Pickaxe: 50 Mithril + 50 Dark Oak Logs");
        // ----------------------------------------------------------------
        UI.WriteLine("");
        UI.WriteLine("[Axes]");
        UI.WriteLine("6. Flint Axe: 10 Flint + 10 Logs");
        UI.WriteLine("7. Stone Axe: 20 Stone + 20 Birch Logs");
        UI.WriteLine("8. Copper Axe: 30 Copper + 30 Spruce Logs");
        UI.WriteLine("9. Iron Axe: 40 Iron + 40 Oak Logs");
        UI.WriteLine("10. Mithril Axe: 50 Mithril + 50 Dark Oak Logs");
        //------------------------------------------------------------------
        UI.WriteLine("");
        UI.WriteLine("[Melee]");
        UI.WriteLine("11. Flint Dagger: 25 Flint + 5 Logs");
        UI.WriteLine("12. Stone Mace: 50 Stone + 10 Birch Logs");
        UI.WriteLine("13. Copper Spear: 75 Copper + 15 Spruce Logs");
        UI.WriteLine("14. Iron Sword: 100 Iron + 20 Oak Logs");
        UI.WriteLine("15. Mithril Longsword: 150 Mithril + 25 Spruce Logs");
        //-------------------------------------------------------------------
        UI.WriteLine("");
        UI.WriteLine("[Range]");
        UI.WriteLine("16. Slingshot: 25 Logs");
        UI.WriteLine("17. Bow: 50 Birch Logs");
        UI.WriteLine("18. Crossbow: 75 Spruce Logs");
        UI.WriteLine("19. Longbow: 100 Oak Logs");
        UI.WriteLine("20. Warbow: 150 Dark Oak Logs");
        //------------------------------------------
        UI.WriteLine("");
        UI.WriteLine("[Magic]");
        UI.WriteLine("21. Wand: 25 Amethyst");
        UI.WriteLine("22. Magic Sigil: 50 Sapphire");
        UI.WriteLine("23. Staff: 75 Topaz");
        UI.WriteLine("24. Spellbook: 100 Ruby");
        UI.WriteLine("25. Dark Grimoire: 150 Diamond");
        UI.WriteLine("26. Exit");
        UI.WriteLine("");
        UI.TypeWrite("What would you like to craft: ");

        string craftedItemName = "item";
        string craftingChoice = Console.ReadLine().Trim().ToLower();
        int exit = 0;
        bool successfullyCrafted = CraftItem(craftingChoice, woodcutting, mining, inventory, out exit);
        UI.ConsoleDefault(player, woodcutting, mining, inventory, null);
        
        
        // If failed to crafted, run this
            if (successfullyCrafted)
            {
                UI.TypeWriteLine("Item has been crafted successfully!");
                UI.TypeWriteLine("What would you like to do next?");
                UI.TypeWriteLine("1. Craft something else");
                UI.TypeWrite("2. Exit");
        
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "craft something else" || choice == "1")
                {
                    PrintCraftingMenu(player, woodcutting, mining, inventory);
                }
                else if (choice == "2" || choice == "exit")
                {
                    return;
                }
            }
            else
            {
                if (exit == 1)
                {
                    return;
                }
                
                // Not enough mats
                UI.TypeWriteLine("You don't have enough materials to craft this.");
                UI.TypeWriteLine("1. Craft something else");
                UI.TypeWrite("2. Exit");
                
                // craft something new or exit
                string failedCraft = Console.ReadLine().Trim().ToLower();
                
                if (failedCraft == "1" || failedCraft == "craft something else")
                {
                    PrintCraftingMenu(player, woodcutting, mining, inventory);
                }
                else if (failedCraft == "2" || failedCraft == "exit")
                {
                    return;
                }
                else return;
            }
        
        
        
        
    }

    // Woodcutting, Mining, Inventory, is not needed at all, it's just to send a console default to display our level values 
    // at the top of the UI. So this is really just spaghetti code :(
    public bool CraftItem(string itemToCraft, Woodcutting woodcutting, Mining mining, Inventory inventory, out int exit)
    {

        exit = 0;
        
        if (itemToCraft == "1" || itemToCraft == "flint pickaxe")
        {
            if (flint >= 10 && log >= 10)
            {
                // Successfully crafted
                flintpickaxe += 1;
                flint -= 10;
                log -= 10;
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (itemToCraft == "2" || itemToCraft == "stone pickaxe")
        {
            if (stone >= 20 && birchlog >= 20)
            {
                // Successfully crafted
                stonepickaxe += 1;
                stone -= 20;
                birchlog -= 20;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
            
        }
        else if (itemToCraft == "3" || itemToCraft == "copper pickaxe")
        {
            if (copper >= 30 && sprucelog >= 30)
            {
                // Successfully crafted
                copperpickaxe += 1;
                copper -= 30;
                sprucelog -= 30;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
            
        }
        else if (itemToCraft == "4" || itemToCraft == "iron pickaxe")
        { 
            if (iron >= 40 && oaklog >= 40)
            {
                // Successfully crafted
                ironpickaxe += 1;
                iron -= 40;
                oaklog -= 40;
                
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
            
        }
        else if (itemToCraft == "5" || itemToCraft == "mithril pickaxe")
        {
            if (mithril >= 50 && darkoaklog >= 50)
            {
                // Successfully crafted
                mithrilpickaxe += 1;
                mithril -= 50;
                darkoaklog -= 50;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
            
        }
        else if (itemToCraft == "6" || itemToCraft == "flint axe")
        {
            if (flint >= 10 && log >= 10)
            {
                // Successfully crafted
                flintaxe += 1;
                flint -= 10;
                log -= 10;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
            
        }
        else if (itemToCraft == "7" || itemToCraft == "stone axe")
        {
            if (stone >= 20 && birchlog >= 20)
            {
                // Successfully crafted
                stoneaxe += 1;
                stone -= 20;
                birchlog -= 20;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
            
        }
        else if (itemToCraft == "8" || itemToCraft == "copper axe")
        {
            if (copper >= 30 && sprucelog >= 30)
            {
                // Successfully crafted
                copperaxe += 1;
                copper -= 30;
                sprucelog -= 30;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
            
        }
        else if (itemToCraft == "9" || itemToCraft == "iron pickaxe")
        {
            if (iron >= 40 && oaklog >= 40)
            {
                // Successfully crafted
                ironpickaxe += 1;
                iron -= 40;
                oaklog -= 40;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "10" || itemToCraft == "mithril pickaxe")
        {
            if (mithril >= 50 && darkoaklog >= 50)
            {
                // Successfully crafted
                mithrilpickaxe += 1;
                mithril -= 50;
                darkoaklog -= 50;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "11" || itemToCraft == "flint dagger")
        {
            if (flint >= 25 && log >= 5)
            {
                // Successfully crafted
                flintdagger += 1;
                flint -= 25;
                log -= 5;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "12" || itemToCraft == "stone mace")
        {
            if (stone >= 50 && birchlog >= 10)
            {
                // Successfully crafted
                stonemace += 1;
                stone -= 50;
                birchlog -= 10;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "13" || itemToCraft == "copper spear")
        {
            if (copper >= 75 && sprucelog >= 15)
            {
                // Successfully crafted
                copperspear += 1;
                copper -= 75;
                sprucelog -= 15;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "14" || itemToCraft == "iron sword")
        {
            if (iron >= 100 && oaklog >= 20)
            {
                // Successfully crafted
                ironsword += 1;
                iron -= 100;
                oaklog -= 20;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "15" || itemToCraft == "mithril longsword")
        {
            if (mithril >= 150 && darkoaklog >= 25)
            {
                // Successfully crafted
                mithrillongsword += 1;
                mithril -= 150;
                darkoaklog -= 25;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "16" || itemToCraft == "slingshot")
        {
            if (log >= 25)
            {
                // Successfully crafted
                slingshot += 1;
                log -= 25;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "17" || itemToCraft == "bow")
        {
            if (birchlog >= 50)
            {
                // Successfully crafted
                bow += 1;
                birchlog -= 50;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "18" || itemToCraft == "crossbow")
        {
            if (sprucelog >= 75)
            {
                // Successfully crafted
                crossbow += 1;
                sprucelog -= 75;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "19" || itemToCraft == "longbow")
        {
            if (oaklog >= 100)
            {
                // Successfully crafted
                longbow += 1;
                oaklog -= 100;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "20" || itemToCraft == "warbow")
        {
            if (darkoaklog >= 150)
            {
                // Successfully crafted
                warbow += 1;
                darkoaklog -= 150;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "21" || itemToCraft == "wand")
        {
            if (amethyst >= 25)
            {
                // Successfully crafted
                wand += 1;
                amethyst -= 25;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "22" || itemToCraft == "magic sigil")
        {
            if (sapphire >= 50)
            {
                // Successfully crafted
                magicsigil += 1;
                sapphire -= 50;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "23" || itemToCraft == "staff")
        {
            if (topaz >= 75)
            {
                // Successfully crafted
                staff += 1;
                topaz -= 75;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "24" || itemToCraft == "spellbook")
        {
            if (ruby >= 100)
            {
                // Successfully crafted
                spellbook += 1;
                ruby -= 100;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        else if (itemToCraft == "25" || itemToCraft == "dark grimoire")
        {
            if (diamond >= 150)
            {
                // Successfully crafted
                darkgrimoire += 1;
                diamond -= 150;
                return true;
            }
            else
            {
                // Failed to craft
                return false;
            }
        }
        
        if (itemToCraft == "26" || itemToCraft == "exit")
        {

            exit = 1;


        }
        
        return false;

    }
    
    
}