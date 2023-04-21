using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NoteSystem : MonoBehaviour
{
    [Header("Put in inspector same names that have this variables")]
    [SerializeField] private TMP_Text textForInteract;
    [SerializeField] private TMP_Text noteTextUI;
    [SerializeField] private Image noteImage;

    [SerializeField] private string noteText;
    [SerializeField] private AudioClip noteSound;

    private InteractiveSystem interactiveSystem;
    private bool isActiveSystem;
    private AudioSource noteSource;

    private void Awake()
    {
        noteSource = GetComponent<AudioSource>();
        interactiveSystem = FindObjectOfType<InteractiveSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        isActiveSystem = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (!noteImage.gameObject.activeSelf)
        {
            noteSource.PlayOneShot(noteSound);
        }
        isActiveSystem = false;
    }

    private void Update()
    {
        NoteSystemCheck();
    }

    private void NoteSystemCheck()
    {
        if (isActiveSystem)
        {
            textForInteract.gameObject.SetActive(true);

            if (Input.GetKeyDown(interactiveSystem.InteractiveKeys[1]))
            {
                if (noteImage.gameObject.activeSelf)
                {
                    noteImage.gameObject.SetActive(false);
                    noteSource.PlayOneShot(noteSound);
                }
                else
                {
                    noteTextUI.text = noteText;
                    noteImage.gameObject.SetActive(true);
                    noteSource.PlayOneShot(noteSound);
                }
            }
        }
        else
        {
            noteImage.gameObject.SetActive(false);
            textForInteract.gameObject.SetActive(false);
        }
    }
}