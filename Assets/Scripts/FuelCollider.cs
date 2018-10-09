using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if(col.tag.Equals("Player")){
			CarController.fuel=1f;
			Destroy(gameObject);
		}
	}
}
