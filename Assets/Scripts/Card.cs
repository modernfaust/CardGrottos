using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "New Card", menuName = "Cards", order = 21)]
[System.Serializable]

public class Card : MonoBehaviour
{
    public new string name;
    public string description;
    public string cardType;

    public Sprite artwork;

    public int playCost;
    public int attackDamage;
    public int blockAmount;
    public int healAmount;

    //from Cezary_Sharp
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    public Card()
    {
        //constructor

    }

    public Card(int id, string cardName, int cost, int power, string cardDescription)
    {
        id=id;
        cardName=cardName;
        cost=cost;
        power=power;
        cardDescription=cardDescription;
    }

}

