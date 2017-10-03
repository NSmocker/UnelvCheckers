using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CianPlayer : MonoBehaviour {
	public GameObject selectedItem;
	public GameObject selectedFrame;
	public GameObject[] allItems;

	bool temp;
	// Use this for initialization
	void Start () {
		
		temp = false;
	}


	// Update is called once per frame
	void Update () 
	{
		if (!temp) 
		{   temp = true;
			allItems = GameObject.FindGameObjectsWithTag ("CianPlayer");
		}
		if (selectedItem != null) 
		{
			selectedItem.transform.Rotate (0,0,0.3f);
		}





	}
}
