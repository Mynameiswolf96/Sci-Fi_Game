using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    private void Update()
    {
        if (!target)
        {
            return;
        }
        transform.rotation=Quaternion.LookRotation(target.position - transform.position);

    }
}
