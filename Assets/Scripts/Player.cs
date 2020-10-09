using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public int health;
    public int armor;
    public int stamina;
    public Text showHealth;
    public Text showArmor;
    public Text showStamina;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showHealth.text="Healh: "+health;
        showArmor.text="Armor: "+armor;
        showStamina.text="Stamina: "+stamina;
    }

    public void Attack(int power)
    {
        if (GameObject.Find("Enemy").GetComponent<Enemy>().armor == 0)
        {
            GameObject.Find("Enemy").GetComponent<Enemy>().health-=power;
        }
        else if (GameObject.Find("Enemy").GetComponent<Enemy>().armor-power < 0){
            GameObject.Find("Enemy").GetComponent<Enemy>().armor=0;
        }
        else
        {
            GameObject.Find("Enemy").GetComponent<Enemy>().armor-=power;
        };
    }
    public void Block(int power)
    {
        if (armor + power > 50)
        {
            armor=50;
        }
        else {
            armor+=power;
        }
    }
    public void Heal(int power)
    {
        if (health + power > 100)
        {
            health = 100;
        }
        else {
            health+=power;
        }
    }
}
