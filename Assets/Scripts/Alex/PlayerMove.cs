using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	Rigidbody rb;
	public float speed = 3f;
	public float acceleration = 0.5f;
	float maxSpeed = 30f;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		rb.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime * speed);
	}

	void Update() {
		Vector3 moveCamTo = transform.position - transform.forward + Vector3.up;
		float bias = 0.96f;
		Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo * (1.0f+bias);
		Camera.main.transform.LookAt(transform.position + transform.forward * 30.0f);

		if(Input.GetKey(KeyCode.W)) {
			if(speed < maxSpeed) {
				speed += acceleration;
			}
		}
		if(Input.GetKey(KeyCode.S)) {
			if(speed > 0) {
				speed -= acceleration;
			}
		}
		if(Input.GetKey(KeyCode.A)) {
			transform.Rotate(Vector3.right);
		}
		if(Input.GetKey(KeyCode.D)) {
			transform.Rotate(Vector3.left);
		}
	}
}
