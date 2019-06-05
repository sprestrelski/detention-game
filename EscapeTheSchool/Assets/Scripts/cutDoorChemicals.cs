using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cutDoorChemicals : MonoBehaviour {
	public Text text;
	public GameObject chemicals;
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
			chemicals.SetActive (true);
			text.text = "Whoa, there are vials outside the door!";
		}


	}
}
