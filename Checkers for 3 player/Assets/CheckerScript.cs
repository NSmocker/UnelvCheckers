using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerScript : MonoBehaviour {

    public bool NoDestoy = false;
    public bool Damka;
    void OnCollisionEnter(Collision collision)
    {
        if(!NoDestoy)
        {
            Info.GameField[(int)this.transform.position.x, (int)this.transform.position.y, (int)this.transform.position.z] = (char)0;
            Destroy(this.gameObject);
            Info.D = true;
        }
    }
}
