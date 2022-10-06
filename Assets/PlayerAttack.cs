using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    
    
    private void Damage(int damage)
    {
        damage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            
            animator.SetTrigger("Attack");

            

            

        }
    
      
    
    }
}
