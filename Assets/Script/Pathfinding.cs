using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{
    public Transform[] points;

    private NavMeshAgent navMeshAgent;
    private int destPoint;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance < 0.5f)
        {
            GoToNextPoint();
        }    
    }

    void GoToNextPoint()
    {
        if (points.Length == 0) return;

        navMeshAgent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }
}
