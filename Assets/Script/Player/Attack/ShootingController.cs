using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : ShootingControllerBase
{
    private void Start()
    {
        shooting=new Shooting(bulletPrefab, firePoint);
      
    }

    private void ShootWeapon()
    {
        
        shooting.Shoot();  
    }
 
    
}
