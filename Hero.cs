using System.Collections;
using System.Collections.Generic;

public class Hero: Character
{   
    //Инициализируются вручную
    public HeroClass HeroClass;
    public Attribute.CombatSkill[] skills;
    public CombatSkill[] combatSkill;
    
    public override void SayHello()
    {
        print(BaseStats.Dmg);
    }

    public Hero()
    {
        /*
        Resistance = new Resistance();
        BaseStats = new BaseStats();
        Resistance.Bleed = 12f;
        //BaseStats.Dmg = 31;
        combatSkill = new CombatSkill[2];
        combatSkill[0] = new CombatSkill();
        combatSkill[1] = new CombatSkill();
        /Init();
        //SayHello2();
        */
    }

    public void Attack(Character character, CombatSkill _combatSkill)
    {
        _combatSkill.Modify(character);
        print("hero attack");
    }
    public void Init()
    {
        type = HeroClass.ToString();
    }
}
