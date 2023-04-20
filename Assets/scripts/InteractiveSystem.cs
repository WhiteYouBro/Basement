using UnityEngine;
using UnityEngine.InputSystem;

public class InteractiveSystem : MonoBehaviour
{
    [SerializeField] private Light Flashlight;

    [SerializeField] private KeyCode FlashLightKey;

    private void Update()
    {
        // смори оно 0 показывает всегда
        
        if(Input.GetKeyDown(FlashLightKey))
        {

            Flashlight.enabled = !Flashlight.enabled;
        }
    }
}
