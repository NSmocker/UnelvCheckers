using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMapCianGreen : MonoBehaviour {

	public GameObject cian,green,notCian,notRed,notGreen;

	// Use this for initialization
	void Start () {

	
		for (int j = 1; j <= 17; j++) {

			for (int i = 1; i <= 8; i++) {
				if (i % 2 != 0) {
					if (j % 2 != 0) {
						Instantiate (cian, new Vector3 (i, 0, j), cian.transform.rotation);
					} else {
						Instantiate (green, new Vector3 (i, 0, j), cian.transform.rotation);
					}
				}else{
					
					if (j % 2 != 0) {
						Instantiate (green, new Vector3 (i, 0, j), cian.transform.rotation);
					} else {
						Instantiate (cian, new Vector3 (i, 0, j), cian.transform.rotation);
					}
				}
			}
		}
	
	
	

		for (int i = 1; i <= 8; i++)
		{
			Instantiate (notCian, new Vector3 (i, 1, 1), cian.transform.rotation);
			Instantiate (notRed, new Vector3 (i, 1, 8), cian.transform.rotation);
			Instantiate (notRed, new Vector3 (i, 1, 9), cian.transform.rotation);
			Instantiate (notRed, new Vector3 (i, 1, 10), cian.transform.rotation);
			Instantiate (notGreen, new Vector3 (i, 1, 17), cian.transform.rotation);


		}
	
	
	
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
