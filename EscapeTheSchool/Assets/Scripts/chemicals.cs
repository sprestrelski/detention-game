using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class chemicals : MonoBehaviour {
	public BoxCollider2D check;
	public bool setPosition;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		check = this.GetComponent<BoxCollider2D> ();
		setPosition = false;
	}

	// Update is called once per frame
	void Update () {
		var currentScene = SceneManager.GetActiveScene ();
		if (currentScene.name == "FinalBossScene") {
			check.isTrigger = true;
			Destroy (this.gameObject.GetComponent<Rigidbody2D>());


		}


	}


}
