using UnityEngine;
using System.Collections;

public class AngerScript : MonoBehaviour {

	public int boardPosX, boardPosY;
	private GameObject anger;
	private GameObject angerSwitch;
	public int facing = 1;
	public int apathyStore;
	// Use this for initialization
	void Start () {
		anger = GameObject.Find("Anger");
		angerSwitch = GameObject.Find("SwitchAnger");
		move();
	}
	
	// Update is called once per frame
	public void moveAnger(int dir){
		apathyStore = dir;
		if(dir == 1){
			if(facing == 1){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
					apathyStore = 1;
				}	
			}
			if(facing == 2){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
					apathyStore = 2;
				}
			}
			if(facing == 3){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
					apathyStore = 3;
				}
			}
			if(facing == 4){
				if(boardPosX > 0){
					boardPosX--;
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
					move();
					switchCheck();
					apathyStore = 5;
				}
			}
			if(facing == 2){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
					apathyStore = 6;
				}
			}
			if(facing == 3){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
					apathyStore = 7;
				}
			}
			if(facing == 4){
				if(boardPosX < 7){
					boardPosX++;
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
					move();
					switchCheck();
					apathyStore = 9;
				}
			}
			if(facing == 2){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
					apathyStore = 10;
				}
			}
			if(facing == 3){
				if(boardPosX < 7){
					boardPosX++;
					move();
					switchCheck();
					apathyStore = 11;
				}
			}
			if(facing == 4){
				if(boardPosY < 7){
					boardPosY++;
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
					move();
					switchCheck();
					apathyStore = 13;
				}
			}
			if(facing == 2){
				if(boardPosY < 7){
					boardPosY++;
					move();
					switchCheck();
					apathyStore = 14;
				}
			}
			if(facing == 3){
				if(boardPosX > 0){
					boardPosX--;
					move();
					switchCheck();
					apathyStore = 15;
				}
			}
			if(facing == 4){
				if(boardPosY > 0){
					boardPosY--;
					move();
					switchCheck();
					apathyStore = 16;
				}
			}
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

		anger.transform.position = new Vector3(xPos, yPos, -3f);
	}

	void switchCheck(){
		int switchPosX = angerSwitch.GetComponent<Switch>().boardPosX;
		int switchPosY = angerSwitch.GetComponent<Switch>().boardPosY;

		if(switchPosX == boardPosX && switchPosY == boardPosY){
			angerSwitch.GetComponent<Switch>().setSwitch(true);
		}
	}
}
