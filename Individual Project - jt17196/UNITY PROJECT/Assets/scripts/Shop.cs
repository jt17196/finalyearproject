using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

    private Transform content;
    private Transform container;
    private Transform shopItemTemplate;

    public Wordcountinput money;
    public int bank;


    private Transform nomoneypanel;
    private Transform nomoneytemp;
    private GameObject nomoney;

    private Transform confirmpanel;
    private Transform confirmtemp;
    private Transform confirmpurchase;


    private Transform thankspanel;
    private Transform collected;
    private Transform back;
    public Text sold;



    public Characters characters;

    static private bool bought = false;

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
        shopItemTemplate = container.Find("chartemp");

        //nomoneypanel = transform.Find("nomoneypanel");
        //nomoneytemp = nomoneypanel.Find("nomoney");

        confirmpanel = transform.Find("confirmpanel");
        confirmtemp = confirmpanel.Find("chartemp");
        confirmpurchase = confirmpanel.Find("confirmpurchase");

        thankspanel = transform.Find("thankspanel");
        collected = thankspanel.Find("chartemp");
        back = thankspanel.Find("purchased");
    }

    private void Start()
    {
        bank = PlayerPrefs.GetInt("Money");
        print(bank);

        CreateItemButton(Characters.CharsGenres.Fantasy, Characters.GetSprite(Characters.CharsGenres.Fantasy), "Fantasy", Characters.Charprice(Characters.CharsGenres.Fantasy), 0,0);    
        CreateItemButton(Characters.CharsGenres.Romance, Characters.GetSprite(Characters.CharsGenres.Romance), "Romance", Characters.Charprice(Characters.CharsGenres.Romance), 1,0);
        CreateItemButton(Characters.CharsGenres.Comedy, Characters.GetSprite(Characters.CharsGenres.Comedy), "Comedy", Characters.Charprice(Characters.CharsGenres.Comedy), 0, 1);
        CreateItemButton(Characters.CharsGenres.Horror, Characters.GetSprite(Characters.CharsGenres.Horror), "Horror", Characters.Charprice(Characters.CharsGenres.Horror), 1, 1);
        CreateItemButton(Characters.CharsGenres.Music, Characters.GetSprite(Characters.CharsGenres.Music), "Music", Characters.Charprice(Characters.CharsGenres.Music), 0, 2);
        CreateItemButton(Characters.CharsGenres.Mystery, Characters.GetSprite(Characters.CharsGenres.Mystery), "Mystery", Characters.Charprice(Characters.CharsGenres.Mystery), 1, 2);
        CreateItemButton(Characters.CharsGenres.Action, Characters.GetSprite(Characters.CharsGenres.Action), "Action", Characters.Charprice(Characters.CharsGenres.Action), 0, 3);
        CreateItemButton(Characters.CharsGenres.Dystopia, Characters.GetSprite(Characters.CharsGenres.Dystopia), "Dystopia", Characters.Charprice(Characters.CharsGenres.Dystopia), 1, 3);
        CreateItemButton(Characters.CharsGenres.Western, Characters.GetSprite(Characters.CharsGenres.Western), "Western", Characters.Charprice(Characters.CharsGenres.Western), 0, 4);
        CreateItemButton(Characters.CharsGenres.Scifi, Characters.GetSprite(Characters.CharsGenres.Scifi), "Scifi", Characters.Charprice(Characters.CharsGenres.Scifi), 1, 4);


        SOLD2();
        NOMONEY2();

    }


    private void CreateItemButton(Characters.CharsGenres genre, Sprite charsprite, string charname, int price, int x, int y)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 1200f;
        float shopItemWidth = 800f;
        shopItemRectTransform.anchoredPosition = new Vector2(x * shopItemWidth, -shopItemHeight * y);
        string p = price.ToString();

        shopItemTransform.Find("charname").GetComponent<Text>().text = charname;
        shopItemTransform.Find("price").GetComponent<Text>().text = "$" + p;

        shopItemTransform.Find("character").GetComponent<Image>().sprite = charsprite;

        shopItemTransform.Find("SOLD").GetComponent<Text>().text = "SOLD";


      if (price <= bank) {
            shopItemTransform.Find("character").GetComponent<Button>().onClick.AddListener(() => Debug.Log("got money"));
            shopItemTransform.Find("character").GetComponent<Button>().onClick.AddListener(() => Confirmbuy(genre, charsprite, charname, price));
        }
           

    }


    public void NoMoney(Characters.CharsGenres genre)
    {
        Transform nomoneyTransform = Instantiate(nomoneytemp,nomoneypanel);
        RectTransform nomneyRectTransform = nomoneyTransform.GetComponent<RectTransform>();
        nomoneypanel.gameObject.SetActive(true);
    }


    private void CreateSOLD(Characters.CharsGenres genre, Sprite charsprite, int x, int y)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 1200f;
        float shopItemWidth = 800f;
        shopItemRectTransform.anchoredPosition = new Vector2(x * shopItemWidth, -shopItemHeight * y);


        shopItemTransform.Find("SOLD").GetComponent<Text>().text = "SOLD";
        shopItemTransform.Find("character").GetComponent<Image>().sprite = charsprite;


        shopItemTransform.Find("SOLD").GetComponent<Text>().gameObject.SetActive(true);

    }


    private void CreateNOMONEY(Characters.CharsGenres genre, Sprite charsprite, int x, int y)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 1200f;
        float shopItemWidth = 800f;
        shopItemRectTransform.anchoredPosition = new Vector2(x * shopItemWidth, -shopItemHeight * y);


        shopItemTransform.Find("nomoney").GetComponent<Text>().text = "NOT ENOUGH MONEY";
        shopItemTransform.Find("character").GetComponent<Image>().sprite = charsprite;


        shopItemTransform.Find("nomoney").GetComponent<Text>().gameObject.SetActive(true);

    }

    public void SOLD2()
    {
        fantasy = PlayerPrefs.GetInt("Bought Fantasy");
        romance = PlayerPrefs.GetInt("Bought Romance");
        comedy = PlayerPrefs.GetInt("Bought Comedy");
        horror = PlayerPrefs.GetInt("Bought Horror");
        music = PlayerPrefs.GetInt("Bought Music");
        mystery = PlayerPrefs.GetInt("Bought Mystery");
        action = PlayerPrefs.GetInt("Bought Action");
        dystopia = PlayerPrefs.GetInt("Bought Dystopia");
        western = PlayerPrefs.GetInt("Bought Western");
        scifi = PlayerPrefs.GetInt("Bought Scifi");

        if (fantasy == 1) CreateSOLD(Characters.CharsGenres.Fantasy, Characters.GetSprite(Characters.CharsGenres.Fantasy), 0, 0);
        if (romance == 1) CreateSOLD(Characters.CharsGenres.Romance, Characters.GetSprite(Characters.CharsGenres.Romance), 1, 0);
        if (comedy == 1) CreateSOLD(Characters.CharsGenres.Comedy, Characters.GetSprite(Characters.CharsGenres.Comedy), 0, 1);
        if (horror == 1) CreateSOLD(Characters.CharsGenres.Horror, Characters.GetSprite(Characters.CharsGenres.Horror), 1, 1);
        if (music == 1) CreateSOLD(Characters.CharsGenres.Music, Characters.GetSprite(Characters.CharsGenres.Music), 0, 2);
        if (mystery == 1) CreateSOLD(Characters.CharsGenres.Mystery, Characters.GetSprite(Characters.CharsGenres.Mystery), 1, 2);
        if (action == 1) CreateSOLD(Characters.CharsGenres.Action, Characters.GetSprite(Characters.CharsGenres.Action), 0, 3);
        if (dystopia == 1) CreateSOLD(Characters.CharsGenres.Dystopia, Characters.GetSprite(Characters.CharsGenres.Dystopia), 1, 3);
        if (western == 1) CreateSOLD(Characters.CharsGenres.Western, Characters.GetSprite(Characters.CharsGenres.Western), 0, 4);
        if (scifi == 1) CreateSOLD(Characters.CharsGenres.Scifi, Characters.GetSprite(Characters.CharsGenres.Scifi), 1, 4);
    }

    public void NOMONEY2()
    {

        fantasy = PlayerPrefs.GetInt("Bought Fantasy");
        romance = PlayerPrefs.GetInt("Bought Romance");
        comedy = PlayerPrefs.GetInt("Bought Comedy");
        horror = PlayerPrefs.GetInt("Bought Horror");
        music = PlayerPrefs.GetInt("Bought Music");
        mystery = PlayerPrefs.GetInt("Bought Mystery");
        action = PlayerPrefs.GetInt("Bought Action");
        dystopia = PlayerPrefs.GetInt("Bought Dystopia");
        western = PlayerPrefs.GetInt("Bought Western");
        scifi = PlayerPrefs.GetInt("Bought Scifi");

        bank = PlayerPrefs.GetInt("Money");

        if (Characters.Charprice(Characters.CharsGenres.Fantasy) > bank && fantasy == 0)
            CreateNOMONEY(Characters.CharsGenres.Fantasy, Characters.GetSprite(Characters.CharsGenres.Fantasy), 0, 0);
        if (Characters.Charprice(Characters.CharsGenres.Romance) > bank && romance == 0)
            CreateNOMONEY(Characters.CharsGenres.Romance, Characters.GetSprite(Characters.CharsGenres.Romance), 1, 0);
        if (Characters.Charprice(Characters.CharsGenres.Comedy) > bank && comedy == 0)
            CreateNOMONEY(Characters.CharsGenres.Comedy, Characters.GetSprite(Characters.CharsGenres.Comedy), 0, 1);
        if (Characters.Charprice(Characters.CharsGenres.Horror) > bank && horror == 0)
            CreateNOMONEY(Characters.CharsGenres.Horror, Characters.GetSprite(Characters.CharsGenres.Horror), 1, 1);
        if (Characters.Charprice(Characters.CharsGenres.Music) > bank && music == 0)
            CreateNOMONEY(Characters.CharsGenres.Music, Characters.GetSprite(Characters.CharsGenres.Music), 0, 2);
        if (Characters.Charprice(Characters.CharsGenres.Mystery) > bank && mystery == 0)
            CreateNOMONEY(Characters.CharsGenres.Mystery, Characters.GetSprite(Characters.CharsGenres.Mystery), 1, 2);
        if (Characters.Charprice(Characters.CharsGenres.Action) > bank && action == 0)
            CreateNOMONEY(Characters.CharsGenres.Action, Characters.GetSprite(Characters.CharsGenres.Action), 0, 3);
        if (Characters.Charprice(Characters.CharsGenres.Dystopia) > bank && dystopia == 0)
            CreateNOMONEY(Characters.CharsGenres.Dystopia, Characters.GetSprite(Characters.CharsGenres.Dystopia), 1, 3);
        if (Characters.Charprice(Characters.CharsGenres.Western) > bank && western == 0)
            CreateNOMONEY(Characters.CharsGenres.Western, Characters.GetSprite(Characters.CharsGenres.Western), 0, 4);
        if (Characters.Charprice(Characters.CharsGenres.Scifi) > bank && scifi == 0)
            CreateNOMONEY(Characters.CharsGenres.Scifi, Characters.GetSprite(Characters.CharsGenres.Scifi), 1, 4);


    }



    public void Confirmbuy(Characters.CharsGenres genre, Sprite charsprite, string charname, int price)
    {
        Transform confirmItem = Instantiate(confirmtemp, confirmpanel);
        Transform buyItem = Instantiate(confirmpurchase, confirmpanel);


        RectTransform confirmItemRect = confirmItem.GetComponent<RectTransform>();
        RectTransform confirmPurchaseRect = buyItem.GetComponent<RectTransform>();

        confirmpanel.gameObject.SetActive(true);

        string p = price.ToString();
  

        confirmItem.Find("charname").GetComponent<Text>().text = charname;
        confirmItem.Find("price").GetComponent<Text>().text = "$" + p;

        confirmItem.Find("character").GetComponent<Image>().sprite = charsprite;

       
            buyItem.Find("confirm").GetComponent<Button>().onClick.AddListener(() => Buy(genre, charsprite, charname));


            buyItem.Find("confirm").GetComponent<Button>().onClick.AddListener(() => Destroy(confirmItem.gameObject));
            buyItem.Find("confirm").GetComponent<Button>().onClick.AddListener(() => Destroy(buyItem.gameObject));
        
          
        buyItem.Find("cancel").GetComponent<Button>().onClick.AddListener(() => Destroy(confirmItem.gameObject));
        buyItem.Find("cancel").GetComponent<Button>().onClick.AddListener(() => Destroy(buyItem.gameObject));

    }

    private void Buy(Characters.CharsGenres genre, Sprite charsprite, string charname)
    {

        int price = Characters.Charprice(genre);

        money.DecreaseMoney(price);
        // Can afford cost
        BoughtItem(genre);

        SOLD2();
        NOMONEY2();
     

            Transform character = Instantiate(collected, thankspanel);
            Transform goback = Instantiate(back, thankspanel);

            RectTransform collectedRect = character.GetComponent<RectTransform>();
            RectTransform backRect = goback.GetComponent<RectTransform>();

            character.Find("charname").GetComponent<Text>().text = charname;
            character.Find("character").GetComponent<Image>().sprite = charsprite;

            goback.Find("back").GetComponent<Button>().onClick.AddListener(() => Destroy(character.gameObject));
            goback.Find("back").GetComponent<Button>().onClick.AddListener(() => Destroy(goback.gameObject));

    }

    public void BoughtItem(Characters.CharsGenres character)
    {
        Debug.Log("Bought character: " + character);
        switch (character)
        {
            case Characters.CharsGenres.Fantasy:
                characters.Fantasy();
                bought = true;
                break;
            case Characters.CharsGenres.Romance:
                characters.Romance();
                bought = true;
                break;
            case Characters.CharsGenres.Comedy:
                characters.Comedy();
                bought = true;
                break;
            case Characters.CharsGenres.Horror:
                characters.Horror();
                bought = true;
                break;
            case Characters.CharsGenres.Music:
                characters.Music();
                bought = true;
                break;
            case Characters.CharsGenres.Mystery:
                characters.Mystery();
                bought = true;
                break;
            case Characters.CharsGenres.Action:
                characters.Action();
                bought = true;
                break;
            case Characters.CharsGenres.Dystopia:
                characters.Dystopia();
                bought = true;
                break;
            case Characters.CharsGenres.Western:
                characters.Western();
                bought = true;
                break;
            case Characters.CharsGenres.Scifi:
                characters.Scifi();
                bought = true;
                break;


        }
    }


}
