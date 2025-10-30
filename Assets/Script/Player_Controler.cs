using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controler : MonoBehaviour
{

    [SerializeField] private Animator animator; 
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public int coins = 0;

    private Rigidbody2D rb;
    [HideInInspector] public Vector2 movement;

    [HideInInspector] public bool isGrounded = true;
    private int input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        //Debug.Log("isGrounded:" + isGrounded);
        if (input != 0)
        { 
            animator.SetBool("IsRunning", true);

        }
        else
        {
            animator.SetBool("IsRunning", false);
        }   
        
    }

    void Flip()
    {
       
    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movement.x * moveSpeed, rb.linearVelocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("JumpForce"))
        {
            jumpForce = 20f;
        }
    }
}
