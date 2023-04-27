using UnityEngine;
using UnityEngine.UI;

public class PickableObject : MonoBehaviour
{
    [SerializeField] private Image HandImage;

    private bool OnTrigger;

    private InteractiveSystem InteractiveSystem;

    [SerializeField] private bool IsRedKey;
    [SerializeField] private bool IsYellowKey;
    [SerializeField] private bool IsBlueKey;
    [SerializeField] private bool IsOrangeKey;

    private bool whatiskey;



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
            HandImage.enabled = false;
            if (IsYellowKey)
                InteractiveSystem.IsYellowKey = true;
            else if (IsBlueKey)
                InteractiveSystem.IsBlueKey = true;
            else if (IsRedKey)
                InteractiveSystem.IsRedKey = true;
            else if (IsOrangeKey)
                InteractiveSystem.IsOrangeKey = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        OnTrigger = false;
        HandImage.gameObject.SetActive(false);
    }

}
