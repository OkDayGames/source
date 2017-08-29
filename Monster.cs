using System.Collections;
using System.Collections.Generic;

public class Monster : Character
{
	//Инициализируются вручную
	public MonsterClass MonsterClass;
	public MonsterType MonsterType;
	public Attribute.Abilitie[] _abilities;
	public Abilitie[] abilities;
    
	public override void SayHello()
	{
		//MonsterClass = MonsterClass.Chevalier;
		//print("Monster: " + MonsterClass + "; " + Resistance.Bleed);
		//SayHello2();
		print(BaseStats.Dmg);
	}

	public Monster()
	{
		//Resistance = new Resistance();
		//BaseStats = new BaseStats();
		//Resistance.Bleed = 21f;
		//BaseStats.Dmg = 51;
		//abilities = new Abilitie[2];
		//abilities[0] = new Abilitie();
		//abilities[1] = new Abilitie();
		//Init();
		//SayHello2();
	}
	public void Attack(Character character, Abilitie _abilitie)
	{
		print("monster attack");
		_abilitie.Modify(character);
	}
	public void Init()
	{
		//abilities[0]._name = Attribute.Abilitie.BlanketFire;
		//abilities[1]._name = Attribute.Abilitie.EldritchPush;
		//print("!- " + abilities);
		foreach (Abilitie cs in abilities)
		{
			//print(cs._name);
		}
		type = MonsterClass.ToString();
	}	
}
