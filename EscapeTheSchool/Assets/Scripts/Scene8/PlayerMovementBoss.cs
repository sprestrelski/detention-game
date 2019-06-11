using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBoss : MonoBehaviour {
	public float speed;
	public GameObject chemicals;
	public GameObject keyFob;
	// Use this for initialization
	void Start ()
	{
		speed = 12;
		if (GameObject.Find ("chemicals") != null) {
			chemicals = GameObject.Find ("chemicals");
			chemicals.transform.position = new Vector3(-33.21f,14.6f,0);
		}
		if (GameObject.Find ("brokenkeyFob") != null) {
			keyFob = GameObject.Find ("brokenkeyFob");
			keyFob.transform.position = new Vector3(-32.63f,4.36f,0);
		}
			
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxis ("Horizontal");
		transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime * speed * horizontalInput);
		float verticalInput = Input.GetAxis ("Vertical");
		transform.Translate (new Vector3 (0, 1, 0) * Time.deltaTime * speed * verticalInput);


	}


}
