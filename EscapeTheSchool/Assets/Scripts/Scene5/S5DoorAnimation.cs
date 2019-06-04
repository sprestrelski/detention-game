using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5DoorAnimation : MonoBehaviour {
	//public GameObject chemDoor;
	Animator mAnimator;
	// Use this for initialization
	void Start () {
		mAnimator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			mAnimator.SetTrigger ("activate");
		}
	}
}
