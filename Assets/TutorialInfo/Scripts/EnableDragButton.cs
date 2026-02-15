using UnityEngine;

public class EnableDragButton : MonoBehaviour
{
    public DragSprite spriteToDrag;

    public void EnableDrag()
    {
        spriteToDrag.dragEnabled = true;
    }

    public void DisableDrag()
    {
        spriteToDrag.dragEnabled = false;
    }
}