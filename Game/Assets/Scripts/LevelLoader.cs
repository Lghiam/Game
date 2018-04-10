using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

	private bool playerInField;

	public string levelLoad;

	// Use this for initialization
	void Start () {
		playerInField = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W) && playerInField) 
		{
			Application.LoadLevel (levelLoad);
		}
	}



	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player") 
		{
			playerInField = true;
		}

	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.name == "Player") 
		{
			playerInField = false;
		}
	}
}
