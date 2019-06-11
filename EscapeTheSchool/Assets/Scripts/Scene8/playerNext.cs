using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerNext : MonoBehaviour {
	public Image flash;
	public Text text;
	public Text speech;
	public Button continueGame;
	public Button wait;
	public bool ready; 

	// Use this for initialization
	void Start ()
	{
		// button.GetComponent<Image>().sprite = Image1;
		continueGame.GetComponent<Image>().enabled = false;
		wait.GetComponent<Image>().enabled = false;
		continueGame.interactable = false;
		wait.interactable = false;
		if (GameObject.Find ("epoxy") == null && GameObject.Find ("chemicals") != null && GameObject.Find ("brokenkeyFob") != null) {
			ready = true;
		} else {
			ready = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if(other.name.Equals("parkingLot") && ready == false){
			speech.enabled = false;
			flash.enabled = true;
			StartCoroutine(choices());
		}
		if(other.name.Equals("parkingLot") && ready == true){
			SceneManager.LoadScene("FinalBossScene");
		}
	}

	public IEnumerator choices ()
	{
		yield return new WaitForSeconds (2f);
		text.text = "I'm not sure I'm ready to escape yet.";
		yield return new WaitForSeconds(2.5f);
		text.text = "I'm not sure I'm ready to escape yet.\nIs there something else I need to find...?";
		yield return new WaitForSeconds(2.5f);
		text.text = "I'm not sure I'm ready to escape yet.\nIs there something else I need to find...?\nI can still try...";
		yield return new WaitForSeconds(2.5f);
		continueGame.GetComponent<Image>().enabled = true;
		wait.GetComponent<Image>().enabled = true;
		continueGame.interactable = true;
		wait.interactable = true;
	}
}
