using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class keyFob : MonoBehaviour {

	public Sprite rebuilt;
	SpriteRenderer currentKey;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}

	// Update is called once per frame
	void Update () {
		currentKey = this.GetComponent<SpriteRenderer> ();


	}
	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Equals ("epoxy")) {
			Debug.Log ("gotem");
			Destroy(GameObject.Find("epoxy"));
			//brokenkeyfob.SetActive (true);
			currentKey.sprite = rebuilt;

		}


	}

}
