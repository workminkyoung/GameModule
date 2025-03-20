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
        transform.SetParent(originalParent.root); // �巡�� �� �ֻ����� �̵�
        canvasGroup.blocksRaycasts = false; // ���� ������ ���� Raycast ����
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.position = eventData.position; // ���콺�� ���� �̵�
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true; // �ٽ� ���� �����ϵ��� ����

        // ������ ������ ���� �ڸ��� �ǵ�����
        if (transform.parent == originalParent.root)
        {
            transform.SetParent(originalParent);
        }
    }
}
