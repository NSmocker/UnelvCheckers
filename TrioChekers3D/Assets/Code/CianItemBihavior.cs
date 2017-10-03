using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CianItemBihavior : MonoBehaviour {

	public CianPlayer mainPlayer;

	void OnMouseDown()
	{



	}



	void OnMouseUp()
	{

		mainPlayer.selectedItem = transform.gameObject;


	}

	void OnMouseDrag()
	{

	}

	// Use this for initialization
	void Start () {
		mainPlayer = GameObject.Find ("CianPlayer").GetComponent<CianPlayer> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
