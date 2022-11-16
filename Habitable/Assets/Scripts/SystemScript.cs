using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemScript : MonoBehaviour
{
    [SerializeField] private GameObject winUI;
    [SerializeField] private GameObject loseUI;
    
    // Timer Variables
    static public float timeElapsed = 0;
    static public float timeLeft = 24000;
    static public float dayTime = 0;
    static public int currentDay = 0;

    public bool timerIsRunning = false;
    // /Timer Variables

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        // Timer
        if (timerIsRunning)
        {
            if (timeElapsed < 24000)
            {
                timeElapsed += Time.deltaTime;
                timeLeft -= Time.deltaTime;

                // Days
                if (dayTime < 24)
                {
                    dayTime += Time.deltaTime;
                }
                else if (dayTime == 24)
                {
                    currentDay += 1;
                    Debug.Log("Days: " + currentDay);
                    dayTime = 0;
                }

            }
            else
            {
                Debug.Log("Millenium Complete");
                Debug.Log("Days: " + currentDay);
                timeElapsed = 24000;
                timerIsRunning = false;
            }
        }
        // /Timer
    }
    
    //update
    //{
    // 
    //    if(lose condition == true)
    //    enable game over UI
    //    else if (win condition == true)
    //    enable win UI
    //}
}
//