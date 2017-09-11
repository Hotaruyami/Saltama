using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : PhysicsObject
{

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;
    private bool mirantDreta;
    private bool mirantDreta2;
    public float dashVelocity;
    public GameObject arma2;
    public GameObject arma;
    public int wait1, wait2;
    // Use this for initialization
    void Awake()
    {
        wait1 = 0;
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        if (this.gameObject.tag == "Player") {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                disparar1();
            }
            move.x = Input.GetAxis("Horizontal2");
            if (Input.GetButtonDown("Jump") && grounded)
            {
                velocity.y = jumpTakeOffSpeed;
            }
            else if (Input.GetButtonUp("Jump"))
            {
                if (velocity.y > 0)
                {
                    velocity.y = velocity.y * 0.5f;
                }
            }
         
            if (Input.GetKeyDown(KeyCode.A))
            {
                mirantDreta = false; 
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                mirantDreta = true;    
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                print("Dash P1");
                if (mirantDreta)
                {
                    rb2d.AddForce(new Vector2(dashVelocity*5,0));
                }
                else
                {
                    rb2d.AddForce(new Vector2(-dashVelocity*5, 0));
                }
            }
        }
        else if (this.gameObject.tag == "Player2") {
            move.x = Input.GetAxis("Horizontal");

            if (Input.GetKeyDown(KeyCode.Keypad2)) {

                if (mirantDreta2)
                {
                    GameObject dispar = Instantiate(arma2, this.transform.position, Quaternion.Euler(0, 0, 0.1f));

                }
               if(!mirantDreta2) {
                    GameObject dispar = Instantiate(arma2, this.transform.position, Quaternion.Euler(0, 0, -0.1f));


                }
            }
                if (Input.GetButtonDown("Jump2") && grounded)
            {
                velocity.y = jumpTakeOffSpeed;
            }
            else if (Input.GetButtonUp("Jump2"))
            {
                if (velocity.y > 0)
                {
                    velocity.y = velocity.y * 0.5f;
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                mirantDreta2 = false;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                mirantDreta2 = true;
            }
            if (Input.GetKeyDown(KeyCode.Keypad0))
            {
                print("Dash P2");
                if (mirantDreta2)
                {
                    rb2d.AddForce(new Vector2(dashVelocity*5, 0));
                }
                else
                {
                    rb2d.AddForce(new Vector2(-dashVelocity*5, 0));
                }
            }
        }
        targetVelocity = move * maxSpeed;
    }
    private void disparar1() {
        if (wait1 < 1)
        {

            if (mirantDreta)
            {
                GameObject dispar = Instantiate(arma, this.transform.position, Quaternion.Euler(0, 0, 0.1f));

            }
            if (!mirantDreta)
            {
                GameObject dispar = Instantiate(arma, this.transform.position, Quaternion.Euler(0, 0, -0.1f));


            }
            wait1 = 1000;
        }

        
    }
    
}