using UnityEngine;
public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    public GameObject inventoryUI;
    Inventory inventory;
    InventorySlot[] slots;
    void Start()
    {
        inventory = Inventory.instance;
        inventory.OnItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }
    void UpdateUI()
    {
        Debug.Log("Updating UI");
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}