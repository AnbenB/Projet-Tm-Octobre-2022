using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int bosshealth = 500;
    public int currenthealth;
    public Animator animator;
    public Healthbar healthbar;
    public bool isInvincible = true;
    public static BossHealth instance;
    public Rigidbody2D rb;
    public BoxCollider2D box;
    void Start()
    {
        currenthealth = bosshealth;
        healthbar.SetMaxHealth(bosshealth);
    }
    public float InvflashDelay = 0.2f;
    public float InvAfterHitDuration = 2.5f;
    public SpriteRenderer graphics;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {

            TakeDamage(100);



        }
    }



    private void Awake()
    {


        if (instance != null)
        {

            return;

        }
        instance = this;


    }



    public void TakeDamage(int damage)
    {
         if (!isInvincible)
         {



            currenthealth -= damage;
            healthbar.SetHealth(currenthealth);
            if (currenthealth <= 0)
            {
                
                Death();
                return;

            }
            
            StartCoroutine(InvincibilityFLash());
            StartCoroutine(HandleInvDelay());


        }

        void Death()
        {
            animator.SetTrigger("Death");
            rb.bodyType = RigidbodyType2D.Kinematic;
            box.enabled = false;

        }
    }

    public IEnumerator InvincibilityFLash()
    {
        while (isInvincible)
        {
            graphics.color = new Color(1f, 1f, 1f, 0f); // les 4 unit?s correspondent ? RGBA, RGB valeur maximale + 0 = transparent
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













    // partie regard au joueur

    public Transform player;

    public bool isFlip = false;

    public void RegardePlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;
        if (transform.position.x > player.position.x && isFlip)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlip = false;


        }
        else if (transform.position.x < player.position.x && !isFlip)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlip = true;

        }

    }
}