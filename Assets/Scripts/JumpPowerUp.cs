using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    public int JPAmount;
    public AudioSource audiosource;
    public AudioClip sound;

   private void OnTriggerEnter2D(Collider2D Collision)
   {
        AudioSource.PlayClipAtPoint(sound, transform.position);
        PlayerMovement.instance.JumpPowerUp(JPAmount);
        Destroy(gameObject);
   }

}
