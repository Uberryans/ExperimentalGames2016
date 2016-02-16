using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int playerHealth;
	// Use this for initialization
	void Start () {
        playerHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
	    if(playerHealth <= 0)
        {
            Application.LoadLevel("GameOver");
        }
	}
}
