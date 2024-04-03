using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LvlButton : MonoBehaviour
{
    private int _bestLevel;

    private void Start()
    {
        _bestLevel = PlayerPrefs.GetInt("bestLevel", 1);
        if (int.Parse(gameObject.name) > _bestLevel)
        {
            gameObject.GetComponent<Button>().enabled = false;
            gameObject.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f, 1);
        }
    }

    public void TapLevel()
    {
        PlayerPrefs.SetInt("levelIndex", int.Parse(gameObject.name));
        SceneManager.LoadScene("Gameplay");
    }
}
