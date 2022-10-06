using UnityEngine;
using System.Collections;
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Healthbar healthBar;
    public bool isInvincible = false;
    public float InvflashDelay = 0.2f;
    public float InvAfterHitDuration = 2.5f;
    public SpriteRenderer graphics;

    public AudioSource audiosource;
    public AudioClip Clip;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
   
    public void Death() // réinitialiser la partie //PlayerMovement.instance.animator.SetTrigger("Death");
    {
        PlayerMovement.instance.enabled = false;
        PlayerMovement.instance.animator.SetTrigger("Death");
        GameOver.instance.OnPlayerDeath();
    }
    public void Respawn()
    {
        PlayerMovement.instance.enabled = true;
        PlayerMovement.instance.animator.SetTrigger("Respawn");
        currentHealth = 100;
        healthBar.SetHealth(currentHealth);
    }
    public void TakeDamage(int dégats)
    {
        
    
          if (!isInvincible)
          {
            audiosource.PlayOneShot(Clip);
            currentHealth -= dégats;
            healthBar.SetHealth(currentHealth);
            isInvincible = true;




            StartCoroutine(InvincibilityFLash());
            StartCoroutine(HandleInvDelay());

            if (currentHealth <= 0)
            {
                Death();
                return;

            }





        }
    }
    public IEnumerator InvincibilityFLash()
    {
        while (isInvincible)
        {
            graphics.color = new Color(1f, 1f, 1f, 0f); // les 4 unités correspondent à RGBA, RGB valeur maximale + 0 = transparent
            yield return new WaitForSeconds(InvflashDelay);
            graphics.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(InvflashDelay);

        }
    }

    public IEnumerator HandleInvDelay()
    {
        yield return new WaitForSeconds(InvAfterHitDuration);
        isInvincible = false;
    }
    public static PlayerHealth instance;
    private void Awake()
    {


        if (instance != null)
        {

            return;

        }
        instance = this; // signifie que "this" = instance, donc this = le script Playerhealth.


    }






}





