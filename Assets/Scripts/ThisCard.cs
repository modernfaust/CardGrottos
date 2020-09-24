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
    public string cardType;
    public string cardDescription;
    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;

    public Sprite thisSprite;
    public Image thatImage;
    public Image frame;
    public bool cardBack;
    public static bool staticCardBack;


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
        cardType=thisCard[0].cardType;
        cardDescription=thisCard[0].cardDescription;
        thisSprite = thisCard[0].thisImage;
        nameText.text = ""+cardName;
        costText.text = ""+cost;
        powerText.text = ""+power;
        descriptionText.text = ""+cardDescription;
        thatImage.sprite = thisSprite;
        //replace this with SOURCE IMAGES
        if(thisCard[0].color=="Red")
        {
            frame.GetComponent<Image>().color = new Color32(255,0,0,255);
        }
        else if(thisCard[0].color=="Blue")
        {
            frame.GetComponent<Image>().color = new Color32(0,0,255,255);
        }
        else if(thisCard[0].color=="Green")
        {
            frame.GetComponent<Image>().color = new Color32(0,255,0,255);
        }
        staticCardBack = cardBack;
    }
}
