using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDetector : MonoBehaviour {

    [SerializeField]
    private GameObject Topdetector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Topdetector.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Topdetector.SetActive(false);

        }
    }
}
