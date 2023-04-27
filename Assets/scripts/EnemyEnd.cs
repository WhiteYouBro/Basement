using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnd : MonoBehaviour
{
    private EnemyMover EnemyMover;

    private void Awake()
    {
        EnemyMover = FindObjectOfType<EnemyMover>();
    }
    private void OnTriggerEnter(Collider other)
    {
        EnemyMover.IsEnd = true;
    }
}
