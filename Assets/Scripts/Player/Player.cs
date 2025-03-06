using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public Health health;
        public Armor armor;
        

        private void Start()
        {
            health.OnDeath += Gameover;
        }

        private void Gameover()
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}