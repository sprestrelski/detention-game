using UnityEngine;
using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class HallwayDesk : MonoBehaviour {
	public GameObject desk;
    public GameObject note;
	public bool movement;
	public Text text;
	// Use this for initialization
	void Start () {
		movement = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (movement == false) {
			GameObject.Find ("Player").GetComponent<PlayerMovementHallway> ().enabled = false;
		} else {
			GameObject.Find("Player").GetComponent<PlayerMovementHallway>().enabled = true;
		}
		if (Input.GetKeyDown ("space") && desk.activeSelf) {
			movement = true;
			desk.SetActive (false);
			text.text = "Hmm... this hallway is a little sketchy.";
		}

        else if (Input.GetKeyDown("space") && note.activeSelf)
		{
			movement = true;
            note.SetActive(false);
            text.text = "Jeez. This place is weird.";
        }
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Equals ("DeskCollider")) {
			movement = false;
			desk.SetActive(true);
			text.text = "What is this engraving? It looks like a riddle of some sort. \n[Space to close]";

			//desk.GetComponent.<Text>().enabled = true;
		}

        else if (other.name.Contains("note")) {
			movement = false;
			note.SetActive(true);
            text.text = "I guess this was from the Chemistry teacher... \n[Space to close]";
        }

	}
}
