using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteEnable : MonoBehaviour
{
    [SerializeField] private GameObject triggernote;

    private void OnTriggerEnter(Collider other)
    {
        triggernote.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        triggernote.SetActive(false);
    }
}
