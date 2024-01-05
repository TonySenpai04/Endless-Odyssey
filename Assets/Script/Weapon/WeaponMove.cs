using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMove : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 5f;
   

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

    }
   
}
