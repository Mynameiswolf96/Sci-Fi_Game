using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class Patrol : MonoBehaviour
{
    private NavMeshAgent agent;
    private FPSMovement player;
    [SerializeField] private Transform[] waypoints;
    private int m_CurrentWaypointIndex;
    // Start is called before the first frame update
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<FPSMovement>();
    }
    void Start()
    {
       agent.SetDestination(waypoints[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance<agent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            agent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
        }
        else {
            agent.SetDestination(player.transform.position);
        }
    }
}
