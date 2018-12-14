using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    float h, v;

    void Update() {
        h = Input.GetAxis("Mouse X");
        v = Input.GetAxis("Mouse Y");
    }
}
