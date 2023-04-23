using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [Tooltip("1 is for orange key; 2 is for blue key; 3 is for red key; 4 is for lever")]
    [Range(1, 3)][SerializeField] private int WhichKey;

    [SerializeField] private InteractiveSystem interactiveSystem;

    void Update()
    {
        if (WhichKey == 1)
        {
            if (interactiveSystem.IsOrangeKey)
            {
                Destroy(gameObject, 1);
            }
        }

        else if (WhichKey ==  4)
        {
            if(interactiveSystem.IsActivatedLever)
            {
                Destroy(gameObject, 1);
            }
        }
    }
}
