using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Awal : MonoBehaviour {

	public GameObject homePanel;
	public GameObject startPanel;
	public GameObject notedPanel;
	public GameObject creditPanel;
	public GameObject resumePanel;
	public GameObject tutorPanelA;
	public GameObject tutorPanelB;
	public GameObject gameOverPanel;
	public GameObject gameWonPanel;

	public GameObject TimeCheck;
	time coba;

	//private bool over = false;

	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Tutor", 1);
		Time.timeScale = 1;
		coba = TimeCheck.GetComponent<time> ();
		homePanel.SetActive (true);
		startPanel.SetActive(false);
		notedPanel.SetActive(false);
		creditPanel.SetActive (false);
		resumePanel.SetActive (false);
	}

	public void TutorClicked(){
//		if (PlayerPrefs.GetInt ("Tutor") == 0) {
//			StartGameClicked();

//		}else 
		tutorPanelA.SetActive (true);
		homePanel.SetActive (false);
		startPanel.SetActive(false);
		notedPanel.SetActive(false);
		creditPanel.SetActive (false);
		resumePanel.SetActive (false);
	}

	public void NextClick(){
		tutorPanelB.SetActive (true);
		tutorPanelA.SetActive (false);
	}

	public void StartGameClicked(){
        Time.timeScale = 1;
		Application.LoadLevel (1);
	}

	public void TouchClicked(){
		startPanel.SetActive(true);
		notedPanel.SetActive(false);
		creditPanel.SetActive (false);
		homePanel.SetActive (false);
		resumePanel.SetActive (false);
	}

	public void NotedClicked(){
		notedPanel.SetActive (true);
		startPanel.SetActive (false);
		creditPanel.SetActive (false);
		homePanel.SetActive (true);
		resumePanel.SetActive (false);
	}

	public void CreditClicked(){
		creditPanel.SetActive (true);
		notedPanel.SetActive (false);
		startPanel.SetActive (false);
		homePanel.SetActive (false);
		resumePanel.SetActive (false);
	}

	public void ExitGameClick(){
        Application.Quit();
	}

	public void BackToMenuClicked(){
		homePanel.SetActive (false);
		startPanel.SetActive(true);
		notedPanel.SetActive(false);
		creditPanel.SetActive (false);
		resumePanel.SetActive (false);
	}

	public void PauseClicked(){
		coba.StopTime ();
		resumePanel.SetActive (true);
		homePanel.SetActive (false);
	}

	public void RestartClicked(){
		Time.timeScale = 1;
		Application.LoadLevel (1);
	}

	public void ResumeClicked(){
		StartCoroutine(coba.LoseTime());
		resumePanel.SetActive (false);
	}

	public void ExitResumeClicked()
    {
        Time.timeScale = 1;
        Application.LoadLevel (0);
		startPanel.SetActive (true);
	}
}
