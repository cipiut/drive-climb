using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public Text Gems;
    public Text Coins;
    public Slider fuel;
	void Update () {
        Gems.text = ControlMenu.gems.ToString("0");
        Coins.text = ControlMenu.coins.ToString("0");
        fuel.value = CarController.fuel;
	}
}
