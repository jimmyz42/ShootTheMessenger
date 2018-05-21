using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessengerMoves : MonoBehaviour {

	public GameObject goodPrefab;
	public GameObject badPrefab;

	private GameObject goodMessage;
	private GameObject badMessage;

	private System.TimeSpan badPrevTime;
	private System.TimeSpan goodPrevTime;

	// Use this for initialization
	void Start () {
		badPrevTime = System.DateTime.Now.TimeOfDay.Subtract(System.TimeSpan.FromSeconds(1000));
		goodPrevTime = System.DateTime.Now.TimeOfDay.Subtract(System.TimeSpan.FromSeconds(1000));

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.up * Time.deltaTime*3);
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.down * Time.deltaTime*3);
		} 
		if (Input.GetKey(KeyCode.Q))
		{
			if (System.DateTime.Now.TimeOfDay.Subtract (goodPrevTime).CompareTo (System.TimeSpan.FromSeconds (1)) == 1) {
				goodMessage = Instantiate (goodPrefab, transform.position, Quaternion.Euler (0, 0, 0));
				Debug.Log ("good message generated");
				goodMessage.GetComponent<Rigidbody2D> ().velocity = new Vector2 (1,0);
				goodPrevTime = System.DateTime.Now.TimeOfDay;
				badPrevTime = System.DateTime.Now.TimeOfDay;

			}
			//oneBullet = false;
		}
		if(Input.GetKey(KeyCode.E))
		{
			if (System.DateTime.Now.TimeOfDay.Subtract (badPrevTime).CompareTo (System.TimeSpan.FromSeconds (1)) == 1) {
				badMessage = Instantiate (badPrefab, transform.position, Quaternion.Euler(0,0,0));
				Debug.Log ("bad message generated");
				//oneBullet = false;
				badMessage.GetComponent<Rigidbody2D> ().velocity = new Vector2 (1, 0);
				badPrevTime = System.DateTime.Now.TimeOfDay;
				goodPrevTime = System.DateTime.Now.TimeOfDay;
			}
		} 
	}
}