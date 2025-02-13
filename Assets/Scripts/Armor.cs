using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Armor
    {
        [SerializeField] public Text HeadText;
        [SerializeField] public Text BodyText;
        [SerializeField] public int HeadArmor = 0;
        [SerializeField] public int BodyArmor = 0;
        public bool HasHeadArmor = false;
        public bool HasBodyArmor = false;
        
        
        
        public void PutOn(int value, string type)
        {
            switch (type)
            {
                case "Helmet":
                    HeadArmor += value;
                    HeadText.text = HeadArmor.ToString();
                    break;
                case "Armor":
                    BodyArmor += value;
                    BodyText.text = BodyArmor.ToString();
                    break;
            }
        }

        public void TakeOff(int value, string type)
        {
            switch (type)
            {
                case "Helmet":
                    HeadArmor -= value;
                    HeadText.text = "0";
                    break;
                case "Armor":
                    BodyArmor -= value;
                    BodyText.text = "0";
                    break;
            }
        }
    }
}