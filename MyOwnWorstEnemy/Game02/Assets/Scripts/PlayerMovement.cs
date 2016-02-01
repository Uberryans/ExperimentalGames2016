using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public int boardPosX = 0;
	public int boardPosY = 0;
	public GameObject player;
	public GameObject anger;
	public GameObject sadness;
	public GameObject fear;
	public GameObject apathy;
	public GameObject shadow;
	// Use this for initialization
	void Start () {
		shadow = GameObject.Find("Shadow");
		player = GameObject.Find("CharacterBase");
		anger = GameObject.Find("Anger");
		sadness = GameObject.Find("Sadness");
		fear = GameObject.Find("Fear");
		apathy = GameObject.Find("Apathy");
		move();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("up")){
			if(boardPosY > 0){
				boardPosY--;
				move();
				if(shadow != null){
					shadow.GetComponent<ShadowScript>().moveShadow(1);
				}
				if(anger != null){
					anger.GetComponent<AngerScript>().moveAnger(1);
				}
				if(sadness != null){
					sadness.GetComponent<SadnessScript>().moveSadness(1);
				}
				if(fear != null){
					fear.GetComponent<FearScript>().moveFear(1);
				}
				if(apathy != null){
					apathy.GetComponent<ApathyScript>().moveApathy();
				}
			}
		}
		if(Input.GetKeyDown("down")){
			if(boardPosY < 7){
				boardPosY++;
				move();
				if(shadow != null){
					shadow.GetComponent<ShadowScript>().moveShadow(2);
				}
				if(anger != null){
					anger.GetComponent<AngerScript>().moveAnger(2);
				}
				if(sadness != null){
					sadness.GetComponent<SadnessScript>().moveSadness(2);
				}
				if(fear != null){
					fear.GetComponent<FearScript>().moveFear(2);
				}
				if(apathy != null){
					apathy.GetComponent<ApathyScript>().moveApathy();
				}
			}
		}
		if(Input.GetKeyDown("left")){
			if(boardPosX > 0){
				boardPosX--;
				move();
				if(shadow != null){
					shadow.GetComponent<ShadowScript>().moveShadow(3);
				}
				if(anger != null){
					anger.GetComponent<AngerScript>().moveAnger(3);
				}
				if(sadness != null){
					sadness.GetComponent<SadnessScript>().moveSadness(3);
				}
				if(fear != null){
					fear.GetComponent<FearScript>().moveFear(3);
				}
				if(apathy != null){
					apathy.GetComponent<ApathyScript>().moveApathy();
				}
			}
		}
		if(Input.GetKeyDown("right")){
			if(boardPosX < 7){
				boardPosX++;
				move();
				if(shadow != null){
					shadow.GetComponent<ShadowScript>().moveShadow(4);
				}
				if(anger != null){
					anger.GetComponent<AngerScript>().moveAnger(4);
				}
				if(sadness != null){
					sadness.GetComponent<SadnessScript>().moveSadness(4);
				}
				if(fear != null){
					fear.GetComponent<FearScript>().moveFear(4);
				}
				if(apathy != null){
					apathy.GetComponent<ApathyScript>().moveApathy();
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

		player.transform.position = new Vector3(xPos, yPos, -3f);
	}
}
