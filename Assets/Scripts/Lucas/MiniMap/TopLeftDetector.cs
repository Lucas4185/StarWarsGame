using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopLeftDetector : MonoBehaviour {

    [SerializeField]
    private GameObject TopLeftdetector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            TopLeftdetector.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            TopLeftdetector.SetActive(false);

        }
    }
}
