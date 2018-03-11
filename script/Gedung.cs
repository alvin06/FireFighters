using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gedung : MonoBehaviour {

    Gerak1 pemadam;
    public GameObject jalan;
    public Vector3 offset;
    Renderer rend;
    float distance;

    // Use this for initialization
    void Start () {
        pemadam = GameObject.FindObjectOfType<Gerak1>();
        rend = GetComponent<Renderer>();
        offset.x = rend.bounds.size.x;
    }
	
	// Update is called once per frame
	void Update () {
        distance = transform.position.x - pemadam.transform.position.x;
        if (distance > 40)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Gerak1>() != null)
        {
            GameObject x = Instantiate(jalan, transform.position + offset, Quaternion.identity);
        }
    }
}
