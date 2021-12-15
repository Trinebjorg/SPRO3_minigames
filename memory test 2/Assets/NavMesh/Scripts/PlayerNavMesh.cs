using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
   private NavMeshAgent navMeshAgent;
   private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>(); // nMA reffrence
    }

    private void update()
    {
        navMeshAgent.destination = movePositionTransform.position; // Agent moving towards Transform
    }
}
