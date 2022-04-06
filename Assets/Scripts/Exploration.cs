using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shoot
{
    public class Exploration : MonoBehaviour
    {
        private float Radius=10f;
        private float Force=500f;
        private void Start()
        {
            Explode();
               
        }

        // Start is called before the first frame update
        public void Explode()
        {
            Collider[] overlappedColliders = Physics.OverlapSphere(transform.position, Radius);
            for (int i = 0; i < overlappedColliders.Length; i++)
            {
                Rigidbody rigidbody = overlappedColliders[i].attachedRigidbody;
                if (rigidbody)
                {
                    rigidbody.AddExplosionForce(Force, transform.position, Radius);
                }
            }
        }
    }

}