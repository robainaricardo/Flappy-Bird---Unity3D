using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepitingBackground : MonoBehaviour {

	private BoxCollider2D groundColider;
	private float groudHorizontalLength;

	// Use this for initialization
	void Start () {
		groundColider = GetComponent<BoxCollider2D> ();
		groudHorizontalLength = groundColider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < - groudHorizontalLength){
			RepositionBackground ();
		}
	}

	private void RepositionBackground(){
		Vector2 groundOffset = new Vector2 (groudHorizontalLength * 2f, 0);
		transform.position = (Vector2)transform.position + groundOffset;
	}
}
