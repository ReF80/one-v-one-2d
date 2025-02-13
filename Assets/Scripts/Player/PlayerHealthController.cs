using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class PlayerHealthController : MonoBehaviour
    {
        [SerializeField] private Image bar;
        [SerializeField] private Text text;
        [SerializeField] public Player player;

        public void HealthController(float value,float maxValue)
        {
            bar.fillAmount = value / maxValue;
            text.text = value.ToString(CultureInfo.InvariantCulture);
        }
    }
}