using Asteroids.Object_pool;
using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);



            IEnemyFactory factoryKamikadze = new KamikadzeFactory();
            factoryKamikadze.Create(new Health(100.0f, 100.0f));

            Enemy.CreateBattleShipEnemy(new Health(100.0f, 100.0f));
        }
    }
}
