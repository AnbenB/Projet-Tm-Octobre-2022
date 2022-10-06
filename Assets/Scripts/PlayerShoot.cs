using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform Shootposition;
    public GameObject Bullet;


     void Update()
      {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bullet, Shootposition.position, transform.rotation);
            
                
            
        }
     }

    
}
