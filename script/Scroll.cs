using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float speed= 0.5f;
	Vector3 jalan;
	// Use this for initialization
	void Start () {
		jalan = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate ((new Vector3 (-1, 0, 0)) * speed * Time.deltaTime);

		if (transform.position.x < -22.23) {
			transform.position = jalan;
		}
	}
}
