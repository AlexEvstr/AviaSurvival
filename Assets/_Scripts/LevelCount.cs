using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelCount : MonoBehaviour
{
    [SerializeField] private TMP_Text _levelText;
    public static int LevelIndex;
    private int bestLevel;

    private void Start()
    {
        LevelIndex = PlayerPrefs.GetInt("levelIndex", 1);
        bestLevel = PlayerPrefs.GetInt("bestLevel", 1);
    }

    private void Update()
    {
        _levelText.text = $"LEVEL: {LevelIndex}";

        if (bestLevel < LevelIndex)
        {
            bestLevel = LevelIndex;
            PlayerPrefs.SetInt("bestLevel", bestLevel);
        }
    }
}