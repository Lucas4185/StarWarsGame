using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointDistance : MonoBehaviour {

    [SerializeField]
    private Sprite checkMark;

    [SerializeField]
    private Text distanceText;

    [SerializeField]
    private Text titleText;

    [SerializeField]
    private GameObject player;

    private Image image;

    private float realDistance;
    private float distance;
    private float oldDistance;

    private bool reached;

    void Start()
    {
        image = GetComponentInChildren<Image>();
        reached = false;
    }

    // Update is called once per frame
    void FixedUpdate () {
        realDistance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        distance = Mathf.Round(realDistance);

        if (distance != oldDistance)
        {
            distanceText.text = distance + "m";

            oldDistance = distance;
        }

        if (realDistance <= 5 && !reached)
        {
            image.sprite = checkMark;

            reached = true;
            titleText.text = "REACHED";

            Destroy(gameObject, 2);
        }
	}

    void OnDestroy()
    {
        Debug.Log("SPAWN NEW CHECKPOINT");
    }
}
