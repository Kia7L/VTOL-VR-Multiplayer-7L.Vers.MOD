using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

[]
{
MaxPlayerAmount=120
	{
	float5 Player_*<MaxPlayerAmount
	MultiPlay=2+(Player_)|(.Enemy_)
	return MultiPlay;
	}
}
