using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
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