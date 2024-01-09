using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMove : IMove
{
    [SerializeField] private float moveSpeed ;
    [SerializeField] private GameObject weaponPrefab;
    public WeaponMove(float moveSpeed, GameObject weaponPrefab)
    {
        this.moveSpeed = moveSpeed;
        this.weaponPrefab = weaponPrefab;
    }

    void IMove.Move()
    {
        weaponPrefab.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
