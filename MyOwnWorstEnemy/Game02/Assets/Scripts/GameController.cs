using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private GameObject switchAnger;
	private GameObject portal;
	private int switchCount = 0;
	// Use this for initialization
	void Start () {
		switchAnger = GameObject.Find("SwitchAnger");
		if(switchAnger != null){
			switchCount++;
		}

		portal = GameObject.Find("Portal");
	}
	
	// Update is called once per frame
	void Update () {
		int count = 0;
		if(switchAnger.GetComponent<Switch>().getSwitch()){
			count++;
		}
		if(count == switchCount){
			portal.SetActive(true);
		}
		else{
			portal.SetActive(false);
		}
	}
}
