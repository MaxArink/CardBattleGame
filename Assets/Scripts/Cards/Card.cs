using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card : MonoBehaviour,
    IDragHandler, IBeginDragHandler, IEndDragHandler,
    IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] private Image _dragObject;
    private Transform _parentBeforeDrag;

    public Transform ParentAfterDrag { get; private set; }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        _parentBeforeDrag = transform.parent;
        ParentAfterDrag = _parentBeforeDrag;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        _dragObject.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        //transform.SetParent(ParentAfterDrag);
        //GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        _dragObject.raycastTarget = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       
    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }
}
