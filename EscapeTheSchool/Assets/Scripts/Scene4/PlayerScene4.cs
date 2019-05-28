using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScene4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Contains ("hotplates")){
			Debug.Log("hot plate collided");
		}
	}
}
