using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Collections : MonoBehaviour {


    private Transform content;
    private Transform container;
    private Transform charTemplate;
    private Transform mascotpanel;
    private Transform mascottemp;

    public Characters characters;
 

    static private bool mascot = false;

    private int fantasy;
    private int romance;
    private int comedy;
    private int horror;
    private int music;
    private int mystery;
    private int scifi;
    private int western;
    private int dystopia;
    private int action;



    private void Awake()
    {
        content = transform.Find("Content");
        container = content.Find("charspace");
        charTemplate = container.Find("chartemp");
        mascotpanel = transform.Find("mascotset");
        mascottemp = mascotpanel.Find("temp");
    }

    private void Start()
    {
        Fantasy();
        Romance();
        Comedy();
        Horror();
        Music();
        Mystery();
        Action();
        Dystopia();
        Western();
        Scifi();

    }


    public void CreateItemButton(Characters.CharsGenres genre, Sprite charsprite, string charname, int x, int y)
    {
        Transform charTransform = Instantiate(charTemplate, container);
        RectTransform charRectTransform = charTransform.GetComponent<RectTransform>();


        float charHeight = 600f;
        float charWidth = 500f;
        charRectTransform.anchoredPosition = new Vector2(x * charWidth, -charHeight * y);

        charRectTransform.Find("charname").GetComponent<Text>().text = charname;
        charRectTransform.Find("character").GetComponent<Image>().sprite = charsprite;

        container.gameObject.SetActive(true);


        charRectTransform.Find("character").GetComponent<Button>().onClick.AddListener(() => ConfirmMascot(genre));


    }


    public void ConfirmMascot(Characters.CharsGenres genre)
    {
        Transform mascotTransform = Instantiate(mascottemp, mascotpanel);
        RectTransform mascotRectTransform = mascotTransform.GetComponent<RectTransform>();

        mascotRectTransform.Find("confirm").GetComponent<Button>().onClick.AddListener(() => Mascotset(genre));


    }

    public void Mascotset(Characters.CharsGenres character)
    {
        Debug.Log("Mascot: " + character);

        switch (character)
        {
            case Characters.CharsGenres.Fantasy:
                characters.MASFantasy();
                mascot = true;
                break;
            case Characters.CharsGenres.Romance:
                characters.MASRomance();
                mascot = true;
                break;
            case Characters.CharsGenres.Comedy:
                characters.MASComedy();
                mascot = true;
                break;
            case Characters.CharsGenres.Horror:
                characters.MASHorror();
                mascot = true;
                break;
            case Characters.CharsGenres.Music:
                characters.MASMusic();
                mascot = true;
                break;
            case Characters.CharsGenres.Mystery:
                characters.MASMystery();
                mascot = true;
                break;
            case Characters.CharsGenres.Action:
                characters.MASAction();
                mascot = true;
                break;
            case Characters.CharsGenres.Dystopia:
                characters.MASDystopia();
                mascot = true;
                break;
            case Characters.CharsGenres.Western:
                characters.MASWestern();
                mascot = true;
                break;
            case Characters.CharsGenres.Scifi:
                characters.MASScifi();
                mascot = true;
                break;

        }
    }


    public void Fantasy() {
        fantasy = PlayerPrefs.GetInt("Bought Fantasy");
        if (fantasy ==1)
            CreateItemButton(Characters.CharsGenres.Fantasy, Characters.GetSprite(Characters.CharsGenres.Fantasy), "Fantasy", 0, 0);

    }
    public void Romance()
    {
        romance = PlayerPrefs.GetInt("Bought Romance");
        if (romance == 1)
            CreateItemButton(Characters.CharsGenres.Romance, Characters.GetSprite(Characters.CharsGenres.Romance), "Romance", 1, 0);

    }
    public void Comedy()
    {
        comedy = PlayerPrefs.GetInt("Bought Comedy");
        if (comedy == 1)
            CreateItemButton(Characters.CharsGenres.Comedy, Characters.GetSprite(Characters.CharsGenres.Comedy), "Comedy", 0, 1);

    }
    public void Horror()
    {
        horror = PlayerPrefs.GetInt("Bought Horror");
        if (horror == 1)
            CreateItemButton(Characters.CharsGenres.Horror, Characters.GetSprite(Characters.CharsGenres.Horror), "Horror", 1, 1);

    }
    public void Music()
    {
        music = PlayerPrefs.GetInt("Bought Music");
        if (music == 1)
            CreateItemButton(Characters.CharsGenres.Music, Characters.GetSprite(Characters.CharsGenres.Music), "Music", 0, 2);

    }
    public void Mystery()
    {
        mystery = PlayerPrefs.GetInt("Bought Mystery");
        if (mystery == 1)
            CreateItemButton(Characters.CharsGenres.Mystery, Characters.GetSprite(Characters.CharsGenres.Mystery), "Mystery", 1, 2);

    }
    public void Action()
    {
        action = PlayerPrefs.GetInt("Bought Action");
        if (action == 1)
            CreateItemButton(Characters.CharsGenres.Action, Characters.GetSprite(Characters.CharsGenres.Action), "Action", 0, 3);

    }
    public void Dystopia()
    {
        dystopia = PlayerPrefs.GetInt("Bought Dystopia");
        if (dystopia == 1)
            CreateItemButton(Characters.CharsGenres.Dystopia, Characters.GetSprite(Characters.CharsGenres.Dystopia), "Dystopia", 1, 3);

    }
    public void Western()
    {
        western = PlayerPrefs.GetInt("Bought Western");
        if (western == 1)
            CreateItemButton(Characters.CharsGenres.Western, Characters.GetSprite(Characters.CharsGenres.Western), "Western", 0, 4);

    }
    public void Scifi()
    {
        scifi = PlayerPrefs.GetInt("Bought Scifi");
        if (scifi == 1)
            CreateItemButton(Characters.CharsGenres.Scifi, Characters.GetSprite(Characters.CharsGenres.Scifi), "Scifi", 1, 4);

    }

}
