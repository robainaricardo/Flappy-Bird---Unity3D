using UnityEngine;
using System.Collections;

public class Column : MonoBehaviour {

	private AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.GetComponent<PolygonCollider2D>() != null){
			GameControl.instance.BirdScored();
			audio.Play ();
		}
	}
}