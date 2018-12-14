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

        // Vector3 a = (Camera.main.transform.position - transform.position);
        // Vector3 b = (Camera.main.transform.position - pointPosition);

        // Debug.DrawLine(transform.position, a, Color.blue);
        // Debug.DrawLine(transform.position, b, Color.blue);

        // float inproduct = a.x * b.x + a.y * b.y;

        // float theta = Mathf.Acos(inproduct);
        // SetRoll(theta);

        #region distance
        // Vector3 heading = transform.position - pointPosition;
        // float dist = heading.magnitude;
        // Vector3 direction = heading / dist;

        //SetRoll((dist * direction.z) * 10);
        #endregion

        pilot.MovePosition(pointToMove);
    }

    void SetThrust (float thrustForce) {
        force.relativeForce = Vector3.forward * thrustForce *  sensitivity;
    }
    
    void SetRoll (float rollForce) {
        force.relativeTorque = Vector3.forward * rollForce * sensitivity;
        // transform.Rotate(transform.forward, rollForce * sensitivity);
    }

    void AddForce(float forceAmount) {
        pilot.AddForce(Vector3.left * forceAmount);
    }

    void OnDrawGizmos() {
        Gizmos.DrawSphere(pointPosition, 0.1f);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, pointPosition);
    }
}