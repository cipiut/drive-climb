using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

    public float speed = 1500;
    public float rotation = 1500;
    public float move = 0f;
    public float rot = 0f;
    public WheelJoint2D spate;
    public WheelJoint2D fata;
    public Rigidbody2D rb;
    public static float fuel;

    public static int input;
	void Update () {
        if(input!=0)fuel-=0.002f;
        if(fuel>0f){
            move = -input * speed;
            //move = -Input.GetAxisRaw("Vertical") * speed;//for pc
            //rot = Input.GetAxisRaw("Vertical") * rotation;//for pc
            rot = input * rotation;
        }
    }

	void FixedUpdate () {
        if (move == 0f)
        {
            spate.useMotor = false;
            fata.useMotor = false;
        }
        else
        {
            spate.useMotor = true;
            fata.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = move, maxMotorTorque = 10000 };
            spate.motor = motor;
            fata.motor = motor;
        }
        rb.AddTorque(rot * Time.fixedDeltaTime);
	}
}
