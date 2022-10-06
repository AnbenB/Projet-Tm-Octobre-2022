
using UnityEngine;

public class Dégats : MonoBehaviour
{
    public int dégats = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("Player"))
        {



            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(dégats);

        }
    }
}
