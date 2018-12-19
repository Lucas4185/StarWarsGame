using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public float sensitivity;
	
	void Update () {
		float h = Input.GetAxis("Mouse X") * sensitivity;
		float v = Input.GetAxis("Mouse Y") * sensitivity;

		transform.Rotate(v, h, 0);
	}
}
