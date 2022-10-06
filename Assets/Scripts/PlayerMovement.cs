
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    public float movespeed;

    public Rigidbody2D rb;
    
    private Vector3 velocity = Vector3.zero;
    public SpriteRenderer spriteRenderer;
    public bool isJumping;

    public Animator animator;
    public float JumpForce;

    public Transform groundcheckL;
    public Transform groundcheckR;
    private float horizontalMovement;
    public static PlayerMovement instance;
    private void Awake()
    {


        if (instance != null)
        {

            return;

        }
        instance = this; // signifie que "this" = instance, donc this = le script PlayeMovement.
    
    
    }

    

  

    private void Update()
    {
        IsGrounded = Physics2D.OverlapArea(groundcheckL.position, groundcheckR.position);


         horizontalMovement = Input.GetAxis("Horizontal") * movespeed * Time.fixedDeltaTime;
        MovePlayer(horizontalMovement);
        float characterVelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("speed", characterVelocity);


        if (Input.GetButtonDown("Jump")  && IsGrounded)
        {
            isJumping = true;
        }
   
       else if (Input.GetKeyDown(KeyCode.W) && IsGrounded)
       {

            isJumping = true;
            

       }

        Flip(rb.velocity.x);

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
 

        }




    }

    public void JumpPowerUp(int amount)
    {
        JumpForce += amount;

    }
    public bool IsGrounded;

    private void FixedUpdate()
    {
        MovePlayer(horizontalMovement);
        
    
        
    }

    
    


    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);


        if(isJumping == true)
        {
            rb.AddForce(new Vector2(0f, JumpForce));
            isJumping = false;
        }
    }
    void Flip(float _velocity)
    {
        if(_velocity > 0.1f)
        {
            spriteRenderer.flipX = false;

        }
    else if(_velocity < -0.1f) // valeur n?gative car au moment ou speed = 0 le personnage va se retourner sinon.
        {
            spriteRenderer.flipX = true;

        }



    }

}

