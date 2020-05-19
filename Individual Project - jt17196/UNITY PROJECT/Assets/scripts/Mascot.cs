using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#pragma strict

public class Mascot : MonoBehaviour {

    private Transform container;
    private Transform charTemplate;


    public Characters characters;
    public Quotes speech;

    static private bool mascot = false;

    static private string currentmascot;



    private void Awake()
    {
        container = transform.Find("charspace");
        charTemplate = container.Find("chartemp");
    }

    // Use this for initialization
    void Start () {

        MascotFantasy();
        MascotRomance();
        MascotComedy();
        MascotHorror();
        MascotMusic();
        MascotMystery();
        MascotAction();
        MascotDystopia();
        MascotWestern();
        MascotScifi();

    }


    public void CreateItemButton(Characters.CharsGenres genre, Sprite charsprite)
    {
        Transform charTransform = Instantiate(charTemplate, container);
        RectTransform charRectTransform = charTransform.GetComponent<RectTransform>();


        charRectTransform.Find("character").GetComponent<Image>().sprite = charsprite;

        container.gameObject.SetActive(true);


       charRectTransform.Find("character").GetComponent<Button>().onClick.AddListener(() => speech.Bubble());
       charRectTransform.Find("character").GetComponent<Button>().onClick.AddListener(() => speech.Generate());




    }




    public void MascotFantasy()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "fantasy")
            CreateItemButton(Characters.CharsGenres.Fantasy, Characters.GetSprite(Characters.CharsGenres.Fantasy));

    }
    public void MascotRomance()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "romance")
            CreateItemButton(Characters.CharsGenres.Romance, Characters.GetSprite(Characters.CharsGenres.Romance));

    }
    public void MascotComedy()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "comedy")
            CreateItemButton(Characters.CharsGenres.Comedy, Characters.GetSprite(Characters.CharsGenres.Comedy));

    }
    public void MascotHorror()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "horror")
            CreateItemButton(Characters.CharsGenres.Horror, Characters.GetSprite(Characters.CharsGenres.Horror));

    }
    public void MascotMusic()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "music")
            CreateItemButton(Characters.CharsGenres.Music, Characters.GetSprite(Characters.CharsGenres.Music));

    }

    public void MascotMystery()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "mystery")
            CreateItemButton(Characters.CharsGenres.Mystery, Characters.GetSprite(Characters.CharsGenres.Mystery));

    }
    public void MascotAction()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "action")
            CreateItemButton(Characters.CharsGenres.Action, Characters.GetSprite(Characters.CharsGenres.Action));

    }
    public void MascotDystopia()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "dystopia")
            CreateItemButton(Characters.CharsGenres.Dystopia, Characters.GetSprite(Characters.CharsGenres.Dystopia));

    }
    public void MascotWestern()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "western")
            CreateItemButton(Characters.CharsGenres.Western, Characters.GetSprite(Characters.CharsGenres.Western));

    }
    public void MascotScifi()
    {
        currentmascot = PlayerPrefs.GetString("Mascot");
        if (currentmascot == "scifi")
            CreateItemButton(Characters.CharsGenres.Scifi, Characters.GetSprite(Characters.CharsGenres.Scifi));

    }

}
