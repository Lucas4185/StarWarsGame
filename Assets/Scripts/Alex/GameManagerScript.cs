using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManagerScript {
    static Player player;
    public static Player Player { get { return player; } private set {} }
    
    public static void CreatePlayer(float health, float shield) {
        //Only create the player once!
        if(player == null)
            player = new Player(health, shield);
    }
}