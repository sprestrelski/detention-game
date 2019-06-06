using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class S6testPopUp : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Equals ("testSpawn") && GameObject.Find("epoxy") != null) {
			text.text = "I've already aced this test, don't need to retake it.";
			StartCoroutine (waiterCollect());
		}

	}

	public IEnumerator waiterCollect ()
	{
		yield return new WaitForSeconds(2.5f);
		text.text = "";

		//Destroy(paperclipPrefab.gameObject);
	}
}
