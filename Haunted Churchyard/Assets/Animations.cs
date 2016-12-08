using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	public Animation anim; 
	public AudioClip jetbikesound; 
	private AudioSource source; 

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animation> ();
		source = GetComponent<AudioSource> (); 
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			Debug.Log ("registered collision");
			anim.Play (); 
			Debug.Log ("played anim");
			source.PlayOneShot (jetbikesound, 1F); 
		}
	}
}
