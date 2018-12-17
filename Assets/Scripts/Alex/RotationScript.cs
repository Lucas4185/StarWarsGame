using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

	Transform target;

	void Start() {
		target = Camera.main.gameObject.transform;
	}
	
	void Update () {
		// Vector3 targetDirection = target.position - transform.position;
		// float angle = Vector3.Angle(targetDirection, transform.forward);
		// transform.position = target.position + Vector3.RotateTowards(transform.position - target.position, target.position, angle, 0f);

		// Vector3 angle = transform.eulerAngles;
		// Debug.Log(angle.y);

		Vector3 targetDir = target.position - transform.position;
        Vector3 forward = transform.forward;
        float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);
        if (angle < -5.0F)
            print("turn left");
        else if (angle > 5.0F)
            print("turn right");
        else
            print("forward");
	}
}
