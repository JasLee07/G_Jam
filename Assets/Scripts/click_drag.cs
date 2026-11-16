using UnityEngine;
using UnityEngine.EventSystems;

public class click_drag : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private Vector2 _distance;

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
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
