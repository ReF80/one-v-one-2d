using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ItemInfoButtons : MonoBehaviour
    {
        [SerializeField] public GameObject panel;
        private Player player;
        private ItemInfoPanel item;
        private ItemSlot thisSlot;
        public void Initialize(ItemSlot slot)
        {
            thisSlot = slot;
        }

        public event Action OnClick;
        
        public void ActionButton()
        {
            OnClick?.Invoke();
        }
        
        public void DeletButton()
        {
            thisSlot.RemoveItem();
        }
        
        public void ExitButton()
        {
            OnClick = null;
            panel.SetActive(false);
        }
    }
}