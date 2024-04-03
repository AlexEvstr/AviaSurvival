using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameButtons : MonoBehaviour
{
    public GameObject _pausePanel;

    public void PauseGameplay()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void UnpauseGameplay()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NextGameLevel()
    {
        LevelCount.LevelIndex++;
        PlayerPrefs.SetInt("levelIndex", LevelCount.LevelIndex);
        SceneManager.LoadScene("Gameplay");

    }
}