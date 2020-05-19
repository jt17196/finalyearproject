using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour {

    private const float REAL_SECONDS_PER_INGAME_DAY = 86400f;

   
    public Text timeText;
    string oldseconds;

   
    //TIME ELEMENTS
    public int hours; //to set the hours
    public int minutes; //to set the minutes
    public int seconds; //to set the seconds
    private bool _timerComplete = false;
    private bool _timerIsReady;
    private TimeSpan _startTime;
    private TimeSpan _endTime;
    private TimeSpan _remainingTime;
    //progress filler
    private float _value = 1f;




    //startup
    void Start()
    {
        if (PlayerPrefs.GetString("_timer") == "")
        {
            Debug.Log("==> Enableing button");
            Enable();
        }
        else
        {
            Disable();
            StartCoroutine("CheckTime");
        }
    }



    //update the time information with what we got some the internet
    private void updateTime()
    {
        if (PlayerPrefs.GetString("_timer") == "Standby")
        {
            PlayerPrefs.SetString("_timer", TimeManager.sharedInstance.getCurrentTimeNow());
            PlayerPrefs.SetInt("_date", TimeManager.sharedInstance.getCurrentDateNow());
            //PlayerPrefs.SetString("_timer", System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm:ss"));
            //PlayerPrefs.SetInt("_date", int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("yyyy/mm/dd")));
        }
        else if (PlayerPrefs.GetString("_timer") != "" && PlayerPrefs.GetString("_timer") != "Standby")
        {
            int _old = PlayerPrefs.GetInt("_date");
            int _now = (TimeManager.sharedInstance.getCurrentDateNow());
           // int _now = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("yyyy/MM/dd"));


            //check if a day as passed
            if (_now > _old)
            {//day as passed
                Debug.Log("Day has passed");
                Enable();
                return;
            }
            else if (_now == _old)
            {//same day
                Debug.Log("Same Day - configuring now");
                _configTimerSettings();
                return;
            }
            else
            {
                Debug.Log("error with date");
                return;
            }
        }
        Debug.Log("Configuring now");
        _configTimerSettings();
    }

    //setting up and configureing the values
    //update the time information with what we got some the internet
    private void _configTimerSettings()
    {
        _startTime = TimeSpan.Parse(PlayerPrefs.GetString("_timer"));
        _endTime = TimeSpan.Parse(hours + ":" + minutes + ":" + seconds);
        TimeSpan temp = TimeSpan.Parse(TimeManager.sharedInstance.getCurrentTimeNow());

       // TimeSpan temp = TimeSpan.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm:ss"));

        TimeSpan diff = temp.Subtract(_startTime);
        _remainingTime = _endTime.Subtract(diff);
        //start timmer where we left off
        setProgressWhereWeLeftOff();

        if (diff >= _endTime)
        {
            _timerComplete = true;
            Enable();
        }
        else
        {
            _timerComplete = false;
            Disable();
            _timerIsReady = true;
        }
    }

    //initializing the value of the timer
    private void setProgressWhereWeLeftOff()
    {
        float ah = 1f / (float)_endTime.TotalSeconds;
        float bh = 1f / (float)_remainingTime.TotalSeconds;
        _value = ah / bh;
      
    }



    //enable button function
    private void Enable()
    {
        PlayerPrefs.GetInt("Goal Reached");
        PlayerPrefs.SetInt("Goal Reached",0);
        Debug.Log("goal not reached");

    }



    //disable button function
    private void Disable()
    {
        PlayerPrefs.GetInt("Goal Reached");
        PlayerPrefs.SetInt("Goal Reached", 1);
        Debug.Log("goal reached");
    }


    //use to check the current time before completely any task.use this to validate
    private IEnumerator CheckTime()
    {
        Disable();

        Debug.Log("==> Checking for new time");
        yield return StartCoroutine(
           TimeManager.sharedInstance.getTime()
           //System.DateTime.UtcNow.ToLocalTime().ToString("yyyy/MM/dd HH:mm:ss")
        );
        updateTime();
        Debug.Log("==> Time check complete!");

    }


    //trggered on button click
    public void RewardClicked()
    {
        Debug.Log("==> Claimed");
        PlayerPrefs.SetString("_timer", "Standby");
        StartCoroutine("CheckTime");
    }



    //update method to make the progress tick
    void Update()
    {


        string seconds = System.DateTime.UtcNow.ToString("ss");

        if (oldseconds != seconds)
        {
            UpdateTimer();
        }

        oldseconds = seconds;



        if (_timerIsReady)
        {
            if (!_timerComplete && PlayerPrefs.GetString("_timer") != "")
            {
                _value -= Time.deltaTime * 1f / (float)_endTime.TotalSeconds;
              

                //this is called once only
                if (_value <= 0 && !_timerComplete)
                {
                    //when the timer hits 0, let do a quick validation to make sure no speed hacks.
                    validateTime();
                    _timerComplete = true;
                }
            }
        }
    }



    //validator
    private void validateTime()
    {
        Debug.Log("==> Validating time to make sure no speed hack!");
        StartCoroutine("CheckTime");
    }


  




    //private void Update() {

    //    string seconds = System.DateTime.UtcNow.ToString("ss");

    //    if (oldseconds != seconds) {
    //        UpdateTimer();
    //    }

    //    oldseconds = seconds;
      
    //}


    private void UpdateTimer()
    {
        int secondsint = int.Parse(System.DateTime.UtcNow.ToString("ss"));
        int minutesint = int.Parse(System.DateTime.UtcNow.ToString("mm"));
        int hoursint = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("HH"));

        timeText.text = "Daily Goal Resets Every 24 Hours\n" + "Current Time: " + hoursint.ToString() + ":" + minutesint.ToString() + ":" + secondsint.ToString();


    }

    public void ResetGoal()
    {
        int secondsint = int.Parse(System.DateTime.UtcNow.ToString("ss"));
        int minutesint = int.Parse(System.DateTime.UtcNow.ToString("mm"));
        int hoursint = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("HH"));
        if (hoursint == 0 && minutesint == 0 && secondsint == 0)
        {
            PlayerPrefs.GetInt("Goal Reached");
            PlayerPrefs.SetInt("Goal Reached", 0);
        }

    }

}
