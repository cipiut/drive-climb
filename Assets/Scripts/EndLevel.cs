using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col)
    {  
        if (col.tag.Equals("Player"))
        {
            if (SceneManager.GetActiveScene().buildIndex.Equals(GetLength())) SceneManager.LoadScene(0);//menu
            else {
                ControlMenu.level++;
                SceneManager.LoadScene(7);//levelComplete
                PlayerPrefs.SetInt("Level",ControlMenu.level);
            }
        }
    }

    private static int GetLength()
    {
        return SceneManager.sceneCountInBuildSettings-3;
    }
}
