using UnityEngine;


[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class Player_Animator : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer sprite;
    private Player_Controler player; // reference to your movement script

    private float lastXInput;

    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        player = GetComponent<Player_Controler>();
    }

    void Update()
    {
        // Get horizontal movement
        float moveX = player != null ? player.movement.x : 0f;
        bool isGrounded = player != null && player.isGrounded; // Make isGrounded public or add a getter

        // Update animations
        anim.SetFloat("Speed", Mathf.Abs(moveX));
        anim.SetBool("IsJumping", !isGrounded);

        // Flip sprite if moving left/right
        if (moveX > 0)
            sprite.flipX = false;
        else if (moveX < 0)
            sprite.flipX = true;
    }
}
