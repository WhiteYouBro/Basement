using UnityEngine;
using UnityEngine.InputSystem;

public class InteractiveSystem : MonoBehaviour
{
    [SerializeField] private Light Flashlight;

    [SerializeField] private KeyCode FlashLightKey;

    private void Update()
    {
        // ����� ��� 0 ���������� ������
        
        if(Input.GetKeyDown(FlashLightKey))
        {

            Flashlight.enabled = !Flashlight.enabled;
        }
    }
}
