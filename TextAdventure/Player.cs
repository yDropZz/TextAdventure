namespace TextAdventure;

public class Player : Entity
{
    private int playerLevel = 1;
    private int playerXp;
    private int playerXpReq = 20;
    private int melleXp;
    private int melleXpReq = 20;
    private int rangeXp;
    private int rangeXpReq = 20;
    private int magicXp;
    private int magicXpReq  = 20;

    public Player()
    {
        SetMaxHP(10);
    }
    private void AddXp(int amount, int typ)
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
    
}

