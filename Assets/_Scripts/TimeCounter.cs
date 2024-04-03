using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _timeScoreText;
    public static float _time = 0;

    private void Start()
    {
        Time.timeScale = 1;
        _time = 0;
    }

    private void Update()
    {
        _time = _time + 1 * Time.deltaTime;
        _timeScoreText.text = _time.ToString("F2");
    }
}