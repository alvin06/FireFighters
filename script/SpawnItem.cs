using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour {

	//api Kondisiapi;

	public bool apimati = false;

	public GameObject x;

	public Transform[] SpawnPoints;
	public float spawnTime;
	public GameObject apimerah;
	public GameObject apibiru;
	public GameObject apihitam;

	public int maxapi = 1;
	public int jumlahapi = 0;

	public int jenisapi;
	//publiv GameObject[] api;

	// Use this for initialization
	void Start () {
		spawnTime = Random.Range(1, 5);
		Invoke("SpawnApi", spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnApi() {
		jenisapi = Random.Range (1, 4);
		int spawnIndex = Random.Range(0, SpawnPoints.Length);
		switch (jenisapi)
		{
		case 1:
			x = Instantiate (apimerah, SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
			break;
		case 2:
			x = Instantiate (apibiru, SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
			break;
		case 3:
			x = Instantiate (apihitam, SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
			break;
		}
		jumlahapi++;
		if (jumlahapi >= maxapi) {
			//CancelInvoke ("SpawnApi");

			//StartCoroutine (WaitUntil ());
			//jumlahapi = 0;
			//SpawnApi ();
			//InvokeRepeating("SpawnApi", spawnTime, spawnTime);
		}
		if (apimati) {
			jumlahapi = 0;
			Invoke("SpawnApi", spawnTime);
			apimati = false;
		}
	}

	IEnumerator WaitUntil()
	{
		yield return new WaitForSeconds(100);
	}
}
