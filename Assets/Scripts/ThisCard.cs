using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystem;

public class ThisCard : MonoBehaviour
{
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
        thisCard[0] = CardDatabase.cardList(thisId);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
