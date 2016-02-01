using UnityEngine;
using System.Collections;

public class ApathyScript : MonoBehaviour {

	public int boardPosX, boardPosY;
	private GameObject player, anger, sadness, shadow, fear;
	private GameObject apathySwitch;
	private int angX, angY;
	private int sadX, sadY;
	private int shaX, shaY;
	private int feaX, feaY;
	// Use this for initialization
	void Start () {
		apathySwitch = GameObject.Find("SwitchApathy");
		player = GameObject.Find("CharacterBase");
		anger = GameObject.Find("Anger");
		sadness = GameObject.Find("Sadness");
		shadow = GameObject.Find("Shadow");
		fear = GameObject.Find("Fear");
		move();
	}
	
	public void moveApathy(){
		updatePos();
		if(boardPosX == angX && boardPosY == angY){
			int dir = anger.GetComponent<AngerScript>().apathyStore;
			if(dir == 1){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 2){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 3){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 4){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 5){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 6){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 7){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 8){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 9){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 10){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 11){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 12){
				if (boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 13){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 14){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 15){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 16){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
		}

		if(boardPosX == sadX && boardPosY == sadY){
			int dir = sadness.GetComponent<SadnessScript>().apathyStore;
			if(dir == 1){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 2){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 3){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 4){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 5){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 6){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 7){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 8){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 9){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 10){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 11){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 12){
				if (boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 13){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 14){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 15){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 16){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
		}

		if(boardPosX == feaX && boardPosY == feaY){
			int dir = fear.GetComponent<FearScript>().apathyStore;
			if(dir == 1){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 2){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 3){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 4){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 5){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 6){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 7){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 8){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 9){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 10){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 11){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 12){
				if (boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 13){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 14){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 15){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 16){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
		}

		if(boardPosX == shaX && boardPosY == shaY){
			int dir = fear.GetComponent<FearScript>().apathyStore;
			if(dir == 1){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 2){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 3){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 4){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 5){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 6){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 7){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 8){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 9){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 10){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
			if(dir == 11){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 12){
				if (boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 13){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
				}
			}
			if(dir == 14){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
				}
			}
			if(dir == 15){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
				}
			}
			if(dir == 16){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
				}
			}
		}
	}

	void updatePos(){
		angX = anger.GetComponent<AngerScript>().boardPosX;
		angY = anger.GetComponent<AngerScript>().boardPosY;
		sadX = sadness.GetComponent<SadnessScript>().boardPosX;
		sadY = sadness.GetComponent<SadnessScript>().boardPosY;
		feaX = fear.GetComponent<FearScript>().boardPosX;
		feaY = fear.GetComponent<FearScript>().boardPosY;
		shaX = shadow.GetComponent<ShadowScript>().boardPosX;
		shaY = shadow.GetComponent<ShadowScript>().boardPosY;
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
		int switchPosX = apathySwitch.GetComponent<Switch>().boardPosX;
		int switchPosY = apathySwitch.GetComponent<Switch>().boardPosY;

		if(switchPosX == boardPosX && switchPosY == boardPosY){
			apathySwitch.GetComponent<Switch>().setSwitch(true);
		}
	}
}
