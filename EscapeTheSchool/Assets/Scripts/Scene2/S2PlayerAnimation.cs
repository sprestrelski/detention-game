using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S2PlayerAnimation : MonoBehaviour {
	public float movementSpeed = 8;
	// Use this for initialization
	public bool startAnim = false;
	public Image flash;


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
		if (startAnim){
		transform.Translate(new Vector3 (.85f, -1, 0) * movementSpeed * Time.deltaTime);

		}
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if(other.name.Equals("BlobEnemy")){
			StartCoroutine(trigger());
		}
	}

	public IEnumerator trigger ()
	{
		flash.enabled = true;
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene("Scene3Game1");
	}
}
