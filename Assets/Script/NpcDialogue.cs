using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NpcDialogue", menuName = "NPC Dialogue")]
public class NpcDialogue : ScriptableObject
{
    public string npcName;  
    public Sprite npcPortrait;  
    public string[] dialogueLines;
    public bool[] autoProgressingLines;
    public float autoProgressDelay = 1.5f;
    public  float typingSpeed = 0.05f; 
    public AudioClip voicesound; 
    public float voicePitch = 1f;
    internal object autoProgressLines;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
