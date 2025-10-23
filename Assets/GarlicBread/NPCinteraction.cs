using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public NpcDialogue dialogue;
    public GameObject interactPrompt;

    private bool playerInRange;

    void Start()
    {
        interactPrompt?.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (!DialogueManager.Instance.IsDialogueActive())
                interactPrompt?.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            interactPrompt?.SetActive(false);
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!DialogueManager.Instance.IsDialogueActive())
            {
                DialogueManager.Instance.StartDialogue(dialogue);
                interactPrompt?.SetActive(false);
            }
        }
    }
}
