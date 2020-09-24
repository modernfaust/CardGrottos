using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<Card> cardList = new List<Card> ();

    void Awake()
    {
        cardList.Add (new Card (0,"Cleave",1,25,"Take a swipe at the enemy", "Attack", Resources.Load<Sprite>("god"), "Red"));
        cardList.Add (new Card (1,"Fortify",2,25,"Wear some armor","Block", Resources.Load<Sprite>("god"), "Blue"));
        cardList.Add (new Card (2,"Potion",2,25,"Down a potion","Heal", Resources.Load<Sprite>("god"), "Green"));
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
