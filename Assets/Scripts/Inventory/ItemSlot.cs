using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
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

    public void OnPointerDown(PointerEventData eventData)
    {
        DragAndDrop.Instance.StartDragging(this);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        DragAndDrop.Instance.EndDragging(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.clickCount == 1 && item != null) 
        {
            itemInfoPanel.OpenItemInfoPanel(this);
        }
    }
}