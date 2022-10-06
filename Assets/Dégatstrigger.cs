using UnityEngine;

public class Dégatstrigger : MonoBehaviour
{
    public int dégats = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.CompareTag("Player"))
        {



            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(dégats);

        }
    }
}
