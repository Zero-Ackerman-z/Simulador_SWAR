using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Referencias a los GameObjects de cada sección
    public GameObject mainSection;
    public GameObject optionsSection;
    public GameObject creditsSection;

    void Start()
    {
        // Al iniciar, mostrar solo el menú principal
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainSection.SetActive(true);
        optionsSection.SetActive(false);
        creditsSection.SetActive(false);
    }

    public void ShowOptions()
    {
        mainSection.SetActive(false);
        optionsSection.SetActive(true);
        creditsSection.SetActive(false);
    }

    public void ShowCredits()
    {
        mainSection.SetActive(false);
        optionsSection.SetActive(false);
        creditsSection.SetActive(true);
    }

    // Cambié el nombre del método para que no coincida con la clase
    public void LoadMainVRScene()
    {
        SceneManager.LoadScene("MainVR");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Salir");
    }
}