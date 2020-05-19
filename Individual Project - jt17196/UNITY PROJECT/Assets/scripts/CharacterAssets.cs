using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAssets : MonoBehaviour {

    public static CharacterAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Transform pfCharWorld;


    public Sprite None;
    public Sprite Fantasy;
    public Sprite Romance;
    public Sprite Comedy;
    public Sprite Horror;
    public Sprite Action;
    public Sprite Mystery;
    public Sprite Dystopia;
    public Sprite Music;
    public Sprite Western;
    public Sprite Scifi;
}
