using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text Clock;
    private float timeLeft = 120.0f;
    public Text Win;

    // Update is called once per frame
    void Update()
    {
        setTime();

        if (timeLeft <= 0.0f) {
            Win.text = "You Win!";
            timeLeft = 0.0f;
        }
    }

    void setTime() {
        timeLeft -= Time.deltaTime;
        Clock.text = "Time Left: " + timeLeft.ToString();      
    }
}
