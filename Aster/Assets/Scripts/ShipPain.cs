using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class ShipPain
    {
        private float _hp;
        private GameObject _shipObject;

        public ShipPain(float hp, GameObject shipObject)
        {
            _hp = hp;
            _shipObject = shipObject;
            
        }



        public void ShipDamage(GameObject _shipObject)
        {
            if (_hp <= 0)
            {
                UnityEngine.Object.Destroy(_shipObject);
            }
            else
            {
                _hp--;
            }
        }
    }
}