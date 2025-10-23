
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance { get; private set; }

    [Header("UI References")]
    public GameObject dialoguePanel;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    private NpcDialogue currentDialogue;
    private int currentLineIndex;
    private bool isDialogueActive;


    private void Start()
    {
        dialoguePanel.SetActive(false);
        isDialogueActive = false;
    }


    private void Awake()

   {
       if (Instance == null)
          Instance = this;
      else
           Destroy(gameObject);
    }

    public void StartDialogue(NpcDialogue dialogue)
    {
        currentDialogue = dialogue;
        currentLineIndex = 0;
        isDialogueActive = true;

        dialoguePanel.SetActive(true);
        nameText.text = dialogue.npcName;
        ShowCurrentLine();
    }

    private void Update()
    {
        if (isDialogueActive && Input.GetKeyDown(KeyCode.E))
        {
            AdvanceDialogue();
        }
    }

    private void ShowCurrentLine()
    {
        if (currentDialogue != null && currentLineIndex < currentDialogue.dialogueLines.Length)
        {
            dialogueText.text = currentDialogue.dialogueLines[currentLineIndex];
        }
    }

    private void AdvanceDialogue()
    {
        currentLineIndex++;

        if (currentLineIndex >= currentDialogue.dialogueLines.Length)
        {
            EndDialogue();
            Debug.Log("SADFSDFSDFSF");
            dialoguePanel.SetActive(false);
        }
        else
        {
            ShowCurrentLine();
            Debug.Log("Advanced to line " + currentLineIndex);
        }
    }

    private void EndDialogue()
    {
        dialoguePanel.SetActive(false);
       // isDialogueActive = false;
       // currentDialogue = null;
    }

    public bool IsDialogueActive()
    {
        return isDialogueActive;
    }
}
