using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameMaster : MonoBehaviour {


	private PlayerController player;

	public int points;

	public Text pointsText;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		pointsText.text = ("Points: " + points);


	}
}
