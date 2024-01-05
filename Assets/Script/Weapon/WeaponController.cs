using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField]private WeaponDataSO weaponData;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = weaponData.image;
    }

    void Update()
    {
       
    }
}
