using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;
    public TMP_Text bestTimeText;
    private float _bestTime;

    private void Start()
    {
        Time.timeScale = 1;
        _bestTime = PlayerPrefs.GetFloat("bestTime", 999.99f);
        bestTimeText.text = $"Best score: {_bestTime.ToString("F2")}";
    }

    public void GoGame()
    {
        _levelsPanel.SetActive(true);
    }
}
