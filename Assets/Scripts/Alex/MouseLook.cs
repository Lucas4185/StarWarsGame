using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
[RequireComponent(typeof(Rigidbody))]
public class MouseLook : MonoBehaviour {

	Rigidbody rb;

	void Start() {
		// Cursor.lockState = CursorLockMode.Locked;
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		Vector3 eulerRotation = Vector3.up * 1f * Input.GetAxis ("Mouse X"); 
		
	}
}