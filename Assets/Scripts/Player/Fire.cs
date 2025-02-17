using System.Collections;
using DefaultNamespace;
using UnityEngine;

public class Fire : MonoBehaviour
    {
        [SerializeField] public Enemy enemy;
        [SerializeField] public Player player;
        [SerializeField] public Armor armor;
        [SerializeField] public EnemyHealthController enemyBar;
        [SerializeField] public PlayerHealthController playerBar;
        [SerializeField] private int enemyDamage = 15;
        private bool state = false;
        
        public void TakeDamage(int damage)
        {
            enemy.health.Remove(damage);
            enemyBar.HealthController(enemy.health.Value, enemy.health.MaxValue);
            StartCoroutine(TakeDamagePlayer());
        }

        private IEnumerator TakeDamagePlayer()
        {
            yield return new WaitForSeconds(1);
            if (state)
            {
                player.health.Remove(enemyDamage - armor.bodyArmor);
                state = false;
            }
            else
            {
                player.health.Remove(enemyDamage - armor.headArmor);
                state = true;
            }
            
            playerBar.HealthController(player.health.Value, player.health.MaxValue);
        }
    }
