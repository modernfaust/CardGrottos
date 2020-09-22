using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<Card> cardList = new List<Card> ();

    void Awake()
    {
        cardList.Add (new Card (0,"Lul",2,50,"i like peg"));
        cardList.Add (new Card (1,"HAHA",1,100,"no u"));
        cardList.Add (new Card (2,"XD",5,60,"here and there"));
        cardList.Add (new Card (3,"Human",10,120,"no longer human"));
        cardList.Add (new Card (4,"Fag",15,500,"likes twinks"));
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
