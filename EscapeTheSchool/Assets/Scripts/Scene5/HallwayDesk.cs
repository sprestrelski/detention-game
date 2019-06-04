using UnityEngine;
using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class HallwayDesk : MonoBehaviour {
	public GameObject desk;
    public GameObject note;

	public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") && desk.activeSelf) {

			desk.SetActive (false);
			text.text = "Hmm... this hallway is a little sketchy.";
		}

        else if (Input.GetKeyDown("space") && note.activeSelf)
        {
            note.SetActive(false);
            text.text = "Jeez. This place is weird.";
        }
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Equals ("DeskCollider")) {
			

			desk.SetActive(true);
			text.text = "What is this engraving? It looks like a riddle of some sort. [Space to close]";

			//desk.GetComponent.<Text>().enabled = true;
		}

        else if (other.name.Contains("note")) {
            note.SetActive(true);
            text.text = "I guess this was from the Chemistry teacher... [Space to close]";
        }

	}
}
