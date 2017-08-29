using System.Collections;
using System.Collections.Generic;

public struct Attribute
{
    public enum CombatSkill
    {
        Transform,
        Manacles,
        BeastsBile,
        Absolution,
        Rake,
        Rage,
        Slam,
        SniperShot,
        SuppressingFire,
        SnipersMark,
        Bola,
        Blindfire,
        BattlefieldBandage,
        RallyingFlare,
        CollectBounty,
        MarkForDeath,
        ComeHither,
        Uppercut,
        Flashbang,
        FinishHim,
        HookAndSlice,
        Smite,
        ZealousAccusation,
        StunningBlow,
        BulwardOfFaith,
        BattleHeal,
        HolyLance,
        InspiringCry,
        PickToTheFace,
        Lunge,
        FlashingDaggers,
        ShadowFade,
        ThrownDagger,
        PoisonDart,
        ToxinTrickery,
        WickedHack,
        IronSwan,
        BarbaricYAWP,
        IfItBleeds,
        Breakthru,
        AdrenalineRush,
        BleedOut,
        WickedSlice,
        PistolShot,
        PointBlankShot,
        GrapeshotBlast,
        TrackingShot,
        DuelistsAdvance,
        OpenVein,
        HoundsRush,
        HoundsHarry,
        Whistle,
        Howl,
        GuardDog,
        LickWounds,
        Blackjack,
        DirkStab,
        Harvest,
        HeroicEnd,
        Solo,
        SliceOff,
        BattleBallad,
        InspiringTune,
        Chop,
        Hew,
        Purge,
        Revenge,
        Withstand,
        Solemnity,
        Intimidate,
        Crush,
        Rampart,
        Bellow,
        Defender,
        Retribution,
        Command,
        Bolster,
        SacrificialStab,
        AbyssalArtillery,
        WeakeningCurse,
        WyrdReconstruction,
        VulnerabilityHex,
        HandsFromTheAbyss,
        DaemonsPull,
        NoxiousBlast,
        PlagueGrenade,
        BlindingGas,
        Incision,
        BattlefieldMedicine,
        EmboldeningVapours,
        DisorientingBlast,
        MaceBash,
        Judgement,
        DazzlingLight,
        DivineGrave,
        DivineComfort,
        Illumination,
        HandOfLight,
    }

    public enum Limit
    {
        OncePerBattle
    }

    public enum Abilitie
    {
        RendForTheOldGods,
        StumblingScratch,
        EldritchPull,
        EldritchPush,
        StressfulIncantation,
        SliceAndDice,
        UppercutSlice,
        Shank,
        HarmlessPoke,
        BlanketFire,
        RushedShot,
        RainOfWhips,
        Punishment,
        PointBlankShot,
    }
    public enum AttackType
    {
        Transformation,
        Ranged,
        Heal,
        Melee,
        Buff,
    }
}

public class CombatSkill
{
    public Attribute.CombatSkill _name;
    private Attribute.AttackType _type;
    private Attribute.Limit _limit;
    
    private int _level;
    private bool isOpen;
    private string _image;
    
    private bool _rank_1;
    private bool _rank_2;
    private bool _rank_3;
    private bool _rank_4;

    private bool _target_1;
    private bool _target_2;
    private bool _target_3;
    private bool _target_4;
    private bool _target_self;
    private bool _target_party;

    public BaseStats _baseStats;
    public Resistance _resistance;

    //public Dictionary<string, float> _BaseStats;

    public CombatSkill()
    {
        _resistance = new Resistance();
        _baseStats = new BaseStats();
        //_baseStats.Dmg -= 1;
    }

    public void Modify(Character character)
    {
        _resistance = character.Resistance;
        _resistance.Bleed -= 0.444f;
        //character.BaseStats.Dmg += _baseStats.Dmg;
    }
}

public class Abilitie
{
    public Attribute.Abilitie _name;
    private Attribute.AttackType _type;
    private Attribute.Limit _limit;
    
    private int _level;
    private string _image;
    
    private bool _rank_1;
    private bool _rank_2;
    private bool _rank_3;
    private bool _rank_4;

    private bool _target_1;
    private bool _target_2;
    private bool _target_3;
    private bool _target_4;
    private bool _target_self;
    private bool _target_party;
    
    public BaseStats _baseStats;
    public Resistance _resistance;
    
    public Abilitie()
    {
        _resistance = new Resistance();
        _baseStats = new BaseStats();
        //_baseStats.Dmg -= 1;
    }

    public void Modify(Character character)
    {
        _resistance = character.Resistance;
        _resistance.Bleed -= 0.111f;
        //character.BaseStats.Dmg += _baseStats.Dmg;
    }
}
