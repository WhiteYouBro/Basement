using System.Collections;
using System.Collections.Generic;
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
        print("on trigger");
        OnTrigger = true;
        HandImage.enabled = true;
    }

    private void Update()
    {
        if (OnTrigger)
        {
            if (Input.GetKeyDown(interactiveSystem.InteractiveKeys[1]))
            {
                LeverUp.SetActive(false);
                interactiveSystem.IsActivatedLever = true;
                //звук сюда
                LeverDown.SetActive(true);
            }
            HandImage.enabled = true;
        }

        else
            HandImage.enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        OnTrigger = false;
        HandImage.enabled = false;
    }

}
