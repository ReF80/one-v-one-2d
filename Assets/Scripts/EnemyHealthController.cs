using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class EnemyHealthController : MonoBehaviour
    {
        [SerializeField] public Image bar;
        [SerializeField] public Text text;

        public void HealthController(float value,float maxValue)
        {
            bar.fillAmount = value / maxValue;
            text.text = value.ToString(CultureInfo.InvariantCulture);
        }
    }
}