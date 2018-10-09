using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform tr;
	// Update is called once per frame
	void Update () {
        //transform.position = tr.position;
        Vector3 newPoz = tr.position;
        newPoz.z = -10;
        transform.position = newPoz;
	}
}
