using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class Characters:MonoBehaviour{

    public Button clear;
    public GameObject panel;
   

	public enum CharsGenres
    {
        None,
        Fantasy, 
        Romance,
        Comedy,
        Horror,
        Action,
        Mystery,
        Dystopia,
        Music,
        Western,
        Scifi
    }


    static public int fantasy = 0;
    static public int romance = 0;
    static public int comedy = 0;
    static public int horror = 0;
    static public int music = 0;
    static public int mystery = 0;
    static public int scifi = 0;
    static public int western = 0;
    static public int dystopia = 0;
    static public int action = 0;



    static public string mascot;



    public static int Charprice(CharsGenres characters)
    {
        switch (characters) {
            default:
                return 0;
            case CharsGenres.Fantasy:
                return 500;
            case CharsGenres.Romance:
                return 1500;
            case CharsGenres.Comedy:
                return 2000;
            case CharsGenres.Horror:
                return 2500;
            case CharsGenres.Music:
                return 3000;
            case CharsGenres.Mystery:
                return 3500;
            case CharsGenres.Action:
                return 4000;
            case CharsGenres.Dystopia:
                return 4500;
            case CharsGenres.Western:
                return 5000;
            case CharsGenres.Scifi:
                return 5500;
        }
        
    }

    public static Sprite GetSprite(CharsGenres characters)
    {
        switch (characters)
        {
            default:
                return CharacterAssets.Instance.None;
            case CharsGenres.Fantasy:
                return CharacterAssets.Instance.Fantasy;
            case CharsGenres.Romance:
                return CharacterAssets.Instance.Romance;
            case CharsGenres.Comedy:
                return CharacterAssets.Instance.Comedy;
            case CharsGenres.Horror:
                return CharacterAssets.Instance.Horror;
            case CharsGenres.Music:
                return CharacterAssets.Instance.Music;
            case CharsGenres.Mystery:
                return CharacterAssets.Instance.Mystery;
            case CharsGenres.Action:
                return CharacterAssets.Instance.Action;
            case CharsGenres.Dystopia:
                return CharacterAssets.Instance.Dystopia;
            case CharsGenres.Western:
                return CharacterAssets.Instance.Western;
            case CharsGenres.Scifi:
                return CharacterAssets.Instance.Scifi;
        }

    }


    public void Fantasy()
    {
        fantasy = 1;
        PlayerPrefs.SetInt("Bought Fantasy",fantasy);
    }
    public void Romance()
    {
        romance = 1;
        PlayerPrefs.SetInt("Bought Romance", romance);
    }

    public void Comedy()
    {
        comedy = 1;
        PlayerPrefs.SetInt("Bought Comedy", comedy);
    }
    public void Horror()
    {
        horror = 1;
        PlayerPrefs.SetInt("Bought Horror", horror);
    }

    public void Music()
    {
        music = 1;
        PlayerPrefs.SetInt("Bought Music", music);

    }

    public void Mystery()
    {
        mystery = 1;
        PlayerPrefs.SetInt("Bought Mystery", mystery);
    }
    public void Action()
    {
        action = 1;
        PlayerPrefs.SetInt("Bought Action", action);
    }
    public void Dystopia()
    {
        dystopia = 1;
        PlayerPrefs.SetInt("Bought Dystopia", dystopia);
    }

    public void Western()
    {
        western = 1;
        PlayerPrefs.SetInt("Bought Western", western);

    }

    public void Scifi()
    {
        scifi = 1;
        PlayerPrefs.SetInt("Bought Scifi", scifi);
    }



    public void MASFantasy()
    {

        mascot = "fantasy";

        Debug.Log("Mascot: Fantasy");
        //  PlayerPrefs.SetString("Mascot", masfantasy.ToString()+masromance.ToString()+mascomedy.ToString()+mashorror.ToString());
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));
    }
    public void MASRomance()
    {
 
        mascot = "romance";

        Debug.Log("Mascot: Romance");
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));
    }

    public void MASComedy()
    {
        mascot = "comedy";

        Debug.Log("Mascot: Comedy");
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));

    }
    public void MASHorror()
    {
        mascot = "horror";

        Debug.Log("Mascot: Horror");
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));

    }

    public void MASMusic()
    {
        mascot = "music";

        Debug.Log("Mascot: Music");
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));

    }

    public void MASMystery()
    {
        mascot = "mystery";

        Debug.Log("Mascot: Mystery");
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));

    }

    public void MASAction()
    {
        mascot = "action";

        Debug.Log("Mascot: Action");
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));

    }
    public void MASDystopia()
    {
        mascot = "dystopia";

        Debug.Log("Mascot: Dystopia");
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));

    }

    public void MASWestern()
    {
        mascot = "western";

        Debug.Log("Mascot: Western");
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));

    }

    public void MASScifi()
    {
        mascot = "scifi";

        Debug.Log("Mascot: Scifi");
        PlayerPrefs.SetString("Mascot", mascot);
        print(PlayerPrefs.GetString("Mascot"));

    }




    public void ClearProgress()
    {

        clear.onClick.AddListener(() => PlayerPrefs.DeleteAll());
        clear.onClick.AddListener(() => print(PlayerPrefs.GetInt("Money")));
        clear.onClick.AddListener(() => panel.gameObject.SetActive(true));
        //Debug.Log("All Data Deleted");

    }


}
