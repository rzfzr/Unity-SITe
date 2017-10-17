using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {


	public Text score;
	public Text highScore;




	void Start() {
		score.text = PlayerPrefs.GetFloat("Score").ToString();
		highScore.text = PlayerPrefs.GetFloat("High").ToString();
	}



	public void onPlayAgain() {

		SceneManager.LoadScene("Play");

	}
}

