using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform spawnpoint;
    [SerializeField] private Bullet bulletPrefab;
    private FindTarget target;
    private float step = 1f;
    private float nextShot;
    private float AddForce = 15f;
    // Update is called once per frame
    private void Start()
    {
        target = GetComponent<FindTarget>();
    }
    void Update()
    {
        if (!target.HasTarget)
        {
            return;
        }
        if (!(Time.time > nextShot))
        {
            return;
        }
        nextShot = Time.time + step;
        Shoot();
    }
    private void Shoot()
    {
        var bullet = Instantiate(bulletPrefab,spawnpoint.position,Quaternion.identity);
    }
}
