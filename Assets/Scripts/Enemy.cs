using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    public int health;
    public int armor;
    public Text showHealth;
    public Text showArmor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showHealth.text="Health: "+health;
        showArmor.text="Armor: "+armor;
    }
}
