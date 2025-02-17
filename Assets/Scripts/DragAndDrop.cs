using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    public static DragAndDrop Instance;

    private ItemSlot draggedSlot;
    private GameObject dragIcon; 
    private Canvas canvas;
    private RectTransform canvasRect;
    private void Awake()
    {
        Instance = this;
        canvas = FindObjectOfType<Canvas>();
        canvasRect = canvas.transform as RectTransform;
    }

    public void StartDragging(ItemSlot slot)
    {
        if (slot == null || slot.item == null) return;

        draggedSlot = slot;
        
        dragIcon = new GameObject("DragIcon");
        dragIcon.transform.SetParent(canvas.transform, false);
        dragIcon.AddComponent<RectTransform>().sizeDelta = new Vector2(64, 64); 
        dragIcon.AddComponent<Image>().sprite = draggedSlot.item.icon;
        GetWorldPosition(Input.mousePosition);
    }
    
    public void EndDragging(ItemSlot targetSlot)
    {
        if (dragIcon != null)
        {
            Destroy(dragIcon);
        }

        if (draggedSlot == null) return;
        
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);
        targetSlot = null;
        foreach (RaycastResult result in results)
        {
            targetSlot = result.gameObject.GetComponentInParent<ItemSlot>();
            if (targetSlot != null && targetSlot != draggedSlot)
            {
                break;
            }
        }

        if (targetSlot != null)
        {
            draggedSlot.inventory.SwapItems(draggedSlot, targetSlot);
        }
        else
        {
            draggedSlot.SetItem(draggedSlot.item);
        }

        draggedSlot = null;
    } 
    
    public void GetWorldPosition(Vector3 screenPosition)
    {
        Vector2 localPosition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvasRect, 
                screenPosition, 
                canvas.worldCamera,
                out localPosition)) 
        {
            dragIcon.transform.localPosition = localPosition;
        }
    }
}