using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ItemInfoPanel : MonoBehaviour
    {
        [SerializeField] private string buttonActionText;
        [SerializeField] public GameObject panel;
        [SerializeField] public Image image;
        [SerializeField] public Image imageAtribute;
        [SerializeField] public Text buttonText;
        [SerializeField] public Text textWeight;
        [SerializeField] public Text textName;
        [SerializeField] public Text textValue;
        public void OpenItemInfoPanel(ItemSlot slot)
        {
            switch (slot.item.type)
            {
                case ItemData.ItemType.Ammo:
                    buttonActionText = "Купить";
                    CreatePanel(buttonActionText, slot);
                    break;
                case ItemData.ItemType.Armor:
                    buttonActionText = "Экипировать";
                    CreatePanel(buttonActionText, slot);
                    break;
                case ItemData.ItemType.Medkit:
                    buttonActionText = "Лечить";
                    CreatePanel(buttonActionText, slot);
                    break;
                case ItemData.ItemType.Helmet:
                    buttonActionText = "Экипировать";
                    CreatePanel(buttonActionText, slot);
                    break;
            }
        }

        private void CreatePanel(string actionText, ItemSlot slot)
        {
            panel.SetActive(true);
            buttonText.text = actionText;
            image.sprite = slot.item.icon;
            imageAtribute.sprite = slot.item.iconAtribute;
            textName.text = slot.item.name;
            textWeight.text = slot.item.weight.ToString(CultureInfo.CurrentCulture);
            textValue.text = slot.item.value.ToString();
        }
    }
}