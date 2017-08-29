using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Spine;
using Spine.Unity;
using UnityEngine;

public enum HeroClass
{
    Abomination,
    Antiquarian,
    Arbalest,
    BountyHunter,
    Crusader,
    GraveRobber,
    Hellion,
    Highwayman,
    Houndmaster,
    Jester,
    Leper,
    ManAtArms,
    Occultist,
    PlagueDoctor,
    Vestal
}
public enum MonsterClass
{
    CultistBrawler,
    CultistAcolyte,
    BrigandFusilier,
    BrigandBloodletter,
    BrigandRaider,
    BrigandHunter,
    Madman,
    Maggot,
    Webber,
    Spitter,
    BoneRabble,
    Ghoul,
    Gargoyle,
    Supplicant,
    Sycophant,
    Gatekeeper,
    Chevalier,
    Shambler,
    ShamblerTentacle,
    TheCollector,
    CollectedHighwayman,
    CollectedManAtArms,
    CollectedVestal,
    TheFanatic,
    Pyre
}

public enum MonsterType
{
    Human,
    Beast,
    Unholy,
    UnholyBeast,
    BloodSucker,
    Eldritch,
    HumanEldtitch,
    UnholyWood
}

public interface ICharacterBehaviour
{
    void SayHello();
    void LoadData();
    void SayHello2();
}

public interface IBattleBehavior
{
    void Attack(Character character, CombatSkill combatSill=null, Abilitie abilitie=null);
}

public class Character : MonoBehaviour, ICharacterBehaviour, IBattleBehavior
{
    public BaseStats BaseStats;
    public Resistance Resistance;
    public Transform Transform;
    public string type;
    public Animator animator;
    
    public List<Quirk> Quirks;
    public List<Item> Equipment;
    public List<CombatSkill> CombatSkills;
    public List<CampingSkill> CampingSkills;
    public List<Disease> Diseases;
    public virtual void SayHello(){}
    public virtual void LoadData(){}
    public virtual void Attack(Character character, CombatSkill combatSill=null, Abilitie abilitie=null){}

    void Awake()
    {
        BaseStats = gameObject.GetComponent<BaseStats>();
        Resistance = gameObject.GetComponent<Resistance>();
        Transform = gameObject.transform;
        animator = gameObject.GetComponent<Animator>();
       
    }

    public void Animation_DoubleShift()
    {
        animator.SetTrigger("DoubleShift");
    }
    public void Animation_Damage()
    {
        animator.SetTrigger("DoubleShift");
    }

    public void SayHello2()
    {
        print(gameObject.name + "; " + BaseStats.MaxHp);
    }
}
