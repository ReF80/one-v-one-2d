using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Enemy : MonoBehaviour
    {
        public Health health;
        public EnemyHealthController enemyHealthController;
        public InventorySystem inventorySystem;
        private int maxHealth = 100;
        public event Action OnRespawn;

        private void Start()
        {
            health.OnDeath += HandleRespawn;
        }

        private void HandleRespawn()
        {
            if (OnRespawn != null)
            {
                RespawnLogic();
            }
        }
        
        private void RespawnLogic()
        {
            health.Add(maxHealth);
            enemyHealthController.HealthController(health.Value, health.MaxValue);
            inventorySystem.GenerateRandomItems(1);
            health.IsDead = false;
        }
        // private void Update()
        // {
        //     if (health.IsDead)
        //     {
        //         health.Add(maxHealth);
        //         enemyHealthController.HealthController(health.Value, health.MaxValue);
        //         inventorySystem.GenerateRandomItems(1);
        //         health.IsDead = false;
        //     }
        // }
    }
}