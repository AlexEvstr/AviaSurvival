using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuPanel : MonoBehaviour
{
    public TMP_Text bestTimeText;
    private float _bestTime;

    private void Start()
    {
        _bestTime = PlayerPrefs.GetFloat("bestTime", 999.99f);
        bestTimeText.text = $"Best score: {_bestTime.ToString("F2")}";
        Time.timeScale = 1;
    }

    public void GoGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
