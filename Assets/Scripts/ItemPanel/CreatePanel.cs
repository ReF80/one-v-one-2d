using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class CreatePanel : MonoBehaviour
    {
        [SerializeField] public GameObject panel;
        [SerializeField] public Image imageItem;
        [SerializeField] public Image imageAtribute;
        [SerializeField] public Text buttonText;
        [SerializeField] public Text textWeight;
        [SerializeField] public Text textName;
        [SerializeField] public Text textValue;
        
        public void CreatePanel1(ItemData item)
        {
            panel.SetActive(true);
            buttonText.text = item.btnAction;
            imageItem.sprite = item.icon;
            imageAtribute.sprite = item.iconAtribute;
            textName.text = item.name;
            textWeight.text = item.weight.ToString(CultureInfo.CurrentCulture);
            textValue.text = item.value.ToString();
        }
    }
}