using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroscopeExample : MonoBehaviour {

	public float speed = 100;

	private float time;

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

 void FixedUpdate() 
  {
     Input.gyro.enabled = true;
     float initialOrientationX = Input.gyro.rotationRateUnbiased.x;
     float initialOrientationY = Input.gyro.rotationRateUnbiased.y;

	 time += Time.deltaTime;

     float accX = -Input.acceleration.y;
     float accY = Input.acceleration.x;

	 if(time > 3){
	 	Debug.LogError("Xg: " + initialOrientationX + " Yg: " + initialOrientationY + "Xa: " + accX + " Ya: " + accY);
		 time = 0;
	 }
     rb.AddForce (accY * speed, 0.0f , -accX * speed);
 }
}
