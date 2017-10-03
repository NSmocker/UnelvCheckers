using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour {
	public bool cianTurn,redTurn,greenTurn;

	// Use this for initialization
	void Start () {
		
	}
	public void NextPlayer()
	{
		if (cianTurn = true) 
		{

			cianTurn = false;
			redTurn = true;
			greenTurn = false;

		}
		if (redTurn = true) 
		{

			cianTurn = false;
			redTurn = false;
			greenTurn = true;

		}
		if (greenTurn = true) 
		{

			cianTurn = true;
			redTurn = false;
			greenTurn = false;

		}


	}

	// Update is called once per frame
	void Update () {
		
	}
}
