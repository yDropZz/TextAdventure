namespace TextAdventure;

public class Combat
{

    public void StartCombat(Player player, Enemy enemy)
    {
        while (!player.IsDead && !enemy.IsDead)
        {
            UI.WriteLine("1. Melee ");
            UI.WriteLine("2. Range");
            UI.WriteLine("3. Magic");
            UI.WriteLine("4. Block");
            UI.WriteLine("5. Escape");
            
        }
        
        
        
    }
    
    
    
}