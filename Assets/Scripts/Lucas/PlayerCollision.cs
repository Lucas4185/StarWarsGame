using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class PlayerCollision : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
        
            CameraShaker.Instance.ShakeOnce(2f, 2f, 0f, 1f);

        }
    }
}
