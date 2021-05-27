using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject Canvas;
    public List<Object> dropZones; //size determined in editor
    private bool isDragging = false;
    private bool isOverDropZone = false;
    private GameObject dropZone;
    private GameObject startParent;
    private Vector2 startPosition;
    private List<bool> occupiedZone;


    private void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
        dropZones.Add(GameObject.Find("A1")); 
        dropZones.Add(GameObject.Find("A2")); 
        dropZones.Add(GameObject.Find("A3")); 
        dropZones.Add(GameObject.Find("B1")); 
        dropZones.Add(GameObject.Find("B2")); 
        dropZones.Add(GameObject.Find("B3")); 
        dropZones.Add(GameObject.Find("C1")); 
        dropZones.Add(GameObject.Find("C2")); 
        dropZones.Add(GameObject.Find("C3")); 
        dropZones.Add(GameObject.Find("D1")); 
        dropZones.Add(GameObject.Find("D2")); 
        dropZones.Add(GameObject.Find("D3")); 
        dropZones.Add(GameObject.Find("E1")); 
        dropZones.Add(GameObject.Find("E2")); 
        dropZones.Add(GameObject.Find("E3")); 
        //need to distinguish non-drop zones, occupied drop zones
    }
    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
        Debug.Log(collision.gameObject.tag);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }

    public void StartDrag()
    {
        startParent = transform.parent.gameObject;
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;
        if (isOverDropZone)
        {
            transform.SetParent(dropZone.transform, false);



            //Debug.Log("this happened");
            //Debug.Log(dropZone.name);
            //ThisCard should be passed to a GameLogic handler
            


            switch (this.GetComponent<ThisCard>().cardType)
            {
                case "Attack":
                    Debug.Log("attack happened");
                    GameObject.Find("Player").GetComponent<Player>().Attack(this.GetComponent<ThisCard>().power);
                    break;
                case "Block":
                    Debug.Log("defend happened");
                    GameObject.Find("Player").GetComponent<Player>().Block(this.GetComponent<ThisCard>().power);
                    break;
                case "Heal":
                    Debug.Log("heal happened");
                    GameObject.Find("Player").GetComponent<Player>().Heal(this.GetComponent<ThisCard>().power);
                    break;
            }
            //this.GetComponent<PlayerHand>().cards_inHand-=1;
        }
        else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }
    }
}
