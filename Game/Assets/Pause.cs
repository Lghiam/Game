using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	public static bool paused = false;

	public GameObject pauseUI;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			{
				if (paused) {
					Resume ();
				} else {
					Pause1 ();
				}
			}
		}
	}

	public void Resume()
	{
		pauseUI.SetActive(false);
		Time.timeScale = 1f;
		paused = false;

	}

	void Pause1()
	{
		pauseUI.SetActive(true);
		Time.timeScale = 0f;
		paused = true;
	}
	public void Loading(){
		Debug.Log ("Loading, please wait");
		SceneManager.LoadScene ("Menu");
	}

	public void LevelSelect(){
		Debug.Log ("Returning to level select...");
		SceneManager.LoadScene ("Level Select");
	}


}