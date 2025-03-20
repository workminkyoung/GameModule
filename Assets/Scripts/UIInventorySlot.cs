using UnityEngine;


/// <summary>
/// 인벤토리 슬롯: 특정 아이템과 개수를 관리
/// </summary>
[System.Serializable]
public class InventorySlot
{
    public Item item;
    public int quantity;

    public InventorySlot(Item item, int quantity)
    {
        this.item = item;
        this.quantity = quantity;
    }

    /// <summary>
    /// 아이템 추가 시 최대 개수 초과 여부 확인
    /// </summary>
    public bool CanAddMore(int amount) => (quantity + amount) <= item.maxStack;
}
