using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject backgroundImage;
    public GameObject titleText;
    public GameObject startButton;
    public GameObject optionsButton;
    public GameObject exitButton;
    public GameObject creditsPanel; // Add CreditsPanel reference

    void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        backgroundImage.SetActive(true);
        titleText.SetActive(true);
        startButton.SetActive(true);
        optionsButton.SetActive(true);
        exitButton.SetActive(true);
        creditsPanel.SetActive(false); // Hide Credits by default
    }

    public void HideMainMenu()
    {
        backgroundImage.SetActive(false);
        titleText.SetActive(false);
        startButton.SetActive(false);
        optionsButton.SetActive(false);
        exitButton.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void ShowCredits()
    {
        backgroundImage.SetActive(true); // Keep background visible
        titleText.SetActive(false);
        startButton.SetActive(false);
        optionsButton.SetActive(false);
        exitButton.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void HideCredits()
    {
        ShowMainMenu(); // Return to Main Menu
    }
}