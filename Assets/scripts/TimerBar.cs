using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour {

    public Image RedBar;
    private int nextUpdate = 1;

    public 
	// Use this for initialization
	void Start () {
        RedBar.type = Image.Type.Filled;
        RedBar.fillMethod = Image.FillMethod.Radial360;
        RedBar.fillOrigin = (int)Image.Origin360.Top;
        RedBar.fillClockwise = false;
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
        RedBar.fillAmount -= (0.4f/600);
    }

}
