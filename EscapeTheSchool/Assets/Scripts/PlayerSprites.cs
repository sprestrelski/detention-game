using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprites : MonoBehaviour {

	public Sprite[] playerSprites;
	public GameObject player;
	// Use this for initialization
	void Awake () {
		playerSprites = Resources.LoadAll<Sprite>("player");
	}
	void Start(){
		if (GameObject.Find ("Player") != null) {
			player = GameObject.Find ("Player");
			player.AddComponent<SpriteRenderer>();
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameObject.Find ("Player") != null) {
			if (Input.GetAxis ("Vertical") > 0) {
				player.GetComponent<SpriteRenderer>().sprite = playerSprites[4];
			}
			else if (Input.GetAxis ("Vertical") < 0) {
				player.GetComponent<SpriteRenderer>().sprite = playerSprites[0];
			}
			else if (Input.GetAxis ("Horizontal") > 0) {
				player.GetComponent<SpriteRenderer>().sprite = playerSprites[2];
			}
			else if (Input.GetAxis ("Horizontal") < 0) {
				player.GetComponent<SpriteRenderer>().sprite = playerSprites[7];
			}
		}
	}
}
