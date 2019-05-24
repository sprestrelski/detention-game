using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScene3 : MonoBehaviour {
	//public GameObject paperclipPrefab;
	public GameObject smallmap;
	bool paperClipCollected = false;
	bool mapCollected = false;
	public Text dialogue;
	public RawImage textBox;
	private GameObject instantiatedObj;
	public GameObject map;
	public Text speech;
	public RawImage paperClip;
	public RawImage mapSprite;

	// Use this for initialization
	void Start () {
		dialogue.text = "";
		paperClip.enabled = false;
		mapSprite.enabled = false;
		textBox.enabled = false;
		speech.text = "Huh?!? Where am I? Crap, I need to find a way out of here.";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("t") && paperClipCollected && mapCollected) {

			if (GameObject.Find ("Map(Clone)") != null) {
				Destroy (instantiatedObj);
			} else {
				instantiatedObj = Instantiate (map, new Vector3 (170, 260, 0), Quaternion.identity);
			}

		}else if (Input.GetKeyDown ("t") && !mapCollected) {
			speech.text = "I don't even know where I am. I wish there was a map of this place.";
		} 


		else if (Input.GetKeyDown ("t") && !paperClipCollected) {
			speech.text = "I need a way to open this door. Maybe I can find something in the desks...";
		} 
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Contains ("paperclip") && !paperClipCollected) {
			Debug.Log ("paper clip received (Player)");
			//Instantiate(paperclipPrefab);
			dialogue.text = "You have acquired a paper clip!";
			speech.text = "Hm... this could come in handy.";
			paperClip.enabled = true;
			textBox.enabled = true;
			paperClipCollected = true;
			StartCoroutine (waiterCollect ());
			StartCoroutine (clipWaiter ());

		} else if (other.name.Contains ("smallmap") && !mapCollected) {
			Debug.Log ("map received (Player)");
			dialogue.text = "You have acquired the campus map! Press T to open and close the map, and click on any of the circled locations to proceed!";
			speech.text = "Seems to be a map. How can I escape this place?";
			mapCollected = true;
			mapSprite.enabled = true;
			textBox.enabled = true;
			Destroy (smallmap);
			StartCoroutine (waiterMapCollect ());

		} else if (other.name.Contains ("doorCheck") && mapCollected && paperClipCollected) {
			createMap ();
			speech.text = "The door is open now!";
			StartCoroutine (waiterCollect ());
		}
	}
	public void createMap(){
		if (GameObject.Find ("Map(Clone)") != null) {
			Destroy (instantiatedObj);
		} else {
			instantiatedObj = Instantiate (map, new Vector3 (170, 260, 0), Quaternion.identity);
		}
	}
	public IEnumerator waiterCollect ()
	{
		yield return new WaitForSeconds(2.5f);
		dialogue.text = "";
		paperClip.enabled = false;
		textBox.enabled = false;
		//Destroy(paperclipPrefab.gameObject);
	}

	public IEnumerator waiterMapCollect ()
	{
		yield return new WaitForSeconds(2.5f);
		dialogue.text = "";
		mapSprite.enabled = false;
		textBox.enabled = false;
		//Destroy(paperclipPrefab.gameObject);
	}

	public IEnumerator clipWaiter ()
	{
		yield return new WaitForSeconds(10);
		speech.text = "Can I open the map...?";
		yield return new WaitForSeconds (10);
		speech.text = "Maybe I can try clicking a circled location on the map.";
	}
}
