using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FuelCount : MonoBehaviour
{
    [SerializeField] private TMP_Text _fuelText;
    [SerializeField] private GameObject _winPanel;
    public static int Fuel;
    private float _bestTime;

    private void Start()
    {
        _bestTime = PlayerPrefs.GetFloat("bestTime", 999.99f);
        Fuel = 0;
    }

    private void Update()
    {
        _fuelText.text = $"{Fuel}/15";
        if (Fuel >= 15)
        { 
            if (_bestTime > TimeCounter._time)
            {
                _bestTime = TimeCounter._time;
                PlayerPrefs.SetFloat("bestTime", _bestTime);
            }
            _winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
