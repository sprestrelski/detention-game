using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForObjects : MonoBehaviour {

	public bool instakill;
	// Use this for initialization
	void Start ()
	{
		if (GameObject.Find ("epoxy") == null && GameObject.Find ("chemicals") != null && GameObject.Find ("brokenkeyFob") != null) {
			Debug.Log ("u won lel");
		} else {
			instakill = true;
			GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
