using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractiveSystem : MonoBehaviour
{
    [SerializeField] private Light Flashlight;

    [Tooltip("0 to Flashlight Key, 1 to Interact Key")]
    [SerializeField] private List<KeyCode> interactiveKeys;
    public List<KeyCode> InteractiveKeys { get { return interactiveKeys; } }

    public bool IsOrangeKey;

    public bool IsActivatedLever;

    private void Update()
    {

        if (Input.GetKeyDown(InteractiveKeys[0]))
        {
            Flashlight.enabled = !Flashlight.enabled;
        }
    }
}
