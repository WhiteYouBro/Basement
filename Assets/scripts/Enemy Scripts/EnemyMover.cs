using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

[RequireComponent(typeof(NavMesh))]

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float radius = 15f;

    [SerializeField] private List<Transform> PatrolPosition;

    [SerializeField] private Transform endpos;

    private NavMeshAgent agent;
    private float targetdistance;
    private int a;
    private bool IsOnRadius;
    private Animator animator;
    private AudioSource source;

    public bool IsEnd;

    [HideInInspector] public bool isdeath;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (animator != null)
            if (isdeath)
            {
                source.Stop();
                animator.SetBool("isattack", true);
            }
            targetdistance = Vector3.Distance(transform.position, target.transform.position);
            if (targetdistance < radius)
            {
                agent.speed += 2;
                IsOnRadius = true;
                agent.SetDestination(target.position);
            }
            else
                IsOnRadius = false;
        //if (Time.timeSinceLevelLoad >= 60 && !IsEnd)
        if(!IsEnd)
        {
            if (animator != null)
                 animator.SetBool("iswalking", true);
            float dist = Vector3.Distance(agent.transform.position, agent.pathEndPosition);
            if (dist < 2f)
                PatrolUpdate();
            if (!IsOnRadius)
                agent.SetDestination(PatrolPosition[a].position);
        }
        if (IsEnd)
        {
            transform.position = endpos.position;
            radius = 100;
            agent.speed = 6;
        }
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
