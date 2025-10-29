using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerFlip : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Player_Controler player; // Reference to your movement script

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        player = GetComponent<Player_Controler>();
    }

    void Update()
    {
        if (player == null) return;

        float moveX = player.movement.x;

        if (moveX > 0)
            sprite.flipX = false; // Face right
        else if (moveX < 0)
            sprite.flipX = true;  // Face left
    }
}
