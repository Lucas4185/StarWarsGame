using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour {

    public Image RedBar;
    private int nextUpdate = 1;

   
	// Use this for initialization
	void Start () {
        RedBar.type = Image.Type.Filled;
        RedBar.fillMethod = Image.FillMethod.Radial360;
        RedBar.fillOrigin = (int)Image.Origin360.Top;
        RedBar.fillClockwise = false;

        //Bar starts at 25 minutes, timer starts at 10 10/25 = 0.4
        RedBar.fillAmount = 0.4f;
    }

    // Update is called once per frame
    void Update () {
 

        if (Time.time >= nextUpdate)
        {
            //Debug.Log(Time.time + ">=" + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            decreaseBar();
        }

    }

    void decreaseBar() { 
        //10 minutes * 60 seconds = 600 seconds
        RedBar.fillAmount -= (0.4f/600);
    }

}
