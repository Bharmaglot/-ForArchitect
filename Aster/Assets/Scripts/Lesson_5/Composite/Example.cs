using UnityEngine;

namespace Asteroids.Composite
{
    internal sealed class Example : MonoBehaviour
    {
        void Start()
        {
            IAttack attack = new Unit();
            Detachment attacks = new Detachment();
            attacks.AddUnit(attack);

            attack.Attack();
            attacks.Attack();

            attacks.RemoveUnit(attack);
        }
    }
}