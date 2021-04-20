using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // IMPORTANT!!!!!!!!
public class TImeCon : MonoBehaviour
{

    public Text textShow;
    public float timeRemaining = 10f;
    public bool timerIsRunning = false;
    public Slider slider;

    public void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    public void Update()
    {

        float fc = (float)System.Math.Round(timeRemaining * 100f) / 100f;
        slider.value = timeRemaining/10;
        textShow.text = fc.ToString();
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
        
    }


}
