using UnityEngine;
using UnityEngine.UI;

public class NPCInteraction : MonoBehaviour
{
    // Public variable to hold a reference to the UI Text object
    public GameObject interactPrompt;

    private bool playerInRange;

    void Start()
    {
        // Ensure the UI text is hidden at the start
        if (interactPrompt != null)
        {
            interactPrompt.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player is in range.");

            // Show the UI text when the player is in range
            if (interactPrompt != null)
            {
                interactPrompt.SetActive(true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player is out of range.");

            // Hide the UI text when the player leaves the range
            if (interactPrompt != null)
            {
                interactPrompt.SetActive(false);
            }
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            PerformInteraction();
        }
    }

    void PerformInteraction()
    {
        Debug.Log("The player is interacting with " + gameObject.name + "!");
        // Add your specific NPC dialogue or other interaction logic here.
    }
}