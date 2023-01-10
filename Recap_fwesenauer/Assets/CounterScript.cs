using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterScript : MonoBehaviour
{
    public int counter = 0;

    public Text timerText;
    public Text counterText;
    public Text playerStatus;
    public Text winloose;
    
    public float timeRemaining = 120f;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Present")
        {
            counter++;

            playerStatus.text = "   ";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        int minutes = (int)timeRemaining / 60;
        int seconds = (int)timeRemaining % 60;
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        counterText.text = counter.ToString();

        if (timerText.text == "00:00") 
        {
            if( counter <= 10)
            {
                winloose.text = "Failed";
            }
            else
            {
                winloose.text = "Won";
            }
        }
    }
}
