
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

	private PlayerController player; //gives access to the script

	// Use this for initialization
	void Start () {

		player = gameObject.GetComponentInParent<PlayerController> (); //playerController script is in parent

	}

	void OnTriggerEnter2D (Collider2D col){

		player.isGrounded = true;

	}

	void OnTriggerStay2D (Collider2D col){

		player.isGrounded = true;

	}

	void OnTriggerExit2D (Collider2D col){

		player.isGrounded = false;

	}

}

