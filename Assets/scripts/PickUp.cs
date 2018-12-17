using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public GameObject scriptHolder;
    private Player player;


    void Start()
    {
       player = scriptHolder.GetComponent<Player>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player") {
            player.health += 10;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update ()
    {

     
       
    }
}
