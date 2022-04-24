using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCharachter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform spawnpoint;
    [SerializeField] private Bullet bulletPrefab;
    private float step = 1f;
    private float nextShot;
    void Update()
    {
        
        if (!(Time.time > nextShot))
        {
            return;
        }
        nextShot = Time.time + step;
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
        
    }
    private void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, spawnpoint.position, spawnpoint.rotation);
    }
}
