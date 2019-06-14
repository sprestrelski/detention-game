using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizingexitbutton : MonoBehaviour {

	public GameObject exitB;
	public float ds;
	// Use this for initialization
	void Start () {
		ds = .25f;	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("exit") != null) {
			exitB = GameObject.Find ("exit");
			exitB.transform.position = new Vector3(12.98f,6.79f,0);
			exitB.transform.localScale = new Vector3( ds, ds, ds );
		}
	}
}
