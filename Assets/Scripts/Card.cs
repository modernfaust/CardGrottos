using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[CreateAssetMenu(fileName = "New Card", menuName = "Cards", order = 21)]
[System.Serializable]

public class Card : MonoBehaviour
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
    public string cardType;
    public Sprite thisImage;
    public string color;

    public Card()
    {
        //constructor
    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDescription, string CardType, Sprite ThisImage, string Color)
    {
        id=Id;
        cardName=CardName;
        cost=Cost;
        power=Power;
        cardDescription=CardDescription;
        thisImage=ThisImage;
        color=Color;
        cardType=CardType;
    }

}

