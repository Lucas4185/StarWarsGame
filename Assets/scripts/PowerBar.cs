using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour {

    //public int health = 63;
    public Image Yellow;
    public Image Red;
    public GameObject scripts;
    private Player player;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        player = scripts.GetComponent<Player>();
        Yellow.type = Image.Type.Filled;
        Yellow.fillMethod = Image.FillMethod.Horizontal;
        Yellow.fillAmount = player.speed / 100.0f;
        Red.type = Image.Type.Filled;
        Red.fillOrigin = (int)Image.OriginHorizontal.Right;
        Red.fillMethod = Image.FillMethod.Horizontal;
        Red.fillAmount = player.firepower / 100.0f;

    }
}
