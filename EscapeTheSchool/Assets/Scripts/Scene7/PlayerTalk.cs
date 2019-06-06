using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTalk : MonoBehaviour {
	public Text dialogue;
	public RawImage textBox;
	public Text speech;
	bool triggered;
	public bool doneTalking;

	public GameObject talkedAlready;

	// Use this for initialization
	void Start () {
		dialogue.text = "";
		speech.text = "Who...?";
		triggered = false;
		doneTalking = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (triggered == false) {
			if (other.name.Contains ("football")) {
				Debug.Log("triggered");
				triggered = true;
				speech.text = "Hey man, how's it going...?";
				StartCoroutine (dialogueWait ());


			}
		} else if (doneTalking == true){
			speech.text = "I don't have the cake yet, he won't talk to me.";
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
		doneTalking = true;
		talkedAlready.SetActive(true);


	}
}
