using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private IMove move;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        move = new Move(rigidbody, speed);
    }
    private void Update()
    {
        move.Move();
    }
    public void ToggleAcceleration()
    {
       
    }
}
