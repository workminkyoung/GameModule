using UnityEngine;


/// <summary>
/// �κ��丮 ����: Ư�� �����۰� ������ ����
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
    /// ������ �߰� �� �ִ� ���� �ʰ� ���� Ȯ��
    /// </summary>
    public bool CanAddMore(int amount) => (quantity + amount) <= item.maxStack;
}
