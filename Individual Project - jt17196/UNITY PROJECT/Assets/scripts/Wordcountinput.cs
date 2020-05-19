using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wordcountinput : MonoBehaviour
{

    public static Wordcountinput Instance {
        get;
        private set;
    }

    [SerializeField]
    public InputField inputnum;


    public int money;
    public Text totalmoney;
    public GameObject panel;
    private int wordcount;

    private int goal;
    public GameObject congrats;
    static public int reached;
 


    void Start(){
        money = PlayerPrefs.GetInt("Money");
        wordcount = PlayerPrefs.GetInt("WordCount");
        totalmoney.text = "$" + money.ToString();
        print(PlayerPrefs.GetInt("Goal Reached"));
    }

    public void Getinput(string count) {

        count = inputnum.text;
        //count = input.GetComponent<Text>().text;
        IncreaseMoney(int.Parse(count));
        
        //count = "";
    }

    void IncreaseMoney(int count) {
        money += count;
        wordcount += count;
        panel.gameObject.SetActive(false);
        goal = PlayerPrefs.GetInt("Goal");
        reached = PlayerPrefs.GetInt("Goal Reached");
        print(reached);
        if (count >= goal && reached == 0)
        {
            congrats.gameObject.SetActive(true);
            money += 50;
            reached = 1;
            PlayerPrefs.SetInt("Goal Reached", reached);
            print(reached);
        }
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.SetInt("WordCount", wordcount);
        totalmoney.text = "$" + money.ToString();
    }

   public void DecreaseMoney(int purchase)
    {
        if (money < purchase) {
            Debug.Log("Not Enough Money");
           
        }
        else
        {
            money -= purchase;
            PlayerPrefs.SetInt("Money", money);
            totalmoney.text = "$" + money.ToString();
            
        }
    }


}
