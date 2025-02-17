using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class InventorySystem : MonoBehaviour
{
    public List<ItemData> items = new List<ItemData>(); 
    public List<ItemSlot> slots; 

    private void Start()
    {
        InitializeSlots();
        GenerateRandomItems(5); 
    }

    [Obsolete("Obsolete")]
    private void InitializeSlots()
    {
        if (slots == null || slots.Count == 0)
        {
            slots = new List<ItemSlot>(FindObjectsOfType<ItemSlot>());
        }

        foreach (var slot in slots)
        {
            slot.inventory = this;
        }
    }

    public void GenerateRandomItems(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int randomIndex = Random.Range(0, items.Count);
            ItemData newItem = items[randomIndex];
            
            bool placed = false;
            while (!placed)
            {
                int randomSlotIndex = Random.Range(0, slots.Count);

                if (slots[randomSlotIndex].item == null)
                {
                    slots[randomSlotIndex].SetItem(newItem);
                    placed = true;
                }
            }
        }
    }

    public void SwapItems(ItemSlot slotA, ItemSlot slotB)
    {
        ItemData temp = slotA.item;
        // if (slotA.item.type == slotB.item.type && slotA.item.stack + slotB.item.stack < slotB.item.maxStack)
        // {
        //     slotB.SetItem(temp);
        //     slotB.item.stack += temp.stack;
        // }
        // else
        // {
        slotA.SetItem(slotB.item);
        slotB.SetItem(temp);
        //}
    }
}