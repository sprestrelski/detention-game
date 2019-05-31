using UnityEngine;
using System;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour {
	public GameObject map;
	public float speed;             //Floating point variable to store the player's movement speed.
	private GameObject instantiatedObj;


	// Use this for initialization
	void Start()
	{
		speed = 12;
	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	/*void FixedUpdate()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			moveTime = 1;
		}

		moveTime -= Time.deltaTime;
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis ("Horizontal");

		//Store the current vertical input in the float moveVertical.
		float moveVertical = Input.GetAxis ("Vertical");

		//Use the two store floats to create a new Vector2 variable movement.
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.AddForce (movement * speed);

		if (moveTime < 0) {
			rb2d.AddForce (movement * 0.0000000000001f);
		}
	}*/

	void Update (){
		Scene currentScene = SceneManager.GetActiveScene ();
		float horizontalInput = Input.GetAxis ("Horizontal");
		transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime * speed * horizontalInput);
		float verticalInput = Input.GetAxis ("Vertical");
		transform.Translate (new Vector3 (0, 1, 0) * Time.deltaTime * speed * verticalInput);

		if (transform.position.x > 30f) {
			transform.position = new Vector3 (30f, transform.position.y, 0);
		} else if (transform.position.x < -25.5f) {
			transform.position = new Vector3 (-25.5f, transform.position.y, 0);
		}

		if(transform.position.y > 12f)
		{
			transform.position = new Vector3(transform.position.x, 12, 0);
		}
		else if (transform.position.y < -12f)
		{
			transform.position = new Vector3(transform.position.x, -12f, 0);
		}

		if (Input.GetKeyDown ("t") && currentScene.name != "Scene3Game1" && currentScene.name != "Scene5Game3") {

			if (GameObject.Find ("Map(Clone)") != null) {
				Destroy (instantiatedObj);
			} else {
				instantiatedObj = Instantiate (map, new Vector3 (170, 260, 0), Quaternion.identity);
			}

		}

	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name.Equals ("QuestionMark")) {
			SceneManager.LoadScene ("Scene2Cut2");
		} else if (other.name.Equals ("CutSceneDoor")) {
			SceneManager.LoadScene("Scene5Game3");

		}

	}

}