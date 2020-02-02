using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ButtonManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public static bool OptionIsEnabled = false;
    public static bool WindRiddleIsEnabled = false;
    public static bool ClockRiddleIsEnabled = false;
    public static bool WaterRiddleIsEnabled = false;
    public static bool ShadowRiddleIsEnabled = false;
    public static bool MirrorRiddleIsEnabled = false;
    public GameObject optionMenuUI;
    public GameObject windButton;
    public GameObject clockButton;
    public GameObject waterButton;
    public GameObject shadowButton;
    public GameObject mirrorButton;


    // Update is called once per frame

    public void Enable()
    {
        optionMenuUI.SetActive(true);
        OptionIsEnabled = true;
    }

    public void Disable()
    {
        optionMenuUI.SetActive(false);
        OptionIsEnabled = false;
    }

    public void RiddleWiEn()
    {
        windButton.SetActive(true);
        WindRiddleIsEnabled = true;
        Time.timeScale = 0f;
    }
    public void RiddleWiDis()
    {
        windButton.SetActive(false);
        WindRiddleIsEnabled = false;
        Time.timeScale = 1f;
    }
    public void RiddleCloEn()
    {
        clockButton.SetActive(true);
        ClockRiddleIsEnabled = true;
        Time.timeScale = 0f;
    }
    public void RiddleCloDis()
    {
        clockButton.SetActive(false);
        ClockRiddleIsEnabled = false;
        Time.timeScale = 1f;
    }
    public void RiddleWatEn()
    {
        waterButton.SetActive(true);
        WaterRiddleIsEnabled = true;
        Time.timeScale = 0f;
    }
    public void RiddleWatDis()
    {
        waterButton.SetActive(false);
        WaterRiddleIsEnabled = false;
        Time.timeScale = 1f;
    }
    public void RiddleShadEn()
    {
        shadowButton.SetActive(true);
        ShadowRiddleIsEnabled = true;
        Time.timeScale = 0f;
    }
    public void RiddleShadDis()
    {
        shadowButton.SetActive(false);
        ShadowRiddleIsEnabled = false;
        Time.timeScale = 1f;
    }
    public void RiddleMirEn()
    {
        mirrorButton.SetActive(true);
        MirrorRiddleIsEnabled = true;
        Time.timeScale = 0f;
    }
    public void RiddleMirDis()
    {
        mirrorButton.SetActive(false);
        MirrorRiddleIsEnabled = false;
        Time.timeScale = 1f;
    }

    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("music", volume);
        audioMixer.SetFloat("sfx", volume);
    }
    public void SetMusic(float volume)
    {
        audioMixer.SetFloat("music", volume);
    }
    public void SetSfx(float volume)
    {
        audioMixer.SetFloat("sfx", volume);
    }
}
