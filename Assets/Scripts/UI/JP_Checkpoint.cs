using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JP_Checkpoint : MonoBehaviour {

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update () {
        transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.back,
            mainCamera.transform.rotation * Vector3.up);
	}
}
