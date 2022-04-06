using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace Shoot
{
    public class WayPointPatrol : MonoBehaviour
    {
        private NavMeshAgent agent;
        private FPSMovement player;
        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            player = FindObjectOfType<FPSMovement>();
        }
        private void Update()
        {
            agent.SetDestination(player.transform.position);
        }
    }

}
