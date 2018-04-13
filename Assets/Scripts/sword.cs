using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		
	}

    void OnCollisionEnter(Collision hit)
    {
        if(hit.gameObject.tag == "enemy")
        {
            Destroy(hit.gameObject);
        }
    }
}
