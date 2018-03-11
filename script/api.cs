using UnityEngine;
using System.Collections;

public class api : MonoBehaviour {

	Gerak1 KomponenGerak;
    time mati;
    public GameObject cek;
    public int darah;
	//air padam;
	
	// Use this for initialization
	void Start () {
		KomponenGerak = GameObject.Find("mobil").GetComponent<Gerak1>();
		mati = cek.GetComponent<time>();
		//padam = GameObject.Find ("prefabair").GetComponent<air> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D (Collider2D other){
		if (other.transform.tag == "Player") {
			mati.waktu -= 10;
			KomponenGerak.koin++;
			Destroy(gameObject);

		}
        if (other.transform.tag == "air")
        {
			KomponenGerak.koin ++;
            darah--;
			Destroy (other.gameObject);
            if(darah <= 0)
            {
				if (gameObject.tag == "Merah") {
					mati.waktu += 2;
				}
				if (gameObject.tag == "Biru") {
					mati.waktu += 3;
				}
				if (gameObject.tag == "Hitam") {
					mati.waktu += 4;
				}
                Destroy(gameObject);
            }
			//Destroy (padam.gameObject);
        }

	}
}
