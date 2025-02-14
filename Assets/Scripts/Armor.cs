using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Armor : MonoBehaviour
    {
        [SerializeField] public Text HeadText;
        [SerializeField] public Text BodyText;
        [SerializeField] public int headArmor = 0;
        [SerializeField] public int bodyArmor = 0;
        public bool hasHeadArmor = false;
        public bool hasBodyArmor = false;
        
        public void PutOn(int value, string type)
        {
            switch (type)
            {
                case "Helmet":
                    headArmor += value;
                    HeadText.text = headArmor.ToString();
                    break;
                case "Armor":
                    bodyArmor += value;
                    BodyText.text = bodyArmor.ToString();
                    break;
            }
        }

        public void TakeOff(int value, string type)
        {
            switch (type)
            {
                case "Helmet":
                    headArmor -= value;
                    HeadText.text = "0";
                    break;
                case "Armor":
                    bodyArmor -= value;
                    BodyText.text = "0";
                    break;
            }
        }
    }
}