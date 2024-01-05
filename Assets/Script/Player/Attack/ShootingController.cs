using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform firePoint;
    public IShooting shooting;
   
    private void Start()
    {
        shooting=new Shooting(bulletPrefab, firePoint);
      
    }

    private void ShootWeapon()
    {
        shooting.Shoot();  
    }
 
    
}
