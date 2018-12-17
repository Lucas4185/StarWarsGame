using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMove : MonoBehaviour {

	const float MAX_SPEED = 11f;

	Rigidbody rigidbody;
	float speed;

	public float acceleration = 0.25f;

	void Start() {
		rigidbody = GetComponent<Rigidbody>();
	}

	void Update() {
		if(Input.GetKey(KeyCode.W)) {
			if(speed < MAX_SPEED) {
				speed+=acceleration;
			}
		} else if(Input.GetKey(KeyCode.S)) {
			if(speed > 0) {
				speed-=acceleration;
			}
		}

		ApplyForce(speed);
	}

	private void ApplyForce(float amount) {
		rigidbody.velocity = (transform.forward * amount);
	}
}
