using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class right5 : MonoBehaviour {
	public GameObject epoxy;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnClick(){
		epoxy.SetActive (true);
		SceneManager.LoadScene ("Scene6Game4");
	}
}
