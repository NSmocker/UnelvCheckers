using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlayers: MonoBehaviour {

	public GameObject cian,green,red;


	// Use this for initialization
	void Start () {

	
	


			for (int i = 1; i <= 8; i++) {
				if (i % 2 != 0) {
				
				Instantiate (cian, new Vector3 (i, 0.83f, 1), cian.transform.rotation);
				Instantiate (cian, new Vector3 (i+1, 0.83f, 2), cian.transform.rotation);
				}
			}
	
	
	
		for (int i = 1; i <= 8; i++) {
			if (i % 2 != 0) {


				Instantiate (red, new Vector3 (i+1, 0.83f, 8), cian.transform.rotation);
				Instantiate (red, new Vector3 (i,0.83f , 9), cian.transform.rotation);
				Instantiate (red, new Vector3 (i+1,0.6f , 10), cian.transform.rotation);

			}
		}


		for (int i = 1; i <= 8; i++) {
			if (i % 2 != 0) {
				Instantiate (green, new Vector3 (i, 0.83f, 17), cian.transform.rotation);
				Instantiate (green, new Vector3 (i+1,0.83f , 16), cian.transform.rotation);
			}
		}


	
	
	
	
	
	
	
	
	
	
	
	}
	
	

	// Update is called once per frame
	void Update () {
		
	}
}
