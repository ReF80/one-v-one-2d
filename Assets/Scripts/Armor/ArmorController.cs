using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ArmorController : MonoBehaviour
    {
        public Text HeadText; 
        public Text BodyText;

        public void HeadArmorTextController(int value) => HeadText.text = value.ToString();
        public void BodyArmorTextController(int value) => BodyText.text = value.ToString();
    }
}