using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ItemInfoButtons : MonoBehaviour
    {
        [SerializeField] public GameObject panel;
        
        public void DeletButton()
        {
            
        }

        public void ActionButton()
        {
            
        }

        public void ExitButton()
        {
            panel.SetActive(false);
        }
    }
}