using UnityEngine;

namespace DefaultNamespace
{
    public class Enemy : MonoBehaviour
    {
        public Health _health;

        private void Update()
        {
            if (_health.IsDead)
            {
                //Die
            }
        }
    }
}