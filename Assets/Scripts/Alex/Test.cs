using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    Player player;

    void Start() {
        player = GameManagerScript.CreatePlayer(100, 0);
    }
}