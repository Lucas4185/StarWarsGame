using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpaceFlight : MonoBehaviour {

    Rigidbody pilot;
    ConstantForce force;
    Vector3 pointPosition;
    GameObject point;
    
    bool invertPitch = true;
    bool invertYaw = false;
    public float sensitivity = 1.0f;
    public float turnSpeed = 10f;

    public float distance, smooth, rotationTime;
    public Vector3 offset;

    Vector3 a,b;

    void Start () { 
        pilot = GetComponent<Rigidbody>();
        force = GetComponent<ConstantForce>();

         point = new GameObject("Hover Point");
        //  point.AddComponent<Transform>();
    }

    void FixedUpdate() {
        //transfrom.rotation = Quaternion.LookAt(transfrom.position - (Camera.main.transfrom.position + offset));
        pointPosition = Camera.main.transform.position + offset + Camera.main.transform.forward * distance;
        point.transform.position = pointPosition;

        transform.rotation = Quaternion.Lerp(transform.rotation, Camera.main.transform.rotation, Time.deltaTime * rotationTime);

        Vector3 pointToMove = Vector3.Lerp(transform.position, pointPosition, Time.deltaTime * smooth);

        a = new Vector2(pointPosition.x - Camera.main.transform.position.x, pointPosition.z - Camera.main.transform.position.z).normalized;
		b = new Vector2(transform.position.x - Camera.main.transform.transform.position.x, transform.position.z - Camera.main.transform.position.z).normalized;
        
        float inproduct = a.x * b.x + a.y * b.y;

        float thetaRads = Mathf.Acos(inproduct);
		float thetaDegs = (thetaRads * Mathf.Rad2Deg);

        SetRoll((thetaDegs * -Input.GetAxisRaw("Mouse X")) * 5);

        pilot.MovePosition(pointToMove);
    }

    void SetThrust (float thrustForce) {
        force.relativeForce = Vector3.forward * thrustForce *  sensitivity;
    }
    
    void SetRoll (float rollForce) {
        if(!float.IsNaN(rollForce)) {
            force.relativeTorque = Vector3.forward * rollForce * sensitivity;
        }
        // transform.Rotate(transform.forward, rollForce * sensitivity);
    }

    void AddForce(float forceAmount) {
        pilot.AddForce(Vector3.left * forceAmount);
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(pointPosition, 0.1f);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, pointPosition);

        Gizmos.DrawSphere(new Vector3(a.x, 0f, a.y), 0.1f);
        Gizmos.color = Color.red;
		Gizmos.DrawSphere(new Vector3(b.x, 0f, b.y), 0.1f);
    }
}