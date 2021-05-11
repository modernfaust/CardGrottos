using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();
    //public GameObject PlayerDeckZone;
    //public GameObject CardBack;
    public int deckSize = 40;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        x=0;
        for (int i=0;i<deckSize;i++)
        {
            x= Random.Range(1,3);
            deck[i] = CardDatabase.cardList[x];
        }
        //CardBack.transform.SetParent(PlayerDeckZone.transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shuffle()
    {
        for(int i =0; i <deckSize; i++)
        {
            //container size should be 1
            container[0] = deck[i];
            int randomIndex = Random.Range(i,deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }

    }
}
