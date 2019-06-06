using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkScript : MonoBehaviour {

	GameObject player;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		player.GetComponent<PlayerTalk>().doneTalking = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
