using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class UIInventoryPage : MonoBehaviour
{
    [SerializeField]
    private UIInventoryItem _itemPrefab;

    [SerializeField]
    private RectTransform _contentPanel;

    [SerializeField]
    private List<UIInventoryItem> _inventoryItems = new List<UIInventoryItem>();

    public void InitializeInventoryUI(int inventorySize)
    {
        for (int i = 0; i < inventorySize; i++)
        {
            UIInventoryItem item = Instantiate(_itemPrefab, Vector3.zero, Quaternion.identity, _contentPanel);
            _inventoryItems.Add(item);
        }
    }

    public void SetActiveInventory(bool state)
    {
        gameObject.SetActive(state);
    }
}
