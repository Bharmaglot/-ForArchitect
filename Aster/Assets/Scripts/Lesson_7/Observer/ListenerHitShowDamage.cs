using UnityEngine;

namespace BehavioralPatterns.Observer.ExampleFirst
{
    public sealed class ListenerHitShowDamage
    {
        public void Add(IHit value)
        {
            value.OnHitChange += ValueOnHitChange;
        }

        public void Remove(IHit value)
        {
            value.OnHitChange -= ValueOnHitChange;
        }

        private void ValueOnHitChange(float damage)
        {
            Debug.Log(damage);
        }
    }
}
