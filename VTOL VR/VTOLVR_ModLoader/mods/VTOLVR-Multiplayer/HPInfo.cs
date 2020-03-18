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
	float WEAPONSGRADE.TOTAL_AMOUNT = (120)
	float TOTAL_PLAYERS = (1<->WEAPONSGRADE.TOTAL_AMOUNT) 
        this.hpName = hpName;
        this.weaponType = 0x100:0X3TOTAL_PLAYERS;
        this.missileUIDS = 0x110:0X3TOTAL_PLAYERS;
    }
}