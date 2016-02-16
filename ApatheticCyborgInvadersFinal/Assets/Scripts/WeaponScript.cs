using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

    bool online;
    public Sprite nightclub, beamSword, chair, sword;
    GameObject player;
    public int curWeapon = 1;
	// Use this for initialization
	void Start () {
        online = GameObject.Find("Character Rig").GetComponent<CharacterCont>().isAttacking;
        player = GameObject.Find("Character Rig");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Alpha1"))
        {
            this.GetComponent<SpriteRenderer>().sprite = nightclub;
            curWeapon = 1;
        }
        if (Input.GetButtonDown("Alpha2"))
        {
            this.GetComponent<SpriteRenderer>().sprite = beamSword;
            curWeapon = 2;
        }
        if (Input.GetButtonDown("Alpha3"))
        {
            this.GetComponent<SpriteRenderer>().sprite = chair;
            curWeapon = 3;
        }
        if (Input.GetButtonDown("Alpha4"))
        {
            this.GetComponent<SpriteRenderer>().sprite = sword;
            curWeapon = 4;
        }
        online = GameObject.Find("Character Rig").GetComponent<CharacterCont>().isAttacking;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (online)
        {
            if(col.gameObject.tag == "Enemy")
            {
                if (curWeapon == 1)
                {
                    col.gameObject.GetComponent<Combat>().reduceHealth(1);
                }
                if(curWeapon == 2)
                {
                    col.gameObject.GetComponent<Combat>().reduceHealth(5);
                }
                if(curWeapon == 3)
                {
                    col.gameObject.GetComponent<Combat>().reduceHealth(5);
                }
                if(curWeapon == 4)
                {
                    col.gameObject.GetComponent<Combat>().reduceHealth(3);
                }
            }
        }
    }
}
