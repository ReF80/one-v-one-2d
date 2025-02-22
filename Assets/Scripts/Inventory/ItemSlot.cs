using System.Collections;
using DefaultNamespace;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler, IPointerClickHandler//IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public InventorySystem inventory;
    public ItemInfoPanel itemInfoPanel;
    public ItemData item; 
    public Image iconImage;

    public void SetItem(ItemData newItem)
    {
        item = newItem;
        if (newItem != null)
        {
            iconImage.sprite = newItem.icon;
            iconImage.GetComponent<Image>().color = new Color32(255,255,225,255);
            iconImage.enabled = true;
        }
        else
        {
            iconImage.sprite = null;
            iconImage.enabled = true;
            iconImage.GetComponent<Image>().color = new Color32(255,255,225,0);
        }
    }

    public void RemoveItem()
    {
        iconImage.sprite = null;
        iconImage.enabled = true;
        iconImage.GetComponent<Image>().color = new Color32(255,255,225,0);
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        DragAndDrop.Instance.StartDragging(this);
        iconImage.sprite = null;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        DragAndDrop.Instance.EndDragging(this);
    }

    public void OnDrag(PointerEventData eventData)
    {
        DragAndDrop.Instance.GetWorldPosition(Input.mousePosition);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        itemInfoPanel.OpenItemInfoPanel(item, this);
    }
}