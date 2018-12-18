using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField]
    private float lifeTimeInSeconds;

    [HideInInspector]
    public Vector3 destination;
    [HideInInspector]
    public Vector3 startPos;
    [HideInInspector]
    public GameObject ship;

    [SerializeField]
    private float speed;

    private float startTime;

    private float journeyLength;


    void Start()
    {
        Destroy(gameObject, lifeTimeInSeconds);

        startPos = gameObject.transform.position;

        // Keep a note of the time the movement started.
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startPos, destination);
    }

    void Update()
    {
        if (Vector3.Distance(startPos, gameObject.transform.position) >= journeyLength)
        {
            Hit();
        }
    }

    void FixedUpdate () {

        if (destination == null) return;

        float distCovered = (Time.time - startTime) * speed;

        float fracJourney = distCovered / journeyLength;

        transform.position = Vector3.Lerp(startPos, destination, fracJourney);

    }

    void Hit()
    {
        Destroy(gameObject);
    }

}
