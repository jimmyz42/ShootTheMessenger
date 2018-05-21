using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodMessageScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (this.GetComponent<Renderer> ().isVisible == false) {
			Debug.Log ("item out of scene");
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Bullet(Clone)") {
			Debug.Log ("collide with good message");
			GameControllerScript.ReduceLife (1);
			Destroy (this.gameObject);
		}
	}
}
