using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Door : MonoBehaviour {
	private GameObject instantiatedObj;
	public GameObject map;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Contains ("doorCheck") || Input.GetKeyDown ("t")) {
			if (GameObject.Find ("Map(Clone)") != null) {
				Destroy (instantiatedObj);
			} else {
				instantiatedObj = Instantiate (map, new Vector3 (170, 260, 0), Quaternion.identity);
			}


		}
			
	}
}
