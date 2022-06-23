using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public sealed class WeaponFire
    {

        private readonly Rigidbody2D _bullet;
        private readonly Transform _barrel;
        private readonly float _force;

        public WeaponFire(Rigidbody2D bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
        }

        public void WeaponAttack(Rigidbody2D bullet, Transform barrel, float force)
        {
            var temAmmunution = UnityEngine.Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunution.AddForce(_barrel.up * _force);
        }


        //Не смог понять реализацию - что из Player подается в качестве viewServices, если, конечно, вызывается из него.
        //private readonly Rigidbody2D _prefabBullet;
        //private readonly IViewServices _viewServices;

        //public WeaponFire(Rigidbody2D prefabBullet, IViewServices viewServices)
        //{
        //    _prefabBullet = prefabBullet;
        //    _viewServices = viewServices;
        //}


        //public void WeaponAttack()
        //{
        //    var bullet = _viewServices.Instantiate<Rigidbody2D>(_prefabBullet.gameObject);
        //    bullet.AddForce(Vector3.forward);
        //}
    }
}