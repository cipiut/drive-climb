using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollide : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D col)
    {   
        if (col.tag.Equals("Player")){
			ControlMenu.gems++;
			PlayerPrefs.SetInt("Gems",ControlMenu.gems);
			Destroy(gameObject);
    	}
	}
}
