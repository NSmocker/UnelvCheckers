using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operator : MonoBehaviour {
	
	public bool cianTurn,redTurn,greenTurn;
	public Text turn;
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
			turn.text = "Черга червоних!";
		}
		if (redTurn = true) 
		{

			cianTurn = false;
			redTurn = false;
			greenTurn = true;
			turn.text = "Черга зелених!";
		}
		if (greenTurn = true) 
		{

			cianTurn = true;
			redTurn = false;
			greenTurn = false;
			turn.text = "Черга синіх!";
		}


	}

	// Update is called once per frame
	void Update () {
		
	}
}
