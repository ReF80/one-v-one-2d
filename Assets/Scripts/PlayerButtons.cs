using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerButtons : MonoBehaviour
    {
        [SerializeField] public int damage;
        [SerializeField] private GameObject panelPistol;
        [SerializeField] private GameObject panelRifle;
        private Enemy _enemy;

        public void SelectPistolButton()
        {
            damage = 3;
            panelPistol.SetActive(true);
            panelRifle.SetActive(false);
        }

        public void SelectRifleButton()
        {
            damage = 9;
            panelRifle.SetActive(true);
            panelPistol.SetActive(false);
        }

        public void FireButton()
        {
            _enemy._health.Remove(damage);
        }

    }
}