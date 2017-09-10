using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.transform.position= new Vector3(this.transform.position.x,this.transform.position.y+ 0.03f , this.transform.position.z)
       ;
    }
}
