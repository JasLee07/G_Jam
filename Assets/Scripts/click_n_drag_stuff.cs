using UnityEngine;
using UnityEngine.EventSystems;

public class dragg_stuff : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerClickHandler
{
    private Vector2 _distance;
    [TextArea(2, 5)]
    public string[] dialogueLines;

    public void OnPointerDown(PointerEventData eventData)
    {
        _distance = Camera.main.ScreenToWorldPoint(eventData.position) - transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pointerPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        Vector2 newObjectPosition = pointerPosition - _distance;
        transform.position = newObjectPosition;
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        // Trigger only on left-click
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            start_talking.Instance.StartDialogue(dialogueLines);
        }
    }
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
