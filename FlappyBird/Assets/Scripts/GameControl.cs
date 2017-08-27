using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public Text scoreText;

	public bool gameOver = false;

	private int score = 0;

	public float scrollSpeed = -1.5f;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		}else if(instance != this){
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButton (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void BirdScored(){
		if (gameOver) {
			return;
		}
		score++;
		scoreText.text = "SCORE: " + score.ToString();
	}

	public void BirdDied(){
		gameOverText.SetActive (true);
		gameOver = true;
	}

}
