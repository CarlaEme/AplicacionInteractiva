using UnityEngine;
using UnityEngine.EventSystems; // ¡Muy importante!

public class ArrastrarObjeto : MonoBehaviour, IDragHandler {
    
    // Este método se activa automáticamente cuando arrastras el objeto con el mouse
    public void OnDrag(PointerEventData eventData) {
        // Mueve el objeto siguiendo la posición exacta del mouse en la pantalla
        transform.position = eventData.position;
    }
}