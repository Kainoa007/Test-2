using System.Collections;
using System.Collections.Generic;   
using TMPro;    
using UnityEngine.UI;   
using UnityEngine;

public class NPC : MonoBehaviour

{
    public NpcDialogue dialogueData; // Reference to the NpcDialogue ScriptableObject
    public GameObject dialoguePanel; // UI Panel for displaying dialogue
    public TMP_Text dialogueText,nameText; // Text component for displaying dialogue lines
    public Image portraitImage; // Image component for displaying NPC portrait

    private int dialougeIndex; // Current index of the dialogue line being displayed
    private bool isTyping, isDialogueActive; // Flags to track typing and dialogue state



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
