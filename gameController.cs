using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

	public bool isPaused;

	public GameObject pauseMenu;
	public Button resume;
	public Button exit;

	// Use this for initialization
	void Start () {
		isPaused = false;
		pauseMenu.SetActive (false);
		Button res = resume.GetComponent<Button> ();
		res.onClick.AddListener (resumeGame);
		Button ex = exit.GetComponent<Button> ();
		ex.onClick.AddListener (exitGame);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && isPaused == false) {
			isPaused = true;
			Time.timeScale = 0.0f;
			pauseMenu.SetActive (true);

		} else if (Input.GetKeyDown (KeyCode.Escape) && isPaused == true) {
			resumeGame ();
		}
	}

	void resumeGame(){
		isPaused = false;
		Time.timeScale = 1.0f;
		pauseMenu.SetActive (false);
	}

	void exitGame() {
		SceneManager.LoadScene("menu");
		Time.timeScale = 1.0f;
	}
}
