using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingredientCollides : MonoBehaviour {

	//cake checking
	public int correctIngredients;
	public int ingredientsAdded;
	public bool wrong;
	public bool cakeisnotalie;
	public bool cakemade;
	public bool secretIngredient;
	public bool birthdayCake;
    public Text speech;

    //cake decision
    public GameObject[] cakes = new GameObject[7];
    public GameObject[] burntCakes = new GameObject[3];
    public GameObject redvelvet;
    public GameObject birthday;

	// Use this for initialization
	void Start () {
		wrong = false;
        cakeisnotalie = false;
        cakemade = false;
        secretIngredient = false;
        ingredientsAdded = 0;
        speech.color = Color.white;
        speech.text = "I guess I have to make a cake...";
        StartCoroutine(dialogue());


	}
	
	// Update is called once per frame
	void Update ()
	{
		//checking that the right ingredients were added
		if (ingredientsAdded > 4) {
			if (wrong == false && correctIngredients == 4 && secretIngredient == true && birthdayCake != true) {
				cakemade = true;
				cakeisnotalie = true;
				redvelvet.SetActive (true);
				Debug.Log ("yes");
			} else if (birthdayCake == true && correctIngredients == 4 && wrong == false && cakeisnotalie == false ){
				cakemade = true;
				birthday.SetActive(true);
			} else if (wrong == true && correctIngredients == 4 && cakemade == false && cakeisnotalie == false) {
				//random cake made
				cakemade = true;
				int random = Random.Range(0,7);
				cakes[random].SetActive(true);
			} else if ( cakemade == false && cakeisnotalie == false){
                cakemade = true;
				int random2 = Random.Range(0,2);
				burntCakes[random2].SetActive(true);
				Debug.Log("cake not made");
			}
		}
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("collided with ingredient");
		//checking what ingredients are added
		if (other.name.Contains ("butter") || other.name.Contains ("flour") || other.name.Contains ("sugar") || other.name.Contains ("eggs")) {
			correctIngredients += 1;
			ingredientsAdded += 1;
			Destroy (other.gameObject);
		} else if (other.name.Contains ("avocado")) {
			secretIngredient = true;
			ingredientsAdded += 1;
			Destroy (other.gameObject);
		}else if (other.name.Contains("medal")){
			birthdayCake = true;
			ingredientsAdded +=1;
			Destroy(other.gameObject);
        } else if (other.name.Contains("Cake")) {
            speech.color = Color.white;
            speech.text = "bruh.";
        }
        else if (other.name.Contains("burnt")){
            Debug.Log("lol");
		} else if (other.name.Contains("w")) {
			wrong = true;
			ingredientsAdded+=1;
			Destroy(other.gameObject);
		}

	}

    public IEnumerator dialogue()
    {
        yield return new WaitForSeconds(3);
        speech.text = "What goes in a cake?";
        yield return new WaitForSeconds(3);
        speech.text = "Hopefully these ingredients are still fresh...";
        yield return new WaitForSeconds(3.5f);
        speech.color = Color.cyan;
        speech.text = "[Drag and drop the ingredients into the bowl. Click complete when you're done.]";
    }
    }
