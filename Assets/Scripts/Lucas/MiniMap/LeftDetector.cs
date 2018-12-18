using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDetector : MonoBehaviour {

    [SerializeField]
    private GameObject Leftdetector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Leftdetector.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Leftdetector.SetActive(false);

        }
    }
}
