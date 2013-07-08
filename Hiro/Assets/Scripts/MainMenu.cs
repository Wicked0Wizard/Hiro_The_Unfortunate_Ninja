using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//handle graphic out put.
	void OnGUI () {
		GUI.Label(new Rect(0.0f,0.0f,200.0f, 200.0f), "Welcome to Hiro!");
	}
}
