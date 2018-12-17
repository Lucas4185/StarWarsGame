using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour
{

    public GameObject clockText;

    public float totalSeconds = 600f;
    public int minutes = 0;
    public int seconds = 0;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Code for 10 minutes
        minutes = Mathf.FloorToInt(totalSeconds / 60f);
        seconds = Mathf.FloorToInt(totalSeconds % 60f);
        clockText.GetComponent<Text>().text = minutes.ToString("00") + ":" + seconds.ToString("00");
        totalSeconds = 600f - Time.time;
    }

}