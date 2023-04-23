using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

[RequireComponent(typeof(NavMesh))]

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float radius = 15f;

    [SerializeField] private List<Transform> PatrolPosition;

    private NavMeshAgent agent;
    private float targetdistance;
    private int a;
    private bool IsOnRadius;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        targetdistance = Vector3.Distance(transform.position, target.transform.position);
        if (targetdistance < radius)
        {
            IsOnRadius = true;
            //agent.SetDestination(target.position);
        }
        else
            IsOnRadius = false;
        float dist = Vector3.Distance(agent.transform.position, agent.pathEndPosition);
        if (dist < 0.500001f)
            PatrolUpdate();
        agent.SetDestination(PatrolPosition[a].position);
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

#endif
    private void PatrolUpdate()
    {
        a = Random.Range(0, PatrolPosition.Count);
    }
}
