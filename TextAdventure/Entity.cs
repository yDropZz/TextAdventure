namespace TextAdventure;

public class Entity
{
    private string name;
    public string Name { get => name; set => name = value; }
    private int hp = 10;
    public int HP { get => hp; set => hp = value; }
    private int hpMax =10;
    public int HPMax { get => hpMax; set => hpMax = value; }
    private int melee = 1;
    public int Melee { get => melee; set => melee = value; }
    private int range = 1;
    public int Range { get => range; set => range = value; }
    private int magic = 1;
    public int Magic { get => magic; set => magic = value; }
    private bool isDead = false;
    public bool IsDead { get => isDead; set => isDead = value; }
    private int meleeDefence;
    public int MeleeDefence { get => meleeDefence; set => meleeDefence = value; }
    private int rangeDefence;
    public int RangeDefence { get => rangeDefence; set => rangeDefence = value; }
    private int magicDefence;
    public int MagicDefence { get => magicDefence; set => magicDefence = value; }
    

    public int CalculateDamage(string type, Entity source, Entity target, Inventory inventory)
    {
        if (type == "melee")
        {
            float x = 1+ inventory.GetWeaponValue("melee")*((source.Melee) * (1 - (target.MeleeDefence / 100)));

            int y = (int)x;
            return y;
        }
        else if (type == "range")
        {
            float x = 1+ inventory.GetWeaponValue("range")*((source.Range) * (1 - (target.RangeDefence / 100)));

            int y = (int)x;
            return y;
        }
        else if (type == "magic")
        {
            float x = 1+ inventory.GetWeaponValue("magic")*((source.Magic) * (1 - (target.MagicDefence / 100)));

            int y = (int)x;
            return y;
        }
        else if (type == null)
        {
            return source.Melee;
        }
            
        return 0;
    }
    
    public void SetMaxHP(int amount)
    {
        hpMax = amount;
        hp = hpMax;
    }
    
    public void RemoveHp(int amount)
    {
        UI.WriteLine($"{this.name} took {amount} damage.");
        this.hp -= amount;
        
        if(this.hp <= 0)
            isDead = true;
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
}