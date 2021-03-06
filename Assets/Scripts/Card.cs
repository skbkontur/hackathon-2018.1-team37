﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Action
{
	DamageEnemy,
	DamageSelf,
	DamageBoth,
	Heal,
	Evade
}

[CreateAssetMenu(fileName = "Card", menuName = "WildCard/Card", order = 1)]
public class Card : ScriptableObject {

	public string _cardName;
	public Action _ActionType;
	public uint _value;
	public uint _chanceCoefficient;
	public Sprite _NotSelectedImage;
    public Sprite _SelectedImage;

}
