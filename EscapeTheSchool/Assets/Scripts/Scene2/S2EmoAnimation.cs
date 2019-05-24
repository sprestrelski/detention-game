using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2EmoAnimation : MonoBehaviour {

	public float movementSpeed = 13;
	public bool startAnim = false;
	// Use this for initialization
	void Start () {
		StartCoroutine(waiter());
	}

	IEnumerator waiter ()
	{
		yield return new WaitForSeconds(5);
		startAnim = true;

	}

	// Update is called once per frame
	void Update () {
		if (startAnim == true ){
			transform.Translate(new Vector3 (0.35f, -1, 0) * movementSpeed * Time.deltaTime);
		}
	}
}
