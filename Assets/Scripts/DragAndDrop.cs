using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    public static DragAndDrop Instance;

    private ItemSlot draggedSlot;
    private GameObject dragIcon; // Клон иконки для перетаскивания
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

    private void Update()
    {
        if (dragIcon != null)
        {
            GetWorldPosition(Input.mousePosition);
        }
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

        // Если найден целевой слот, меняем предметы местами
        if (targetSlot != null)
        {
            draggedSlot.inventory.SwapItems(draggedSlot, targetSlot);
        }
        else
        {
            // Если целевой слот не найден, возвращаем предмет обратно
            draggedSlot.SetItem(draggedSlot.item);
        }

        draggedSlot = null;
    }
    
    private void GetWorldPosition(Vector3 screenPosition)
    {
        Vector2 localPosition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvasRect, // RectTransform канваса
                screenPosition, // Позиция курсора на экране
                canvas.worldCamera, // Камера канваса (обычно null для Screen Space - Overlay)
                out localPosition)) // Выходные локальные координаты
        {
            // Устанавливаем позицию клона в локальных координатах канваса
            dragIcon.transform.localPosition = localPosition;
        }
    }
}