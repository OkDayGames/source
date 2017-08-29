using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats: MonoBehaviour
{
    public float _maxHp;
    public float _stress;
    public float _dodge;
    public float _prot;
    public float _spd;
    public float _accMod;
    public float _crit;
    public float _minDmg;
    public float _maxDmg;
    public float _dmg;

    public float MaxHp
    {
        get { return _maxHp; }
        set { _maxHp = value; }
    }

    public float Stress
    {
        get { return _stress; }
        set { _stress = value; }
    }
    public float Dodge
    {
        get { return _dodge; }
        set { _dodge = value; }
    }
    public float Prot
    {
        get { return _prot; }
        set { _prot = value; }
    }
    public float Spd
    {
        get { return _spd; }
        set { _spd = value; }
    }
    public float AccMod
    {
        get { return _accMod; }
        set { _accMod = value; }
    }
    public float Crit
    {
        get { return _crit; }
        set { _crit = value; }
    }
    public float MinDmg
    {
        get { return _minDmg; }
        set { _minDmg = value; }
    }
    public float MaxDmg
    {
        get { return _maxDmg; }
        set { _maxDmg = value; }
    }
    public float Dmg
    {
        get { return _dmg; }
        set
        {
            //Get random value minDmg<=dmg<=maxDmg
            _dmg = value;
        }
    }
}
