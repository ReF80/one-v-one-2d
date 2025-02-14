using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public Health health;

        private void Update()
        {
            if (health.IsDead)
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
    }
}