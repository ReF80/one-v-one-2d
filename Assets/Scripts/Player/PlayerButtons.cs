using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class PlayerButtons : MonoBehaviour
    {
        [SerializeField] public int damage;
        [SerializeField] private GameObject panelPistol;
        [SerializeField] private GameObject panelRifle;
        //private Fire fire;

        public void SelectPistolButton()
        {
            damage = 5;
            panelPistol.SetActive(true);
            panelRifle.SetActive(false);
        }

        public void SelectRifleButton()
        {
            damage = 9;
            panelRifle.SetActive(true);
            panelPistol.SetActive(false);
        }

        public void FireButton(Fire fire)
        {
            fire.TakeDamage(damage);
        }
    }
}