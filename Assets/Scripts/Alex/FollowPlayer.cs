using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform target;

	public float distance, smooth;
	public Vector3 offset;

	public float smoothSpeed = 0.125f;

	void Update() {
		// target.position = Vector3.Lerp(target.position, Camera.main.transform.position + offset + Camera.main.transform.forward * distance, Time.deltaTime * smooth);
	}
}
