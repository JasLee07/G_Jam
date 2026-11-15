using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class start_talking : MonoBehaviour
{
    public static start_talking Instance;
    [Header("UI References")]
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    private string[] currentLines;
    private int lineIndex;
    private bool isDialogueActive;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    void Update()
    {
        // Advance dialogue when clicking anywhere while dialogue is open
        if (isDialogueActive && Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            NextLine();
        }
    }

    public void StartDialogue(string[] lines)
    {
        if (isDialogueActive) return;

        currentLines = lines;
        lineIndex = 0;
        isDialogueActive = true;

        dialoguePanel.SetActive(true);
        dialogueText.text = currentLines[lineIndex];
    }

    private void NextLine()
    {
        lineIndex++;
        if (lineIndex < currentLines.Length)
        {
            dialogueText.text = currentLines[lineIndex];
        }
        else
        {
            EndDialogue();
        }
    }

    private void EndDialogue()
    {
        isDialogueActive = false;
        dialoguePanel.SetActive(false);
    }
}

