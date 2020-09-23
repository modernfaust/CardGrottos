using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[CreateAssetMenu(fileName = "New Card", menuName = "Cards", order = 21)]
[System.Serializable]

public class Card
{
/*     public new string name;
    public string description;
    public string cardType;

    public Sprite artwork;

    public int playCost;
    public int attackDamage;
    public int blockAmount;
    public int healAmount; */

    //from Cezary_Sharp
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    public Sprite thisImage;

    public Card()
    {
        //constructor
    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDescription, Sprite ThisImage)
    {
        id=Id;
        cardName=CardName;
        cost=Cost;
        power=Power;
        cardDescription=CardDescription;
        thisImage=ThisImage;
    }

}

