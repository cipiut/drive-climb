using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour {
    public static int gems;
    public static int level;
    public static int car;
    public static int coins;
    public void Start(){
        gems = PlayerPrefs.GetInt("Gems");
        level = PlayerPrefs.GetInt("Level");
        if(level ==0 )level++;
        car = PlayerPrefs.GetInt("Car");
        coins = PlayerPrefs.GetInt("Coins");
        CarController.fuel=1f;
        CarController.input=0;

    }
	public void PlayGame()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene(level);
    }
    public void ExitGame()
    {
        PlayerPrefs.SetInt("Gems",gems);
        PlayerPrefs.SetInt("Level",level);
        PlayerPrefs.SetInt("Car",car);
        PlayerPrefs.SetInt("Coins",coins);
        Application.Quit();
    }
}
