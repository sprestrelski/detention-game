using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class S2S3 : MonoBehaviour {
	float timeLeft;
	public Text dialogue;
	/*
		The Butcher dialogue: Hey you!
		What do you think you're doing?
		Do you have a permit???
	*/
	// Use this for initialization
	void Start () {
		timeLeft = 30;
		dialogue.text = "The Butcher: HEY YOU!";
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		Debug.Log(timeLeft);
		if ( timeLeft < 27 && timeLeft > 25) dialogue.text = "What do you think you're doing?";
		if ( timeLeft < 25 && timeLeft > 0) dialogue.text = "Do you have a permit???"; 
		if ( timeLeft < 0) {
			sceneOver ();
		}
	}

	public void sceneOver(){

		SceneManager.LoadScene("Scene3Game1");

	}
}
