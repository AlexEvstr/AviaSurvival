using UnityEngine;
using TMPro;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;
    public TMP_Text bestTimeText;
    private float _bestTime;

    [SerializeField] private GameObject _onSound;
    [SerializeField] private GameObject _offSound;

    private void Start()
    {
        Time.timeScale = 1;

        AudioListener.volume = PlayerPrefs.GetFloat("mute", 1);
        if (AudioListener.volume == 0) MuteMusic();
        else UnmuteMusic();


        _bestTime = PlayerPrefs.GetFloat("bestTime", 999.99f);
        bestTimeText.text = $"Best score: {_bestTime.ToString("F2")}";
    }

    public void GoGame()
    {
        _levelsPanel.SetActive(true);
    }

    public void MuteMusic()
    {
        _offSound.SetActive(true);
        AudioListener.volume = 0;
        PlayerPrefs.SetFloat("mute", 0);
    }

    public void UnmuteMusic()
    {
        _offSound.SetActive(false);
        AudioListener.volume = 1;
        PlayerPrefs.SetFloat("mute", 1);
    }
}