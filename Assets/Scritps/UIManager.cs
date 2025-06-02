using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject backgroundImage;
    public GameObject titleText;
    public GameObject startButton;
    public GameObject optionsButton;
    public GameObject exitButton;
    public GameObject creditsButton; // Add reference to CreditsButton
    public GameObject creditsPanel;
    public GameObject optionsPanel;
    public Slider sfxSlider;
    public Slider musicSlider;
    public Toggle fullscreenToggle;

    void Start()
    {
        ShowMainMenu();
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume", 1f);
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
        fullscreenToggle.isOn = Screen.fullScreen;
    }

    public void ShowMainMenu()
    {
        backgroundImage.SetActive(true);
        titleText.SetActive(true);
        startButton.SetActive(true);
        optionsButton.SetActive(true);
        exitButton.SetActive(true);
        creditsButton.SetActive(true); // Ensure CreditsButton is shown
        creditsPanel.SetActive(false);
        optionsPanel.SetActive(false);
    }

    public void HideMainMenu()
    {
        backgroundImage.SetActive(false);
        titleText.SetActive(false);
        startButton.SetActive(false);
        optionsButton.SetActive(false);
        exitButton.SetActive(false);
        creditsButton.SetActive(false); // Hide CreditsButton
        creditsPanel.SetActive(false);
        optionsPanel.SetActive(false);
    }

    public void ShowCredits()
    {
        HideMainMenu();
        backgroundImage.SetActive(true);
        creditsPanel.SetActive(true);
    }

    public void HideCredits()
    {
        ShowMainMenu();
    }

    public void ShowOptions()
    {
        HideMainMenu();
        backgroundImage.SetActive(true);
        optionsPanel.SetActive(true);
    }

    public void HideOptions()
    {
        ShowMainMenu();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OpenOptions()
    {
        ShowOptions();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OnSFXVolumeChanged()
    {
        PlayerPrefs.SetFloat("SFXVolume", sfxSlider.value);
        PlayerPrefs.Save();
    }

    public void OnMusicVolumeChanged()
    {
        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
        PlayerPrefs.Save();
    }

    public void OnFullscreenToggled()
    {
        Screen.fullScreen = fullscreenToggle.isOn;
    }
}