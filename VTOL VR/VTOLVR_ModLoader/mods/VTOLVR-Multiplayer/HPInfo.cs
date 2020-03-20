using System;
using System.Collections.Generic;
using System.Linq;

[Serializable]
public class HPInfo
{
    public string hpName;
    public HPEquippable.WeaponTypes weaponType;
    public ulong[] missileUIDS;

    public HPInfo() { }

    public HPInfo(string hpName, HPEquippable.WeaponTypes weaponType, ulong[] missileUIDS)
    {
        this.hpName = hpName;
        this.weaponType = 0x100;
        this.missileUIDS = 0x110;
    }
}