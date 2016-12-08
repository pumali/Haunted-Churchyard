using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	public Animation anim; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			Debug.Log ("registered collision");
			anim.Play (); 
			Debug.Log ("played anim");
		}
	}
}
