using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public GameObject PlayerArea;
    public GameObject gameCard;
    public List<GameObject> hand = new List<GameObject>();
    public int handSize = 5;
    public bool isEmpty = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Draw ()
    {
        if (hand.Count==0) {
            for (int i=0;i < 5;i++)
            {
                hand.Add(Instantiate(gameCard) as GameObject);
                hand[i].GetComponent<ThisCard>().thisId = Random.Range(0, 3);
                //only two types of cards currently. expand Range to include sum of cards
                hand[i].transform.SetParent(PlayerArea.transform, false);
                
            }
        }
    }

}
