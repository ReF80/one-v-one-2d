using UnityEngine;

namespace DefaultNamespace
{
    public class ItemInfoPanel : MonoBehaviour
    {
        public CreatePanel createPanel;
        public Player player;
        public ArmorController armorController;
        public ItemInfoButtons itemInfoButtons;
        public ItemData itemData;
        
        
        public void OpenItemInfoPanel(ItemData item, ItemSlot slot)
        {
            switch (item.type) 
            {
                case ItemData.ItemType.Ammo:
                    itemInfoButtons.OnClick += ActionAmmo;
                    break;
                case ItemData.ItemType.Armor:
                    itemInfoButtons.OnClick += ActionArmor;
                    break;
                case ItemData.ItemType.Medkit:
                    itemInfoButtons.OnClick += ActionMedkit;
                    break;
                case ItemData.ItemType.Helmet:
                    itemInfoButtons.OnClick += ActionHelmet;
                    break;
            }
            itemData = item;
            itemInfoButtons.Initialize(slot);
            createPanel.CreatePanel1(item);
        }
        
        private void ActionAmmo()
        {
            
        }

        private void ActionArmor()
        {
            player.armor.PutOn(itemData.value, itemData.type);
            armorController.BodyArmorTextController(itemData.value);
            itemInfoButtons.ExitButton();
        }

        private void ActionHelmet()
        {
            player.armor.PutOn(itemData.value, itemData.type);
            armorController.HeadArmorTextController(itemData.value);
            itemInfoButtons.ExitButton();
        }
        
        private void ActionMedkit()
        {
            player.health.Add(itemData.value);
            itemInfoButtons.DeletButton();
            itemInfoButtons.ExitButton();
        }
    }
}