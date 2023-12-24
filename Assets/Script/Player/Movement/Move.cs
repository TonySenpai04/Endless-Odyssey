using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : IMove
{
    private Rigidbody2D rigidbody;
    private bool isAccelerating = false;
    private float originalSpeed = 0f;
    private float speed;
    public Move(Rigidbody2D rigidbody, float speed)
    {
        this.rigidbody = rigidbody;
        this.speed = speed;
        originalSpeed = speed;
    }

    public void Run()
    {
        if (isAccelerating)
        {
            speed += 100;
        }
        else
        {
            speed = originalSpeed;
        }
    }

    void IMove.Move()
    {
       rigidbody.velocity= new Vector3(speed*Time.deltaTime*1,rigidbody.velocity.y,0);
    }
    public void ToggleAcceleration()
    {
        isAccelerating = !isAccelerating;
        Run();
        Debug.Log(speed);
    }
}
