using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class keyFob : MonoBehaviour {
	public BoxCollider2D check;
	public Sprite rebuilt;
	SpriteRenderer currentKey;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		check = this.GetComponent<BoxCollider2D> ();
	}

	// Update is called once per frame
	void Update () {
		currentKey = this.GetComponent<SpriteRenderer> ();
		var currentScene = SceneManager.GetActiveScene ();
		if (currentScene.name == "FinalBossScene") {
			check.isTrigger = true;
			Destroy (this.gameObject.GetComponent<Rigidbody2D>());
		}

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
