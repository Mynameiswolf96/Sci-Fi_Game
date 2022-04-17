using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject obj;
    public string NameTrigger;
    public float damage = 3f;
    public float speed = 5f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Health health))
        {
            health.Hit(damage);
        }
        if(collision.gameObject.TryGetComponent(out Rigidbody rigidbody))
        {
            rigidbody.AddForce(transform.forward * speed, ForceMode.VelocityChange);
            rigidbody.AddForce(transform.up * speed, ForceMode.VelocityChange);
        }
    }
}
