using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public Health health;

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