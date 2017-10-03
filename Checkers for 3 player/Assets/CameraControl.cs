using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public int SpeedMove;
    public int SpeedScale;
    public GameObject Camera;
    public float MaxLocalPos;
	void Start () {
        this.transform.position = new Vector3(Info.size/2, Info.size / 2, Info.size / 2);
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y + SpeedMove * Time.deltaTime, this.transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y - SpeedMove * Time.deltaTime, this.transform.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y, this.transform.eulerAngles.z + SpeedMove * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y, this.transform.eulerAngles.z - SpeedMove * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if(Mathf.Abs(Camera.transform.localPosition.x) < MaxLocalPos)
            {
                Camera.transform.localPosition += new Vector3(SpeedScale * Time.deltaTime, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Mathf.Abs(Camera.transform.localPosition.x) > 2)
            {
                Camera.transform.localPosition -= new Vector3(SpeedScale * Time.deltaTime, 0,0);
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Camera.transform.localPosition.y < MaxLocalPos/2)
            {
                Camera.transform.localPosition += new Vector3(0, SpeedScale * Time.deltaTime, 0);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Camera.transform.localPosition.y > -MaxLocalPos/2)
            {
                Camera.transform.localPosition -= new Vector3(0, SpeedScale * Time.deltaTime, 0);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Camera.transform.localPosition.z < MaxLocalPos/2)
            {
                Camera.transform.localPosition += new Vector3(0, 0, SpeedScale * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Camera.transform.localPosition.z > -MaxLocalPos/2)
            {
                Camera.transform.localPosition -= new Vector3(0, 0, SpeedScale * Time.deltaTime);
            }
        }
    }
}
