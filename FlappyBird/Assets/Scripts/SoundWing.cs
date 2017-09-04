using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWing : MonoBehaviour {

	private AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		//audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.instance.gameOver) {
			audio.Stop ();
		}
	}
}
