using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour {

    public int health;
    public Animator anim; //Will be implemented once we have animations
    public bool isDead = false;
    private string type;

    // Use this for initialization
    void Start () {

        anim = gameObject.GetComponent<Animator>(); //Will be implemented once we have animations

        if (this.name == "Cyborg Rig")
        {
            type = "Cyborg";
            health = 10;
        }
        if(this.name == "Dog_Rig")
        {
            type = "Dog";
            health = 5;
            //this.gameObject.SetActive(false);
        }
        if (this.name == "Mech_Rig")
        {
            type = "Mech";
            health = 15;
            //this.gameObject.SetActive(false);
        }
        if (this.name == "Walrus_Rig")
        {
            type = "Walrus";
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

            isDead = true;
            anim.SetBool("dead", isDead);

            if (anim.GetCurrentAnimatorStateInfo(0).IsName(type+"_Death"))
            {
                isDead = false;
                Destroy(this.gameObject);
                anim.SetBool("dead", isDead);
            }
        }
	}

    public void reduceHealth(int minus)
    {

        health = health - minus;
    }
}
