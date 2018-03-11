using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class time : MonoBehaviour {

	public int waktu = 60;
	public Text hitung;
	public GameObject gameOverPanel;

	// Use this for initialization
	void Start () {
		StartCoroutine ("LoseTime");
	}
	
	// Update is called once per frame
	void Update () {
		hitung.text = ("Time Left = " + waktu);

		if (waktu <= 0) {
			StopAllCoroutines ();
            Time.timeScale = 0;
			gameOverPanel.SetActive (true);
		}
	}

	public void StopTime(){
		StopAllCoroutines ();
	}

	public IEnumerator LoseTime()
	{
		
			yield return new WaitForSeconds(1);
			waktu--;
		StartCoroutine(LoseTime());

	}
}
