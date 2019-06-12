using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXITGAME : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnMouseDown()
	{
		Debug.Log("application quit");
		Application.Quit();
	}

}
