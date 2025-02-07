using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        private Health _health;

        private void Update()
        {
            if (_health.IsDead)
            {
                //Die
            }
        }
    }
}