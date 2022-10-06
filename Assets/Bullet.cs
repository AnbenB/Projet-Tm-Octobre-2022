using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Bulletspeed;

    public Rigidbody2D rb;
    void Start()
    {
        
        
        rb.velocity = transform.forward * Bulletspeed;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ennemi"))
        {
            Debug.Log("collision");

        }
         Destroy(gameObject);   
    
    }



}
