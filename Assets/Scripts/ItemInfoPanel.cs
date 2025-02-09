using UnityEngine;

namespace DefaultNamespace
{
    public class ItemInfoPanel : MonoBehaviour
    {
        public string buttonActionText;
        
        public void OpenItemInfoPanel(ItemSlot slot)
        {
            switch (slot.item.type)
            {
                case ItemData.ItemType.Ammo:
                    //Action
                    break;
                case ItemData.ItemType.Armor:
                    //Action
                    break;
                case ItemData.ItemType.Medkit:
                    //Action
                    break;
                case ItemData.ItemType.Helmet:
                    //Action
                    break;
            }
        }
    }
}