using UnityEngine;
using UnityEngine.UI;

public class PickableObject : MonoBehaviour
{
    [SerializeField] private Image HandImage;

    private InteractiveSystem InteractiveSystem;
    private void Awake()
    {
        InteractiveSystem = FindObjectOfType<InteractiveSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        HandImage.enabled = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(InteractiveSystem.InteractiveKeys[1]))
        {
            Destroy(gameObject);
            InteractiveSystem.Items.Add(gameObject.name);   
            HandImage.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        HandImage.enabled = false;
    }

}
