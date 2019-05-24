using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2FootballAnimation : MonoBehaviour {

	public float movementSpeed = 17;
	// Use this for initialization
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

	void Update () {

		if (startAnim == true ){
			transform.Translate(new Vector3 (0.65f, -1, 0) * movementSpeed * Time.deltaTime);
		}
	}
}
