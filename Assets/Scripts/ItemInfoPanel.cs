using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ItemInfoPanel : MonoBehaviour
    {
        [SerializeField] public GameObject panel;
        [SerializeField] public Image image;
        [SerializeField] public Image imageAtribute;
        [SerializeField] public Text buttonText;
        [SerializeField] public Text textWeight;
        [SerializeField] public Text textName;
        [SerializeField] public Text textValue;
        public Player player;
        public ItemInfoButtons itemInfoButtons;
        public ItemData itemData;
        public ItemSlot itemSlot;
        
        public void OpenItemInfoPanel(ItemData item, ItemSlot slot)
        {
            switch (itemData.type)
            {
                case ItemData.ItemType.Ammo:
                    itemInfoButtons.OnClick += ActionAmmo;
                    break;
                case ItemData.ItemType.Armor:
                    itemInfoButtons.OnClick += ActionArmorAndHelmet;
                    break;
                case ItemData.ItemType.Medkit:
                    itemInfoButtons.OnClick += ActionMedkit;
                    break;
                case ItemData.ItemType.Helmet:
                    itemInfoButtons.OnClick += ActionArmorAndHelmet;
                    break;
            }
            itemData = item;
            itemSlot = slot;
            CreatePanel(item);
        }

        private void CreatePanel(ItemData item)
        {
            panel.SetActive(true);
            buttonText.text = item.btnAction;
            image.sprite = item.icon;
            imageAtribute.sprite = item.iconAtribute;
            textName.text = item.name;
            textWeight.text = item.weight.ToString(CultureInfo.CurrentCulture);
            textValue.text = item.value.ToString();
        }
        
        private void ActionAmmo()
        {
            
        }

        private void ActionArmorAndHelmet()
        {
            player.armor.PutOn(itemData.value, itemData.type);
        }

        private void ActionMedkit()
        {
            player.health.Add(itemData.value);
        }
    }
}