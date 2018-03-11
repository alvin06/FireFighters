using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gerak1 : MonoBehaviour {

	public float speed = 3.0f;
	public int nyawa;
	public int koin;

	public bool kiri, kanan;

	public GameObject kalah, menang;

    Analog anal;
    public GameObject analog;

	Text poin;
	// Use this for initialization
	void Start () {
		poin = GameObject.Find ("koin").GetComponent<Text> ();
        anal = analog.GetComponent<Analog>();
	}
	
	// Update is called once per frame
	void Update () {
		poin.text ="Point : " + koin.ToString();

		if (nyawa <= 0) {
			Destroy (gameObject);
            Time.timeScale = 0;
			kalah.SetActive (true);
		}

		if (koin >= 30)
        {
            Time.timeScale = 0;
            menang.SetActive (true);
		}

		if (Input.GetKey (KeyCode.LeftArrow) || (kiri== true) || Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
            anal.Recover();
		}
		else if (Input.GetKey (KeyCode.RightArrow) || (kanan== true) || Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
            anal.Recover();
		}

	}
	
				public void tekanKanan(){
					kanan = true;
				}

				public void lepaasKanan(){
					kanan = false;
				}

				public void tekanKiri(){
					kiri = true;
				}

				public void lepasKiri(){
					kiri = false;
				} 
}
