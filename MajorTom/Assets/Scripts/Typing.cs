using UnityEngine;
using System.Collections;

public class Typing : MonoBehaviour {

	public string userText;
	GameObject manager;
	// Use this for initialization
	void Start () {
		userText = "> ";
		manager = GameObject.Find("ConsoleManager");
		print(userText.Length);
	}
	
	// Update is called once per frame
	void Update () {
		foreach(char c in Input.inputString){
			if(c == "\b"[0]){
				if(userText.Length != 2){
					userText = userText.Substring(0, userText.Length - 1);
				}
			}
			else{
				if(c == "\n"[0] || c == "\r"[0]){
					manager.GetComponent<TerminalManager>().fireCommand(userText);
				}
				else{
					if(userText.Length <= 45){
						userText += c;
					}
				}
			}
		}
	}

	public void resetText(){
		userText = "> ";
	}
}
