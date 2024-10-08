using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeCounter;
    [SerializeField] private int minutes;
    [SerializeField] private int seconds;
    [SerializeField] private TextMeshProUGUI timerText;
    
    

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime % 60;
        minutes = Mathf.FloorToInt(timeCounter / 60f);
        seconds = Mathf.FloorToInt(timeCounter - minutes * 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
