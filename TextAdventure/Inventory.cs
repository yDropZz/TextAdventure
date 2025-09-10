using System.Diagnostics;

namespace TextAdventure;

public class Inventory
{
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
                value =2;
                
            }
            if (GetItem("stonemace") == 1)
            {
                value=3;
                    
            }
            if (GetItem("copperspear") == 1)
            {
                value=4;
                        
            }
            if (GetItem("ironsword") == 1)
            {
                value=5;
                            
            }
            if (GetItem("mithrillongsword") == 1)
            {
                value=6;
            }
            return value;
        }
        else if (type == "magic")
        {
            float value = 1;
            if (GetItem("wand") == 1)
            {
                value =1;
                
            }
            if (GetItem("magicsigil") == 1)
            {
                value=2;
                    
            }
            if (GetItem("staff") == 1)
            {
                value=3;
                        
            }
            if (GetItem("spellbook") == 1)
            {
                value=4;
                            
            }
            if (GetItem("darkgrimoire") == 1)
            {
                value=5;
            }
            return value;
        }
        else if (type == "range")
        {
            float value = 1;
            if (GetItem("slingshot") == 1)
            {
                value =1;
                
            }
            if (GetItem("bow") == 1)
            {
                value=2;
                    
            }
            if (GetItem("crossbow") == 1)
            {
                value=3;
                        
            }
            if (GetItem("longbow") == 1)
            {
                value=4;
                            
            }
            if (GetItem("warbow") == 1)
            {
                value=5;
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
            if (GetItem("flintdagger") == 1)
            {
                value =2;
                
            }
            if (GetItem("stonemace") == 1)
            {
                value=3;
                    
            }
            if (GetItem("copperspear") == 1)
            {
                value=4;
                        
            }
            if (GetItem("ironsword") == 1)
            {
                value=5;
                            
            }
            if (GetItem("mithrillongsword") == 1)
            {
                value=6;
            }
            return value;
        }
        else if (type == "axe")
        {
            float value = 1;
            if (GetItem("wand") == 1)
            {
                value =1;
                
            }
            if (GetItem("magicsigil") == 1)
            {
                value=2;
                    
            }
            if (GetItem("staff") == 1)
            {
                value=3;
                        
            }
            if (GetItem("spellbook") == 1)
            {
                value=4;
                            
            }
            if (GetItem("darkgrimoire") == 1)
            {
                value=5;
            }
            return value;
        }
        return 0;
    }

    public void PrintInventory()
    {
        Console.Clear();
        UI.WriteLine("[Resources]");
        UI.WriteLine($"Flint:{flint}, Stone:{stone}, Copper:{copper}, Iron:{iron}, Mithril:{mithril}");
        UI.WriteLine($"Amethyst:{amethyst}, Sapphire:{sapphire}, Topaz:{topaz}, Ruby:{ruby}, Diamond:{diamond}");
        UI.WriteLine($"Log:{log}, Birch logs:{birchlog}, Spruce logs:{sprucelog}, Oak logs:{oaklog}, Dark oak logs:{darkoaklog}");
        UI.WriteLine($"[Tools]");
        UI.WriteLine($"Pickaxe:");
    }
    

}