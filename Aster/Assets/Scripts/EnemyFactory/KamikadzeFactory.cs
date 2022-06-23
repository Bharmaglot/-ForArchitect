using UnityEngine;

namespace Asteroids
{
    internal sealed class KamikadzeFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Kamikadze>("Enemy/Kamikadze"));

            enemy.DependencyInjectHealth(hp);

            return enemy;
        }
    }
}