using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class checkForObjects : MonoBehaviour {

	public bool instakill;
	public Image flash;
	public Text text;
	private GameObject instantiatedObj;
	public string[] collectibles;


	// Use this for initialization
	void Start ()
	{
		collectibles = new string[]{"epoxy", "chemicals", "brokenkeyFob", "birthdayCake", "carrotCake", "chocolateCake", "lemonCake", "redvelvetCake", "spongeCake", "strawberryCake", "tiramisuCake", "vanillaCake", "burnt1", "burnt2", "burnt3"};
		if (GameObject.Find ("epoxy") == null && GameObject.Find ("chemicals") != null && GameObject.Find ("brokenkeyFob") != null) {
			Debug.Log ("u won lel");
		} else {
			instakill = true;
			GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
			StartCoroutine(pauseBlack());
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if(other.name.Equals("BlobEnemy")){
			StartCoroutine(pauseBlack());
		}
	}

	public IEnumerator pauseBlack()
	{
		flash.enabled = true;
		yield return new WaitForSeconds(2f);
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
