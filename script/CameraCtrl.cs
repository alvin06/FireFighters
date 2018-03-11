using UnityEngine;
using System.Collections;

public class CameraCtrl : MonoBehaviour {

	public Transform player;
    public float offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x + 4f +offset, transform.position.y, transform.position.z);
	}
}
