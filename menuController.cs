using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour {

	public Button startGame;

	// Use this for initialization
	void Start () {
		Button btn = startGame.GetComponent<Button> ();
		btn.onClick.AddListener (BeginGame);
	}

	void BeginGame () {
		SceneManager.LoadScene("Geek Night");
	}
}
