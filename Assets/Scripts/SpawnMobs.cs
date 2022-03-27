using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMobs : MonoBehaviour
{
    [SerializeField] private float spawn;
    [SerializeField] private GameObject _prefab;
    private Vector3 spawnPosition = new Vector3(10f, 0f, 0f);
   void Start()
    {
        
       _prefab.transform.position = spawnPosition;
        StartCoroutine(Spawner());
    }
    private IEnumerator Spawner()
    {
        Instantiate(_prefab);
        yield return new WaitForSeconds(spawn);
        StartCoroutine(Spawner());
    }
    // Update is called once per frame
}
