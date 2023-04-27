using UnityEngine;
using UnityEngine.UI;

public class Lever : MonoBehaviour
{
    [SerializeField] private Image HandImage;

    [SerializeField] private GameObject LeverUp;
    [SerializeField] private GameObject LeverDown;

    [SerializeField] InteractiveSystem interactiveSystem;

    private bool OnTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print(gameObject.name);
            OnTrigger = true;
            HandImage.gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        if (OnTrigger)
        {
            if (Input.GetKeyDown(interactiveSystem.InteractiveKeys[1]))
            {
                LeverUp.SetActive(false);
                //interactiveSystem.IsActivatedLever = true;
                //звук сюда
                LeverDown.SetActive(true);
            }
            HandImage.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print(gameObject.name);
        OnTrigger = false;
        HandImage.gameObject.SetActive(false);
    }

}
