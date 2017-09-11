using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispa : MonoBehaviour {
    public Rigidbody2D rb;
    public int morir;
	// Use this for initialization
	void Start () {

        print(this.transform.rotation.eulerAngles.z);
        if (this.transform.rotation.eulerAngles.z ==0.1f) {

            rb = this.GetComponent<Rigidbody2D>();
            morir = 1600;
            rb.AddRelativeForce(Vector2.right * morir);
        }
        else 
        {

            rb = this.GetComponent<Rigidbody2D>();
            morir = 1600;
            rb.AddRelativeForce(Vector2.left * morir);
        }

    }
	
	// Update is called once per frame
	void FixedUpdate () {

       
   

    }
}
