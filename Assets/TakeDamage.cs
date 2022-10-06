using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public float health, maxHealth = 4f;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Damage(float damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            animator.SetFloat("Health", health);
            
            Destroy(gameObject);
        }
    }
}
