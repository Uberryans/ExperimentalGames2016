using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public int money;
	// Use this for initialization
	void Start () {
        money = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void addMoney(int add)
    {
        money += add;
    }
}
