using System;
using UnityEngine;


namespace DefaultNamespace
{
    public class Enemy : MonoBehaviour
    {
        public Health health;
        public EnemyHealthController enemyHealthController;
        public InventorySystem inventorySystem;

        private void Start()
        {
            health.OnDeath += RespawnLogic;
        }
        
        private void RespawnLogic()
        {
            health.SetMaxValue();
            enemyHealthController.HealthController(health.Value, health.MaxValue);
            inventorySystem.GenerateRandomItems(1);
            health.IsDead = false;
        }
    }
}