using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheaterScript : MonoBehaviour {
	//public GameObject test;
	public GameObject prefab;
	//bool oneBullet = true;
	// Use this for initialization
	private GameObject bullet;
	private System.TimeSpan prevTime;
	void Start () {
		//Debug.Log (test.name);
		//GameObject foo = Instantiate (prefab);
		//foo.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2, 2);
		prevTime = System.DateTime.Now.TimeOfDay.Subtract(System.TimeSpan.FromSeconds(1000));
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector3.left * Time.deltaTime*10);
			//if(this.GetComponent<Renderer> ().isVisible == false)transform.Translate(Vector3.right * Time.deltaTime*50);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector3.right * Time.deltaTime*10);
			//if(this.GetComponent<Renderer> ().isVisible == false)transform.Translate(Vector3.left * Time.deltaTime*50);
		} 
		if(Input.GetKey(KeyCode.UpArrow))
		{
			if (System.DateTime.Now.TimeOfDay.Subtract(prevTime).CompareTo(System.TimeSpan.FromSeconds(0.5)) == 1) {
				bullet = Instantiate (prefab, transform.position, Quaternion.Euler (0, 0, 90));
				Debug.Log ("bullet generated");
				//oneBullet = false;
				bullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 1);
				prevTime = System.DateTime.Now.TimeOfDay;
			}
		}
	}
}