namespace TextAdventure;

public class Player : Entity
{
    private int playerLevel = 1;
    private int playerXp;
    private int playerXpReq = 20;
    private int meleeXp;
    private int meleeXpReq = 20;
    private int rangeXp;
    private int rangeXpReq = 20;
    private int magicXp;
    private int magicXpReq  = 20;

    public Player()
    {
        SetMaxHP(10);
    }
    private void AddXp(int amount, int type)
    {
        if (type == 0)
        {
            playerXp += amount;
            if (playerXp >= playerXpReq)
            {
                playerXp -= playerXpReq;
                playerLevel++;

                playerXpReq += 4;
                Console.WriteLine("You leveled up! You are now level: " + playerLevel);
            }
        }
        else if (type == 1)
        {
            meleeXp += amount;
            if (meleeXp >= meleeXpReq)
            {
                meleeXp -= meleeXpReq;
                Melee++;

                meleeXpReq += 4;
                Console.WriteLine("You leveled up melee! You are now level: " + Melee);
            }
        }
        else if (type == 2)
        {
            rangeXp += amount;
            if (rangeXp >= rangeXpReq)
            {
                rangeXp -= rangeXpReq;
                Range++;

                rangeXpReq += 4;
                Console.WriteLine("You leveled up range! You are now level: " + Range);
            }
        }
        else if (type == 3)
        {
            magicXp += amount;
            if (magicXp >= magicXpReq)
            {
                magicXp -= magicXpReq;
                Magic++;

                magicXpReq += 4;
                Console.WriteLine("You leveled up magic! You are now level: " + Magic);
            }
        }
    }
    
}