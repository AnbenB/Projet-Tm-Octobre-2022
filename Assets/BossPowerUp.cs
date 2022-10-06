using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPowerUp : MonoBehaviour
{
    


    private void OnTriggerEnter2D(Collider2D Collision)
    {
        BossHealth.instance.isInvincible = false;
        Destroy(gameObject);
    }

}
