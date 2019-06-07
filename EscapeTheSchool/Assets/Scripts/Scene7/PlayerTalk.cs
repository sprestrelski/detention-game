using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTalk : MonoBehaviour {
	public Text dialogue;

	public Text speech;



	public GameObject talkedAlready;

	// Use this for initialization
	void Start () {
		dialogue.text = "";
		speech.text = "";


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (GameObject.Find ("talkedAlready") == null && GameObject.Find("birthdayCake") == null) {
			if (other.name.Contains ("football")) {
				Debug.Log ("triggered");

				speech.text = "Hey man, how's it going...?";
				StartCoroutine (dialogueWait ());


			}
		} else if (GameObject.Find ("talkedAlready") != null && GameObject.Find ("birthdayCake") == null) {
			speech.text = "I don't have the cake yet, he won't talk to me.";
			StartCoroutine (waiterCollect ());
		} else if (GameObject.Find ("talkedAlready") == null && GameObject.Find ("birthdayCake") != null) {
			speech.text = "Hey man! Happy birthday! You didn't think I would forget, did ya?";
			StartCoroutine (waiterCollect ());
		} else if (GameObject.Find ("talkedAlready") != null && GameObject.Find ("birthdayCake") != null) {
			speech.text = "Here man. Here's your cake.";
			StartCoroutine (waiterCollect ());
		}
	}


	public IEnumerator dialogueWait ()
	{
		yield return new WaitForSeconds(3);
		speech.text = "Why won't you talk to me???";
		yield return new WaitForSeconds(2);
		speech.text = "I guess I forgot it was your birthday today...";
		yield return new WaitForSeconds(2.5f);
		speech.text = "I'll try to bring you a cake.";

		talkedAlready.SetActive(true);

		StartCoroutine (waiterCollect ());
	}

	public IEnumerator waiterCollect ()
	{
		yield return new WaitForSeconds(2.5f);
		speech.text = "";
	
	
	}
}
