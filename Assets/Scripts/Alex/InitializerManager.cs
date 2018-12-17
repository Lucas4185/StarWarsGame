using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializerManager : MonoBehaviour {

	public float playerHealth, playerShield;

	void Awake() {
		GameManagerScript.CreatePlayer(playerHealth, playerShield);
	}
}
