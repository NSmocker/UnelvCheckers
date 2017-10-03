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


	GameObject CheckDown(Vector3 pos)
	{
	RaycastHit hit;
			Physics.Raycast (pos+ new Vector3(0,3,0), Vector3.down, out hit, 5f);
			var check  = hit.collider.gameObject;  
			Debug.Log (check.name);
			return check;
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


		if (selectedItem != null && selectedFrame != null) 
		{
			


			var check = CheckDown (selectedFrame.transform.position);

		


			if (check.tag == "Brown") 
			{
				//if(check.
				selectedItem.transform.position = new Vector3 (selectedFrame.transform.position.x, 0.83f, selectedFrame.transform.position.z);
				selectedItem = null;
				selectedFrame = null;

			}
			//перевірка на можливість кроку
			// крок
		}




	}
}
