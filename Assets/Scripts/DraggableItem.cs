using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Transform originalParent;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        transform.SetParent(originalParent.root); // 드래그 시 최상위로 이동
        canvasGroup.blocksRaycasts = false; // 슬롯 감지를 위해 Raycast 차단
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.position = eventData.position; // 마우스를 따라 이동
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true; // 다시 감지 가능하도록 변경

        // 슬롯이 없으면 원래 자리로 되돌리기
        if (transform.parent == originalParent.root)
        {
            transform.SetParent(originalParent);
        }
    }
}
