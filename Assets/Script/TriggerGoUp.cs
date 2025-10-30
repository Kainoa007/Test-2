using UnityEngine;

public class TriggerGoUp : MonoBehaviour
{
    public float upwardSpeed = 5f; // How fast the player goes up

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Get the player's rigidbody and disable gravity
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.gravityScale = 0f; // Disable gravity so they don’t fall back down
                rb.linearVelocity = new Vector2(0, upwardSpeed); // Start moving up
            }

            // Optionally disable player control script
            Player_Controler controller = collision.GetComponent<Player_Controler>();
            if (controller != null)
            {
                controller.enabled = false; // Stops horizontal/jump inputs
            }
        }
    }
}
