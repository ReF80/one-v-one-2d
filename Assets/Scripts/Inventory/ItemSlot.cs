using System.Collections;
using DefaultNamespace;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public InventorySystem inventory;
    public ItemInfoPanel itemInfoPanel;
    public ItemData item; 
    public Image iconImage;
    private const float holdThreshold = 0.5f;
    private Coroutine holdCoroutine; 
    private bool isDragging = false;
    private bool hasDragged = false;

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
        holdCoroutine = StartCoroutine(TrackHold());
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        if(hasDragged) return;
        hasDragged = true;
        DragAndDrop.Instance.StartDragging(this);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
        if (holdCoroutine != null)
        {
            StopCoroutine(holdCoroutine);
            holdCoroutine = null;
        }
        if (!isDragging)
        {
            itemInfoPanel.OpenItemInfoPanel(this);
        }
        else
        {
            DragAndDrop.Instance.EndDragging(this);
        }
        isDragging = false;
        hasDragged = false;
    }
    
    private IEnumerator TrackHold()
    {
        float holdTime = 0f;

        while (true)
        {
            yield return null; 
            holdTime += Time.unscaledDeltaTime;
            
            if (holdTime >= holdThreshold)
            {
                isDragging = true;
                break;
            }
        }
    }
}