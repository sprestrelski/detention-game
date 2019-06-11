using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class checkForObjects : MonoBehaviour {

	public bool instakill;
	public Image flash;
	public Image theButcher;
	public Image whiteFlash;
	public Text text;
	private GameObject instantiatedObj;
	public string[] collectibles;
	public RectTransform r_Butcher;
	public AudioSource jumpscare;

	public bool collided;


	// Use this for initialization
	void Start ()
	{
		collided = false;
		collectibles = new string[] {
			"epoxy",
			"chemicals",
			"brokenkeyFob",
			"birthdayCake",
			"carrotCake",
			"chocolateCake",
			"lemonCake",
			"redvelvetCake",
			"spongeCake",
			"strawberryCake",
			"tiramisuCake",
			"vanillaCake",
			"burnt1",
			"burnt2",
			"burnt3"
		};
		if (GameObject.Find ("epoxy") == null && GameObject.Find ("chemicals") != null && GameObject.Find ("brokenkeyFob") != null) {
			Debug.Log ("u won lel");
		} else {
			instakill = true;
			//GameObject.Find("Player").GetComponent<PlayerMovementBoss>().enabled = false;
		}

		for (int i = 0; i < collectibles.Length; i++) {
			if (GameObject.Find (collectibles [i]) != null) {
				if (collectibles [i] != "chemicals" && collectibles [i] != "brokenkeyFob") {
					instantiatedObj = GameObject.Find (collectibles [i]);
					Destroy (instantiatedObj);
				}
			}
		}

		AudioSource[]audios = GetComponents<AudioSource>();
		jumpscare = audios[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if(other.name.Contains("butcher") && collided == false){
			collided = true;
			StartCoroutine(pauseBlack());
		}
	}

	public IEnumerator pauseBlack ()
	{
		//"jumpscare""
		jumpscare.Play();
		flash.enabled = true;
		yield return new WaitForSeconds (3f);
		theButcher.enabled = true;
		for (int i = 10; i < 20; i++) {
			theButcher.rectTransform.sizeDelta = new Vector2 (i * 50, i * 50);
			if (i % 2 == 0) {
				r_Butcher.transform.rotation = Quaternion.Euler (0, 0, 5	);
			} else {
				r_Butcher.transform.rotation = Quaternion.Euler (0, 0, 355);
			}
			yield return new WaitForSeconds (.02f);
		}
		theButcher.enabled = false;

		//flashbang effect
		whiteFlash.enabled = true;
		yield return new WaitForSeconds(.3f);
		whiteFlash.CrossFadeAlpha(0, 1f, false);
		yield return new WaitForSeconds(2f);

		//story text
		text.text = "You failed to escape.";
		yield return new WaitForSeconds(2f);
		text.text = "You failed to escape.\nYou are sent back to detention.";
		yield return new WaitForSeconds(2.5f);
		text.text = "You failed to escape.\nYou are sent back to detention.\nThe Butcher confisticates your contraband.";
		yield return new WaitForSeconds(2.5f);
		text.text = "";
		yield return new WaitForSeconds(2.5f);
		for (int i = 0; i < collectibles.Length; i++) {
			if (GameObject.Find (collectibles [i]) != null) {
				instantiatedObj = GameObject.Find (collectibles [i]);
				Destroy (instantiatedObj);
			}
		}

		SceneManager.LoadScene("Scene3Game1");
	}
}
