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
    }
}