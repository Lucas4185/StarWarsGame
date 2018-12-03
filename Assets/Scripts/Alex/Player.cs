using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {
	public float Health { get; private set; }
	public float Shield { get; private set; }
	public float RobotCooldown { get; private set; }
	public float ShieldCooldown { get; private set; }
	public float RobotRegenAmount { get; private set; }
	public float RobotRegenCooldown { get; private set; }
	public float ShieldTime { get; private set;}
	public float RocketDamage { get; private set; }

	public Player(float health, float shield) {
		Health = health;
		Shield = shield;
	}

	public float TakeDamage(float amount) {	
		Health -= amount;
		return Health;
	} 
}
