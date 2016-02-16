using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
	    if(this.name == "Cyborg Rig")
        {
            health = 10;
        }
        if(this.name == "Dog_Rig")
        {
            health = 5;
            //this.gameObject.SetActive(false);
        }
        if (this.name == "Mech_Rig")
        {
            health = 15;
            //this.gameObject.SetActive(false);
        }
        if (this.name == "Walrus_Rig")
        {
            health = 30;
            //this.gameObject.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
	    if(health <= 0)
        {
            if (this.name == "Cyborg Rig")
            {
                GameObject.Find("GameController").GetComponent<GameController>().addMoney(5);
            }
            if (this.name == "Dog_Rig")
            {
                GameObject.Find("GameController").GetComponent<GameController>().addMoney(3);
            }
            if (this.name == "Mech_Rig")
            {
                GameObject.Find("GameController").GetComponent<GameController>().addMoney(10);
            }
            if (this.name == "Walrus_Rig")
            {
                GameObject.Find("GameController").GetComponent<GameController>().addMoney(20);
            }
            Destroy(this.gameObject);
        }
	}

    public void reduceHealth(int minus)
    {
        health = health - minus;
    }
}
