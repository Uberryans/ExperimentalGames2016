using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//This script should already be good to go; I just added a timer and made sure it changes
	//the level once the timer hits two minutes. 
    public int money;
    int secTimer = 0;
    int frameTimer = 0;
	// Use this for initialization
	void Start () {
        money = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    frameTimer++;
	    if(frameTimer % 60 == 0){
	    	secTimer++;
	    }

	    if(secTimer == 120){
	    	//GameObject.Find("LevelTransitioner").GetComponent<LevelTransitions>().changeLevel();
	    }
	}

    public void addMoney(int add)
    {
        money += add;
    }
}
