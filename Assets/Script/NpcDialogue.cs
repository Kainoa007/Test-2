using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NpcDialogue", menuName = "NPC Dialogue")]
public class NpcDialogue : ScriptableObject
{
    public string npcName;  // Name of the NPC
    public Sprite npcPortrait;  // Portrait image of the NPC
    public string[] dialogueLines;  // Array of dialogue lines
    public  float typingSpeed = 0.05f; // Time delay between each character
    public AudioClip voicesound; // Sound played when a character is typed 
    public float voicePitch = 1f; // Pitch of the voice sound
    public bool[] autoProgressingLines; // Array indicating if each line auto progresses
    public float autoProgressDelay = 2f; // Delay before auto progressing to the next line

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
