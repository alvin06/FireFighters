 using UnityEngine;
 using System.Collections;
using UnityEngine.UI;
 
 public class gerak : MonoBehaviour
 {
	Text daya_tahan,poin;

	public float speed = 1.5f;

    public int api = 0;

	public int nyawa;
	public int koin;

	void Start(){
		daya_tahan = GameObject.Find ("nyawa").GetComponent<Text>();
		poin = GameObject.Find ("koin").GetComponent<Text> ();
	}
 
     void Update ()
     {
		if (nyawa <= 0) {
			Destroy (gameObject);
		}
		daya_tahan.text ="Hidup : " +nyawa.ToString();
		poin.text ="Poin : " + koin.ToString();
         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.position += Vector3.left * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.position += Vector3.right * speed * Time.deltaTime;
         }
     }
 }