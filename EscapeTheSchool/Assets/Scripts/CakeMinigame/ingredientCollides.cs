using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingredientCollides : MonoBehaviour {

	public int correctIngredients;
	public bool wrong;
	public bool cakeisnotalie;
	// Use this for initialization
	void Start () {
		wrong = false;
		cakeisnotalie = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (wrong == false && correctIngredients == 5) {
			cakeisnotalie = true;
			Debug.Log("yes");
		}
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log("collided with ingredient");
		if (other.name.Contains ("butter")) {
			correctIngredients += 1;
			Destroy(other.gameObject);
		} else if (other.name.Contains ("flour")) {
			correctIngredients += 1;
			Destroy(other.gameObject);
		} else if (other.name.Contains ("sugar")) {
			correctIngredients += 1;
			Destroy(other.gameObject);
		} else if (other.name.Contains ("eggs")) {
			correctIngredients += 1;
			Destroy(other.gameObject);
		} else if (other.name.Contains ("avocado")) {
			correctIngredients += 1;
			Destroy(other.gameObject);
		} else {
			wrong = true;
			Destroy(other.gameObject);
		}

	}
}
