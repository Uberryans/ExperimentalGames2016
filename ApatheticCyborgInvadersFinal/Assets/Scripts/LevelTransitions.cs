using UnityEngine;
using System.Collections;

public class LevelTransitions : MonoBehaviour {
	//For this, you need to do two things: First, in our main scene, make an empty game object
	//and attach this script to it. Name it LevelTransitioner.
	//Second, you need to make three levels, named LevelOne,
	//LevelTwo, and LevelThree exactly. Just feel free to copy and paste; 
	//make sure to change the spawners for each.
	//Then go to File > Build Settings and in the window there
	//will be an option to add the current level to build path; 
	//do this for each of them, starting with level one.
	//Make sure our three levels are all that's in the build path.
	int curLevel = 1;

	void Start(){
		DontDestoryOnLoad(this.gameObject);
	}

	public void changeLevel(){
		curLevel++;
		if(curLevel == 1){
			Application.LoadLevel("LevelOne");
		}
		if(curLevel == 2){
			Application.LoadLevel("LevelTwo");
		}
		if(curLevel == 3){
			Application.LoadLevel("LevelThree");
		}
	}
}