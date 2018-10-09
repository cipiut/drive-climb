using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die: MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag.Equals("Terrain")){
            SceneManager.LoadScene(6);//gameOver
        }
    }

    void Update(){
        if(CarController.fuel<=0f){
            SceneManager.LoadScene(6);//gameOver
        }
    }
}
