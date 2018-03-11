using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class air : MonoBehaviour {

	private bool padam = false;
	public Rigidbody2D rb;
	//public GameObject bulirair;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D (Collider2D other){
		Debug.Log ("Col");
		if (other.transform.tag == "Player") {
			Debug.Log ("Player");
			Destroy(gameObject);
		}
		if (other.transform.tag == "Jalan")
		{
			Debug.Log ("Jalan");
			Destroy(gameObject);
		}
		if (other.transform.tag == "Merah")
		{
			Debug.Log ("Merah");
			Destroy(gameObject);
		}
		if (other.transform.tag == "Biru")
		{
			Debug.Log ("Biru");
			Destroy(gameObject);
		}
		if (other.transform.tag == "Hitam")
		{
			Debug.Log ("Hitam");
			Destroy(gameObject);
		}

	}
}
