using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThisCard : MonoBehaviour
{
    //set thisCard to 1 in editor
    public List<Card> thisCard = new List<Card>();
    public int thisId;
    public int id;
    public string cardName;
    public int cost;
    public int power;

    public string cardDescription;

    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;


    // Start is called before the first frame update
    void Start()
    {
        thisCard[0] = CardDatabase.cardList[thisId];
    }

    // Update is called once per frame
    void Update()
    {
        id = thisCard[0].id;
        cardName=thisCard[0].cardName;
        cost=thisCard[0].cost;
        power=thisCard[0].power;
        cardDescription=thisCard[0].cardDescription;
        //Debug.Log(nameText);
        nameText.text = ""+cardName;
        costText.text = ""+cost;
        powerText.text = ""+power;
        descriptionText.text = ""+cardDescription;
    }
}
