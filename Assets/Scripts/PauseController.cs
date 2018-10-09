using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {

	public GameObject PauseMenu;
	public GameObject GameUI;

	public void Pause(){
		GameUI.SetActive(false);
		PauseMenu.SetActive(true);
		Time.timeScale=0f;
	}

	public void Resume(){
		PauseMenu.SetActive(false);
		GameUI.SetActive(true);
		Time.timeScale=1f;
	}
	public void Menu(){
		SceneManager.LoadScene(0);
	}
}
