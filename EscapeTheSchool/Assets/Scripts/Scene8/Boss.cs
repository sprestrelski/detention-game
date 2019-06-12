using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour {


	private GameObject instantiatedObj;
	public GameObject meltPrefab;
	public float speed;
	public Transform target;
	public bool death;

	// Use this for initialization
	void Start ()
	{
		speed = 15f;
		death = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveDir = (target.position - transform.position).normalized;
		transform.position += moveDir * speed * Time.deltaTime;
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Equals ("chemicals") && death == false) {
			Destroy(GameObject.Find("chemicals"));
			Instantiate(meltPrefab, transform.position, Quaternion.identity);
			Destroy(gameObject);
			death = true;
		}
	}

}
