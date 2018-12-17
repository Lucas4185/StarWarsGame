using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {

    public int health = 63;
    public Image YellowBar;
    public GameObject healthText;
    public GameObject scripts;
    private Player player;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        player = scripts.GetComponent<Player>();
        YellowBar.type = Image.Type.Filled;
        YellowBar.fillMethod = Image.FillMethod.Horizontal;
        YellowBar.fillAmount = player.health / 100.0f;
        healthText.GetComponent<Text>().text = player.health.ToString();
        healthText.GetComponent<Text>().text = player.health.ToString();
    }
}
