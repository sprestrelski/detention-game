using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class finalCarScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Equals ("brokenkeyFob") && GameObject.Find ("thebutcher") == null) {
			Debug.Log("collided");
			Destroy (GameObject.Find("brokenkeyFob"));
			SceneManager.LoadScene ("CreditsScene");
		}
	}
}
