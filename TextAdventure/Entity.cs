namespace TextAdventure;

public class Entity
{
    private string name;
    public string Name { get => name; set => name = value; }
    private int hp;
    private int hpMax;
    private int melee;
    private int range;
    private int magic;
    private bool isDead = false;

    public void CalculateDamage()
    {
        
    }

    public void SetMaxHP(int amount)
    {
        hpMax = amount;
        hp = hpMax;
    }
    
    public void RemoveHp(int amount)
    {
        Console.WriteLine($"{this.name} took {amount} damage.");
        this.hp -= amount;
        
        if(this.hp <= 0)
            OnDeath();
    }

    public void AddHp(int amount)
    {
        this.hp += amount;
        if(this.hp >= this.hpMax)
            hp = this.hpMax;
    }

    public void SetHp(int amount)
    {
        this.hp = amount;
        if(this.hp >= this.hpMax)
            this.hp = this.hpMax;
        else if (this.hp <= 0)
            hp = 0;
    }

    private void OnDeath()
    {
        Console.Clear();
        Console.WriteLine($"{this.name} died");
        Console.ReadKey();
    }
}
