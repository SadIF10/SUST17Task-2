using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void next() {
		SceneManager.LoadScene ("option");
	}

	public void ne() {
		SceneManager.LoadScene ("ttc");
	}

	public void openA() {
		SceneManager.LoadScene ("a");
	}

	public void menu() {
		SceneManager.LoadScene ("camit");
	}

	public void onlyRead() {
		SceneManager.LoadScene ("b");
	}
}
