using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ApplicationQuit()
    {
        Application.Quit();
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("main scene");
    }

    public void PanelLore()
    {
        panel.SetActive(true);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("main menu");
    }
}
