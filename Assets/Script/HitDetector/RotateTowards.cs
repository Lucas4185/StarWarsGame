using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowards : MonoBehaviour {

    //[SerializeField]
    //private GameObject CrossHair;

    //[SerializeField]
    //private GameObject enemy;

    //[SerializeField]
    //private Transform indicator;

    //public Transform player;

    // public Transform target;

    //private Vector3 _direction;

    // Angular speed in radians per sec.
    [SerializeField]
    private GameObject target;

    [SerializeField]
    private GameObject hitRadar;


    private bool hit = false;






    private int timer = 0;

    void Start()
    {
        hitRadar.SetActive(false);
    }

    void Update()
    {

        lookAtEnemy();
        //Debug.Log(timer);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            hit = true;
            Debug.Log("hit");
        }
    }

    private void lookAtEnemy()
    {

        if (hit == true)
        {
            hitRadar.SetActive(true);
            Vector3 targ = target.transform.position - transform.position;
            targ.z = 0f;

            Vector3 objectPos = transform.position;
            targ.x = targ.x - objectPos.x;
            targ.z = targ.z - objectPos.z;

            float angle = Mathf.Atan2(targ.z, targ.x) * Mathf.Rad2Deg;
            hitRadar.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -angle));
            timer++;
        }

        if (timer == 200)
        {
            hitRadar.SetActive(false);
            hit = false;
            timer = 0;
        }

    }
}
