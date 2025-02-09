using UnityEngine;

namespace DefaultNamespace
{
    public class Enemy : MonoBehaviour
    {
        public Health health;

        private void Update()
        {
            if (health.IsDead)
            {
                //Die
            }
        }
    }
}