using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TerminalManager : MonoBehaviour {

	public Text console, info;
	Text currentLine;
	GameObject typingManager;
	// Use this for initialization
	void Start () {
		typingManager = GameObject.Find("ConsoleManager");
	}
	
	// Update is called once per frame
	void Update () {
		console.text = typingManager.GetComponent<Typing>().userText;
	}

	public void fireCommand(string userText){
		typingManager.GetComponent<Typing>().resetText();
		char[] delims = {'>', ' '};
		string[] command = userText.Split(delims);
		if(command[2] == "test"){
			info.text = "Test has been successsful";
		}
	}
}
