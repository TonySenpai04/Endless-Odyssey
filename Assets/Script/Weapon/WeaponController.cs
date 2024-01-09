using Assets.FantasyMonsters.Scripts;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField]private WeaponDataSO weaponData;
    [SerializeField] private float moveSpeed;
    [SerializeField] private IMove weaponMove;
    void Start()
    {
        weaponMove = new WeaponMove(moveSpeed, this.gameObject);
        GetComponent<SpriteRenderer>().sprite = weaponData.image;
    }

    void Update()
    {
        weaponMove.Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Monster enemy = collision.gameObject.GetComponent<Monster>();
        if (enemy != null)
        {
            gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }

          
    }
}
