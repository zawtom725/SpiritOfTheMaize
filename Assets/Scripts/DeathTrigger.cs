﻿using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	private Vector2 startingPos = new Vector2(-15,0);
	public int deathCounter = 0;
	//to use, make an object with a Collider2D, make it a trigger, and attach this script

    void OnTriggerEnter2D(Collider2D coll)
    {
		coll.gameObject.transform.position = startingPos; //resets position
        coll.gameObject.transform.localRotation = Quaternion.identity; //resets rotation
		//in case it was rotating for some strange reason, lock your damn z rotation in your rigidbody
		deathCounter++; //just fun to have
		}
}
