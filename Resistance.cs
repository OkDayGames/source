using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistance: MonoBehaviour
{
    public float _stun;
    public float _blight;
    public float _bleed;
    public float _debuff;
    public float _disease;
    public float _deathBlow;
    public float _trap;
    public float _move;

    public float Stun
    {
        get { return _stun; }
        set { _stun = value; }
    }

    public float Blight
    {
        get { return _blight; }
        set { _blight = value; }
    }

    public float Bleed
    {
        get { return _bleed; }
        set { _bleed = value; }
    }

    public float Debuff
    {
        get { return _debuff; }
        set { _debuff = value; }
    }

    public float Disease
    {
        get { return _disease; }
        set { _disease = value; }
    }

    public float DeathBlow
    {
        get { return _deathBlow; }
        set { _deathBlow = value; }
    }

    public float Trap
    {
        get { return _trap; }
        set { _trap = value; }
    }

    public float Move
    {
        get { return _move; }
        set { _move = value; }
    }
}
