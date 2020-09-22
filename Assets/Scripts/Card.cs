using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards", order = 21)]

public class Card : ScriptableObject
{
    public new string name;
    public string description;
    public string cardType;

    public Sprite artwork;

    public int playCost;
    public int attackDamage;
    public int blockAmount;
    public int healAmount;

}
