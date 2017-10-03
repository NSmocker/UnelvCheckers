using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellBihavior : MonoBehaviour {
	public GameObject filledObject;
	public bool isFilled;
	public Operator op;
	public CianPlayer cp;
	public RedPlayer rp;
	public GreenPlayer gp;

	// Use this for initialization
	void Start () {

		op = Camera.main.gameObject.GetComponent<Operator> ();
		cp = GameObject.Find ("CianPlayer").GetComponent<CianPlayer> ();
		rp = GameObject.Find ("RedPlayer").GetComponent<RedPlayer> ();
		gp = GameObject.Find ("GreenPlayer").GetComponent<GreenPlayer> ();

	}



	void OnMouseUp()
	{
		if (op.cianTurn) 
		{
			cp.selectedFrame = transform.gameObject;
		}
		if (op.greenTurn) 
		{
		//	gp.selectedFrame = transform.gameObject;
		}
		if (op.redTurn) 
		{
			//rp.selectedFrame = transform.gameObject;
		}

	}
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		isFilled = Physics.Raycast (transform.position, Vector3.up, out hit, 5f);
		if (!isFilled) {
			filledObject = null;
		} 
		else 
		{
			filledObject = hit.collider.gameObject;
		}






	}
}
