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
       player = GameManagerScript.Player;
    }
	
	// Update is called once per frame
	void Update () {
        YellowBar.type = Image.Type.Filled;
        YellowBar.fillMethod = Image.FillMethod.Horizontal;
        YellowBar.fillAmount = player.Health / 100.0f;
        healthText.GetComponent<Text>().text = player.Health.ToString();
        healthText.GetComponent<Text>().text = player.Health.ToString();
    }
}
