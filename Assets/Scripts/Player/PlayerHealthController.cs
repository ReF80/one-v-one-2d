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

        public void HealthBar()
        {
            bar.fillAmount = player.health.Value / player.health.MaxValue;
            text.text = player.health.Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}