using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;  // needs to be imported

public class MouseClickHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // the following Methods have to be implemented
    public void OnPointerDown(PointerEventData eventData)
    {
        // Do stuff when object is touched/clicked
    }

    public void OnPointerUp(PointerEventData data)
    {
        // do stuff when touch/click is released
    }
}
