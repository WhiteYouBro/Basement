using UnityEngine;
using UnityEngine.UI;

public class PickableObject : MonoBehaviour
{
    [SerializeField] private Image HandImage;

    private bool OnTrigger;

    private InteractiveSystem InteractiveSystem;
    private void Awake()
    {
        InteractiveSystem = FindObjectOfType<InteractiveSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        OnTrigger = true;
        HandImage.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(InteractiveSystem.InteractiveKeys[1]) && OnTrigger)
        {
            Destroy(gameObject);
            InteractiveSystem.IsOrangeKey = true;   
            HandImage.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        OnTrigger = false;
        HandImage.gameObject.SetActive(false);
    }

}
