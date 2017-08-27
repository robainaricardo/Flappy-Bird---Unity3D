using UnityEngine;
using System.Collections;

public class Column : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other){
		if(other.GetComponent<PolygonCollider2D>() != null){
			GameControl.instance.BirdScored();
		}
	}
}