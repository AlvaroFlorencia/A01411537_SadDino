﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.CompareTag("damaged")){  //If the tag of the player is "damaged",then eliminate this object
			
			Destroy(gameObject);
		}
	}

}
