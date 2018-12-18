using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDetector : MonoBehaviour {

    [SerializeField]
    private GameObject Rightdetector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Rightdetector.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Rightdetector.SetActive(false);

        }
    }
}
