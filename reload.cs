using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reload : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Collider>().tag == "restart") {
			SceneManager.LoadScene("Geek Night");
		}
	}
}
