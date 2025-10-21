using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable

{
    public NpcDialogue dialogueData; // Reference to the NpcDialogue ScriptableObject
    public GameObject dialoguePanel; // UI Panel for displaying dialogue
    public TMP_Text dialogueText, nameText; // Text component for displaying dialogue lines
    public Image portraitImage; // Image component for displaying NPC portrait

    private bool isTyping, isDialogueActive; // Flags to track typing and dialogue state
    private int dialogueIndex;

    public object PauseController { get; private set; }

    public bool CanInteract()
    {
        return !isDialogueActive;
    }

    public void StartDialogue()
    {
        if (dialogueData == null) 
            return;

        if (isDialogueActive)
        {
            //Nextline
        }
        else
        {
            StartDialogue();
        }



    }

    void StartDialouge()
    {
        isDialogueActive = true;
        dialogueIndex = 0;
        dialogueIndex = 0;

        nameText.SetText(dialogueData.npcName);
        portraitImage.sprite = dialogueData.npcPortrait;

        dialoguePanel.SetActive(true);

        //typeLine
    }

    void Nextline()
    {
        if (isTyping)
        {
            StopAllCoroutines();
            dialogueText.SetText(dialogueData.dialogueLines[dialogueIndex]);
        }
        else if (++dialogueIndex < dialogueData.dialogueLines.Length)
        {
            StartCoroutine(TypeLine());
        }
        else
        {
            EndDialogue();
        }
    }

    private IEnumerator TypeLine()
    {
        return TypeLine(dialogueData);
    }

    IEnumerator TypeLine(NpcDialogue dialogueData)
    {
        isTyping = true;
        dialogueText.SetText("");

        foreach (char letter in dialogueData.dialogueLines[dialogueIndex])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(dialogueData.typingSpeed);
        }

        isTyping = false;

        if (dialogueData.autoProgressingLines.Length > dialogueIndex && dialogueData.autoProgressingLines[dialogueIndex])

        {
            // Replace this block in TypeLine(NpcDialogue dialogueData):

            // Original problematic line:
            // if(dialogueData.autoProgressLines.length > dialogueIndex && dialogueData.autoProgressLines[dialogueIndex])

            // Fixed line:
            if (dialogueData.autoProgressingLines.Length > dialogueIndex && dialogueData.autoProgressingLines[dialogueIndex])
            yield return new WaitForSeconds(dialogueData.autoProgressDelay);
            Nextline();
        }

    }

    public void EndDialogue()
    {
        StopAllCoroutines();
        isDialogueActive = false;
        dialogueText.SetText("");
        dialoguePanel.SetActive(false);
       


    }

    public void interact()
    {
        throw new System.NotImplementedException();
    }
}
