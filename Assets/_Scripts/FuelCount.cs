using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FuelCount : MonoBehaviour
{
    [SerializeField] private TMP_Text _fuelText;
    [SerializeField] private GameObject _winPanel;
    public static int Fuel;

    private void Start()
    {
        Fuel = 0;
    }

    private void Update()
    {
        _fuelText.text = $"{Fuel}/15";
        if (Fuel >= 15)
        {
            _winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
