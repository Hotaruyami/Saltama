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

    // Use this for initialization
    void Awake()
    {

    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        if (this.gameObject.tag == "Player") {

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
}