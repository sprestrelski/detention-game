using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class S1S2 : MonoBehaviour {
	float timeLeft;
	// Use this for initialization
	void Start () {
		timeLeft = 10;
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			sceneOver ();
		}
	}

	public void sceneOver(){
		
		SceneManager.LoadScene("Scene2Cut2");

	}
}



