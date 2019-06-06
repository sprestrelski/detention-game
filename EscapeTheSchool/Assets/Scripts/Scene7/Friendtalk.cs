using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Friendtalk : MonoBehaviour {

	public Text text;
	public GameObject brokenkeyfob;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Equals ("birthdayCake")) {
			Debug.Log ("gotem");
			Destroy(GameObject.Find("birthdayCake"));
			brokenkeyfob.SetActive (true);
			text.text = "Thanks man!";
		}


	}
}
