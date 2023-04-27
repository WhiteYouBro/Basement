using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private EnemyMover mover;

    private InteractiveSystem InteractiveSystem;

    private void Awake()
    {
        InteractiveSystem = FindObjectOfType<InteractiveSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(InteractiveSystem != null)
        {
            mover.isdeath = true;
            Invoke("EndGame", 2);
        }
    }

    private void EndGame()
    {
        InteractiveSystem.Death();
    }
}
