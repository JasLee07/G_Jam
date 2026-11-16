using UnityEngine;
using UnityEngine.EventSystems;

public class character_dialogue : MonoBehaviour, IPointerClickHandler
{
    public string speakerName;

    [TextArea(2, 5)]
    public string[] dialogueLines;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            dialogue.Instance.StartDialogue(speakerName, dialogueLines);
        }
    }
}