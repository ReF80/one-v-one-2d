using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Armor 
    {
        public Text HeadText; 
        public Text BodyText; 
        public int headArmor { get; private set; } = 0;
        public int bodyArmor { get; private set; } = 0;
        
        public void PutOn(int value, ItemData.ItemType type)
        {
            switch (type)
            {
                case ItemData.ItemType.Helmet:
                    HeadArmor(value);
                    break;
                case ItemData.ItemType.Armor:
                    BodyArmor(value);
                    break;
            }
        }

        private void HeadArmor(int value)
        {
            headArmor = value;
            HeadText.text = headArmor.ToString();
        }

        private void BodyArmor(int value)
        {
            bodyArmor = value;
            BodyText.text = bodyArmor.ToString();
        }
    }
}