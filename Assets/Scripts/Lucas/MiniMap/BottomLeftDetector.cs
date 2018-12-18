using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomLeftDetector : MonoBehaviour {

    [SerializeField]
    private GameObject BottomLeftdetector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            BottomLeftdetector.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            BottomLeftdetector.SetActive(false);

        }
    }
}
