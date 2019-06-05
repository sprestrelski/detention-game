using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HelperText : MonoBehaviour {
	public Text helperText;
	// Use this for initialization
	void Start () {
		if (GameObject.Find ("birthdayCake") != null) {
			helperText.text = "Maybe I should place the cake at the door. I wonder who Sista is.";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
