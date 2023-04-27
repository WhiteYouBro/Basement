using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [Tooltip("1 is for orange key; 2 is for blue key; 3 is for red key; 4 is for yellow key")]
    [Range(1, 4)][SerializeField] private int WhichKey;

    [SerializeField] private InteractiveSystem interactiveSystem;

    [SerializeField] private AudioClip clip;

    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (WhichKey == 1)
        {
            if (interactiveSystem.IsOrangeKey)
            {
                if (source != null)
                    source.PlayOneShot(clip);
                Destroy(gameObject, 1);
            }
        }

        else if (WhichKey == 2)
        {
            if(interactiveSystem.IsBlueKey)
            {
                if (source != null)
                    source.PlayOneShot(clip);
                Destroy(gameObject);
            }
        }

        else if (WhichKey == 3)
        {
            if(interactiveSystem.IsRedKey)
            {
                if (source != null)
                    source.PlayOneShot(clip);
                Destroy(gameObject);
            }
        }

        else if (WhichKey == 4)
        {
            if (interactiveSystem.IsYellowKey)
            {
                if (source != null)
                    source.PlayOneShot(clip);
                Destroy(gameObject);
            }
        }


    }
}
