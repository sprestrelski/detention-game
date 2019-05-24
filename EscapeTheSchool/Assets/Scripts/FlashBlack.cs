using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashBlack : MonoBehaviour {
	public Image flash;
	bool flashed;
	// Use this for initialization
	void Start () {
		flash.enabled = false;
		flashed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if ( flashed == false )
			StartCoroutine( timeBetweenFlashes() );
	}

	public IEnumerator timeBetweenFlashes ()
	{
		flashed = true;
		float timeToWait = Random.Range(0, 3f);
		yield return new WaitForSeconds(timeToWait);
		flash.enabled = true;
		yield return new WaitForSeconds(0.1f);
		flash.enabled = false;
		flashed = false;
	}
}
