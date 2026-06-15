using UnityEngine;
using UnityEngine.EventSystems;

public class PlacePosition : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        DragDrop draggableItem = dropped.GetComponent<DragDrop>();

        Transform oldParent = draggableItem.ParentAfterDrag;

        // Slot bevat al item
        if (transform.childCount > 0)
        {
            Transform currentItem = transform.GetChild(0);

            // verplaats bestaand item terug
            currentItem.SetParent(oldParent);

            RectTransform currentRect =
                currentItem.GetComponent<RectTransform>();

            currentRect.anchoredPosition = Vector2.zero;
        }

        // nieuwe parent voor dragged item
        draggableItem.ParentAfterDrag = transform;
    }
}
