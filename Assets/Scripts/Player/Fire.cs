using DefaultNamespace;
using UnityEngine;


    public class Fire : MonoBehaviour
    {
        [SerializeField] public Enemy enemy;
        [SerializeField] public EnemyHealthController healthBar;

        public void TakeDamage(int damage)
        {
            enemy.health.Remove(damage);
            healthBar.HealthController(enemy.health.Value, enemy.health.MaxValue);
        }
    }
