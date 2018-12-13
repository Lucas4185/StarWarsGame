using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomRightDetector : MonoBehaviour {

   
    [SerializeField]
    private GameObject BottomRightdetector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            BottomRightdetector.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            BottomRightdetector.SetActive(false);

        }
    }
}
