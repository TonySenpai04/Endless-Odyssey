using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MovementControllerBase
{

    protected override void Start()
    {
        base.Start();
        move = new Move(rigidbody, speed);
    }
    private void Update()
    {
        move.Move();
    }
    public void StopMove()
    {
        IStopMove stopMove=(IStopMove) move;
        stopMove.StopMove();
    }
}
