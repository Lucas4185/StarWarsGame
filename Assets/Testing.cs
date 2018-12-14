using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour {

	public Transform ship;
	Transform point;

	Vector2 a,b;

	void Update() {
		if(point == null) {
			point = GameObject.Find("Hover Point").transform;
		}
		a = new Vector2(transform.position.x - point.position.x, transform.position.z - point.position.z);
		b = new Vector2(transform.position.x - ship.position.x, transform.position.z - ship.position.z);

		print(a.x + " - " + b.x);
	}

	void OnDrawGizmos() {
		Gizmos.DrawSphere(new Vector3(a.x, 0f, a.y), 0.5f);
		Gizmos.DrawSphere(new Vector3(b.x, 0f, b.y), 0.5f);
	}

}
