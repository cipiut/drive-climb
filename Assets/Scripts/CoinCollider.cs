using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollider : MonoBehaviour {
	
	public void OnTriggerEnter2D(Collider2D col)
    {   
        if (col.tag.Equals("Player")){
			SpriteRenderer aux = gameObject.GetComponent<SpriteRenderer>();
			if(aux.sprite.name.Equals("coin5"))ControlMenu.coins+=5;
			else if(aux.sprite.name.Equals("coin25"))ControlMenu.coins+=25;
			else ControlMenu.coins+=100;
			PlayerPrefs.SetInt("Coins",ControlMenu.coins);
			Destroy(gameObject);
    	}
	}
}
