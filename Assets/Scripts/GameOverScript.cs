using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {
	public GameObject dead;
	public GameObject outOfFuel;
	void Start(){
		if(CarController.fuel<=0f){
			outOfFuel.SetActive(true);
			dead.SetActive(false);
			
		}
		else{
			outOfFuel.SetActive(false);
			dead.SetActive(true);
		}
	}

	public void Menu(){
		SceneManager.LoadScene(0);//menu
		CarController.fuel=1f;
		CarController.input=0;

	}
}
