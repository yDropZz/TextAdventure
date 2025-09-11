using System.Runtime.CompilerServices;

namespace TextAdventure;

public class Enemy : Entity
{
    private int level;
    public void GenerateEnemy(string type)
    {
        Random random = new Random();
        
        if (type == "goblin")
        {
            //Roll random level
            level = random.Next(1, 11);
            // Roll hp
            float hpRoll = 3 + (level * 0.5f);
            //Set hp to the roll
            HPMax = (int)hpRoll;
            // Roll damage
            float damageroll = 1 + (level * 0.25f);
            //Set damge to the roll
            Melee = (int)damageroll;
            //Roll the type of goblin
            int x = random.Next(1,4);
            if (x == 1)
            {
                Name = "Dagger Goblin";
                MeleeDefence = random.Next(0, 0);
                RangeDefence = random.Next(level, level+20);
                MagicDefence = random.Next(-100+level, -50+level);
            }
            else if (x == 2)
            {
                Name = "Spear Goblin";
                MeleeDefence = random.Next(-100+level, -50+level);
                RangeDefence = random.Next(0,0);
                MagicDefence = random.Next(level, level+20);
            }
            else if (x == 3)
            {
                Name = "Staff Goblin";
                MeleeDefence = random.Next(level, level+20);
                RangeDefence = random.Next(-100+level, -50+level);
                MagicDefence = random.Next(0,0);
            }
            
        }
        else if (type == "wolf")
        {
            //Roll random level
            level = random.Next(3, 13);
            // Roll hp
            float hpRoll = 5 + (level);
            //Set hp to the roll
            HPMax = (int)hpRoll;
            // Roll damage
            float damageroll = 1 + (level * 0.25f);
            //Set damge to the roll
            Melee = (int)damageroll;
            
            Name = "Wolf";
            MeleeDefence = random.Next(0, 0);
            RangeDefence = random.Next(level, level+30);
            MagicDefence = random.Next(-100+level, -50+level);
        }
        else if (type == "skeleton")
        {
            //Roll random level
            level = random.Next(15, 31);
            // Roll hp
            float hpRoll = 2 + (level * 0.5f);
            //Set hp to the roll
            HPMax = (int)hpRoll;
            // Roll damage
            float damageroll = 1 + (level * 0.25f);
            //Set damge to the roll
            Melee = (int)damageroll;
            //Roll the type of skeleton
            int x = random.Next(1,4);
            if (x == 1)
            {
                Name = "Skeleton Solider";
                MeleeDefence = random.Next(10, 16);
                RangeDefence = random.Next(level+20, level+30);
                MagicDefence = random.Next(-80+level, -70+level);
            }
            else if (x == 2)
            {
                Name = "Skeleton Archer";
                MeleeDefence = random.Next(-80+level, -70+level);
                RangeDefence = random.Next(10,16);
                MagicDefence = random.Next(level+20, level+30);
            }
            else if (x == 3)
            {
                Name = "Skeleton Mage";
                MeleeDefence = random.Next(level+20, level+30);
                RangeDefence = random.Next(-80+level, -70+level);
                MagicDefence = random.Next(10,16);
            }
            
        }
        else if (type == "orc")
        {
            //Roll random level
            level = random.Next(25, 36);
            // Roll hp
            float hpRoll = 10 + (level);
            //Set hp to the roll
            HPMax = (int)hpRoll;
            // Roll damage
            float damageroll = 1 + (level * 0.25f);
            //Set damge to the roll
            Melee = (int)damageroll;

            Name = "Orc";
            MeleeDefence = random.Next(20, 30);
            RangeDefence = random.Next(level+30, level+25);
            MagicDefence = random.Next(-60+level, -40+level);
        }
        else if (type == "demon")
        {
            //Roll random level
            level = random.Next(40, 51);
            // Roll hp
            float hpRoll = 5 + (level);
            //Set hp to the roll
            HPMax = (int)hpRoll;
            // Roll damage
            float damageroll = 1 + (level * 0.25f);
            //Set damge to the roll
            Melee = (int)damageroll;

            Name = "Demon";
            MeleeDefence = random.Next(25, 36);
            RangeDefence = random.Next(level+20, level+25);
            MagicDefence = random.Next(-100+level, -50+level);
        }
        else if (type == "dragon")
        {
            //Roll random level
            level = random.Next(60, 76);
            // Roll hp
            float hpRoll = 45 + (level *1.5f);
            //Set hp to the roll
            HPMax = (int)hpRoll;
            // Roll damage
            float damageroll = 1 + (level * 0.25f);
            //Set damge to the roll
            Melee = (int)damageroll;

            Name = "Jefferson Dragon";
            MeleeDefence = random.Next(25, 36);
            RangeDefence = random.Next(level+20, level+25);
            MagicDefence = random.Next(-100+level, -50+level);
        }
        else if (type == "boss")
        {
            //Roll random level
            level = 100;
            // Roll hp
            float hpRoll = (level * 2);
            //Set hp to the roll
            HPMax = (int)hpRoll;
            // Roll damage
            float damageroll = 1 + (level * 0.25f);
            //Set damge to the roll
            Melee = (int)damageroll;

            Name = "Demon Lord";
            MeleeDefence = 50;
            RangeDefence = 50;
            MagicDefence = 50;
        }

        HP = HPMax;
        IsDead = false;

    }
}