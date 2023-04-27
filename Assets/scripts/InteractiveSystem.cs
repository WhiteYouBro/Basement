using StarterAssets;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractiveSystem : MonoBehaviour
{
    [SerializeField] private Light Flashlight;

    [Tooltip("0 to Flashlight Key, 1 to Interact Key")]
    [SerializeField] private List<KeyCode> interactiveKeys;

    [SerializeField] private AudioClip SoundFlashlight;

    [SerializeField] private GameObject PanelOfDeathScreen;

    [HideInInspector] public bool IsDead;

    public bool IsRedKey;
    public bool IsYellowKey;
    public bool IsBlueKey;
    public bool IsOrangeKey;

    private AudioSource source;

    private StarterAssetsInputs scriptcursor;
    public List<KeyCode> InteractiveKeys { get { return interactiveKeys; } }



    private void Awake()
    {
        source = GetComponent<AudioSource>();    
        scriptcursor = GetComponent<StarterAssetsInputs>();
    }

    private void Update()
    {

        if (!IsDead)
        {
            if (Input.GetKeyDown(InteractiveKeys[0]))
            {
                source.PlayOneShot(SoundFlashlight);
                Flashlight.enabled = !Flashlight.enabled;
            }
        }
    }

    public void Death()
    {
        scriptcursor.cursorLocked = false;
        scriptcursor.cursorInputForLook = false;
        PanelOfDeathScreen.SetActive(true);
        Time.timeScale = 0f;
        IsDead = true;
        // need to do death cutscene or smth
    }
}
