using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetGoal : MonoBehaviour {

    public static SetGoal Instance
    {
        get;
        private set;
    }



    [SerializeField]
    public InputField inputgoal;

    public int wc;
    public int goal;
    public Text currentgoal;
    public Text totalwords;


    private void Start()
    {
        //wc = PlayerPrefs.GetInt("WordCount");
        //totalwords.text = "TOTAL WORD COUNT: \n" + wc.ToString();
    }


    // Use this for initialization
    void Update () {
        wc = PlayerPrefs.GetInt("WordCount");
        totalwords.text = "TOTAL WORD COUNT: \n" + wc.ToString();

        goal = PlayerPrefs.GetInt("Goal");
        currentgoal.text = "CURRENT DAILY GOAL: \n" + goal.ToString();
    }

    public void Getinput(string set)
    {

        set = inputgoal.text;
        Setinput(int.Parse(set));
       
    }

    public void Setinput(int g)
    {
        goal = g;
        print(g);
        print(goal);
        PlayerPrefs.SetInt("Goal", goal);
        currentgoal.text = "CURRENT DAILY GOAL: \n" + goal.ToString();

    }


}
