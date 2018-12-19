using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour {

	public Transform target;

	[SerializeField]
	float angle;
	[SerializeField]
	Vector3 targetDirection;

	void Update () {
		Vector3 targetDirection = target.position - transform.position;
		float angle = Vector3.Angle(targetDirection, transform.forward);

		// transform.RotateAround(target.position, Vector3.up, 60 * Time.deltaTime);
		transform.rotation = Quaternion.Euler(target.eulerAngles.x, target.eulerAngles.y, 0);
	}
}
