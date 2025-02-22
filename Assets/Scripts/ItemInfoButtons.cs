using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ItemInfoButtons : MonoBehaviour
    {
        [SerializeField] public GameObject panel;
        private Player player;
        private ItemInfoPanel item;
        
        public event Action OnClick;
        
        public void ActionButton()
        {
            OnClick?.Invoke();
        }
        
        public void DeletButton()
        {
            item.itemSlot.RemoveItem();
        }
        
        public void ExitButton()
        {
            OnClick = null;
            panel.SetActive(false);
        }
    }
}