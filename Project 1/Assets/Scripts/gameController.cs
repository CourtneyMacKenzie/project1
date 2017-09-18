using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

	float time; 
	int myScore;
	bool printedMessage;

	// Use this for initialization
	void Start () {
		print ("The game has begun!");

		printedMessage = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.time > 3 && printedMessage == false) {
			// stuff that happens if true
			print ("It's been three seconds!");
			printedMessage = true;
		}
	}
}
