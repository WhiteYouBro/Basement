using UnityEngine;
using UnityEngine.AI;
using System;
using System.Collections;

[RequireComponent(typeof(NavMesh))]

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float radius = 15f;

    [SerializeField] private Transform[] PatrolPosition;


    private NavMeshAgent agent;
    private float targetdistance;

    private bool IsOnRadius;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        StartCoroutine(Patrol());
    }

    private void Update()
    {
        targetdistance = Vector3.Distance(transform.position, target.transform.position);
        if (targetdistance < radius)
        {
            IsOnRadius = true;
            agent.SetDestination(target.position);
        }
        else
            IsOnRadius = false;
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
#endif
    IEnumerator Patrol()
    {
        foreach (Transform t in PatrolPosition)
        {
            while (!IsOnRadius)
            {
                agent.SetDestination(t.position);
                yield return t;
            }
        }        
    }
}
