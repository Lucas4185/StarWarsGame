using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomDetector : MonoBehaviour {

    [SerializeField]
    private GameObject Bottomdetector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Bottomdetector.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Bottomdetector.SetActive(false);

        }
    }
}
