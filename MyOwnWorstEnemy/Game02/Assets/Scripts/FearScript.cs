using UnityEngine;
using System.Collections;

public class FearScript : MonoBehaviour {

	public int boardPosX, boardPosY;
	private GameObject fearSwitch;
	public int facing = 1;
	private GameObject player, anger, sadness, shadow, apathy;
	private int angX, angY;
	private int sadX, sadY;
	private int shaX, shaY;
	private int apaX, apaY;
	public int apathyStore;

	// Use this for initialization
	void Start () {
		fearSwitch = GameObject.Find("SwitchFear");
		player = GameObject.Find("CharacterBase");
		anger = GameObject.Find("Anger");
		sadness = GameObject.Find("Sadness");
		shadow = GameObject.Find("Shadow");
		move();
	}

	void updatePos(){
		angX = anger.GetComponent<AngerScript>().boardPosX;
		angY = anger.GetComponent<AngerScript>().boardPosY;
		sadX = sadness.GetComponent<SadnessScript>().boardPosX;
		sadY = sadness.GetComponent<SadnessScript>().boardPosY;
		shaX = shadow.GetComponent<ShadowScript>().boardPosX;
		shaY = shadow.GetComponent<ShadowScript>().boardPosY;
		
	}

	public void moveFear(int dir){
		if(dir == 1){
			if(facing == 1){
				if(boardPosY > 0){
					boardPosY--;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 1;
				}	
			}
			if(facing == 2){
				if(boardPosX < 7){
					boardPosX++;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 2;
				}
			}
			if(facing == 3){
				if(boardPosY < 7){
					boardPosY++;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 3;
				}
			}
			if(facing == 4){
				if(boardPosX > 0){
					boardPosX--;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 4;
				}
			}
		}
		if(dir == 2){
			if(facing == 1){
				if(boardPosY < 7){
					boardPosY++;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 5;
				}
			}
			if(facing == 2){
				if(boardPosX > 0){
					boardPosX--;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 6;
				}
			}
			if(facing == 3){
				if(boardPosY > 0){
					boardPosY--;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 7;
				}
			}
			if(facing == 4){
				if(boardPosX < 7){
					boardPosX++;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 8;
				}
			}
		}
		if(dir == 3){
			if(facing == 1){
				if(boardPosX > 0){
					boardPosX--;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 9;
				}
			}
			if(facing == 2){
				if(boardPosY > 0){
					boardPosY--;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 10;
				}
			}
			if(facing == 3){
				if(boardPosX < 7){
					boardPosX++;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 11;
				}
			}
			if(facing == 4){
				if(boardPosY < 7){
					boardPosY++;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 12;
				}
			}
		}
		if(dir == 4){
			if(facing == 1){
				if(boardPosX < 7){
					boardPosX++;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 13;
				}
			}
			if(facing == 2){
				if(boardPosY < 7){
					boardPosY++;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 14;
				}
			}
			if(facing == 3){
				if(boardPosX > 0){
					boardPosX--;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 15;
				}
			}
			if(facing == 4){
				if(boardPosY > 0){
					boardPosY--;
					updatePos();
					fearAdjust();
					move();
					switchCheck();
					apathyStore = 16;
				}
			}
		}
	}


	void fearAdjust(){
		if(	(boardPosX == angX && boardPosY == angY - 1) ||
			(boardPosX == sadX && boardPosY == sadY - 1) ||
			(boardPosX == shaX && boardPosY == shaY - 1)){
			if(boardPosY > 0)
				boardPosY--;
		}
		if(	(boardPosX == angX && boardPosY == angY + 1) ||
			(boardPosX == sadX && boardPosY == sadY + 1) ||
			(boardPosX == shaX && boardPosY == shaY + 1) ){
			if(boardPosY < 7)	
				boardPosY++;
		}
		if(	(boardPosX == angX - 1 && boardPosY == angY) ||
			(boardPosX == sadX - 1 && boardPosY == sadY) ||
			(boardPosX == shaX - 1 && boardPosY == shaY) ){
			if(boardPosX > 0)	
				boardPosX--;
		}
		if(	(boardPosX == angX + 1 && boardPosY == angY) ||
			(boardPosX == sadX + 1 && boardPosY == sadY) ||
			(boardPosX == shaX + 1 && boardPosY == shaY) ){
			if(boardPosX < 7)	
				boardPosX++;
		}

	}

	void move(){

		float xPos = 0;
		float yPos = 0;

		if(boardPosX == 0){
			xPos = -5.11f;
		}
		if(boardPosX == 1){
			xPos = -3.74f;
		}
		if(boardPosX == 2){
			xPos = -2.34f;
		}
		if(boardPosX == 3){
			xPos = -0.94f;
		}
		if(boardPosX == 4){
			xPos = 0.43f;
		}
		if(boardPosX == 5){
			xPos = 1.89f;
		}
		if(boardPosX == 6){
			xPos = 3.26f;
		}
		if(boardPosX == 7){
			xPos = 4.75f;
		}

		if(boardPosY == 0){
			yPos = 4.33f;
		}
		if(boardPosY == 1){
			yPos = 3.02f;
		}
		if(boardPosY == 2){
			yPos = 1.71f;
		}
		if(boardPosY == 3){
			yPos = 0.38f;
		}
		if(boardPosY == 4){
			yPos = -0.95f;
		}
		if(boardPosY == 5){
			yPos = -2.28f;
		}
		if(boardPosY == 6){
			yPos = -3.63f;
		}
		if(boardPosY == 7){
			yPos = -4.96f;
		}

		this.gameObject.transform.position = new Vector3(xPos, yPos, -3f);
	}

	void switchCheck(){
		int switchPosX = fearSwitch.GetComponent<Switch>().boardPosX;
		int switchPosY = fearSwitch.GetComponent<Switch>().boardPosY;

		if(switchPosX == boardPosX && switchPosY == boardPosY){
			fearSwitch.GetComponent<Switch>().setSwitch(true);
		}
	}
}
