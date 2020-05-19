using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quotes : MonoBehaviour {

    public GameObject speech;
    public Text quote;


    public void Bubble()
    {
        StartCoroutine(RemoveAfterSeconds(5));
    }

  

    public IEnumerator RemoveAfterSeconds(int seconds)
    {
        speech.gameObject.SetActive(true);
        Debug.Log("show");
        yield return new WaitForSeconds(seconds);
        speech.gameObject.SetActive(false);
        Debug.Log("hide");
    }



    public void Generate()
    {

        string[] quotes = new string[]
        {
            "“Read a thousand books, and your words will flow like a river.”― Lisa See",
            "“The first draft is just you telling yourself the story.”― Terry Pratchett",
            "“You can always edit a bad page. You can’t edit a blank page.”― Jodi Picoult",
            "“Start writing, no matter what. The water does not flow until the faucet is turned on.”— Louis L’Amour",
            "“Don’t tell me the moon is shining; show me the glint of light on broken glass.”― Anton Chekhov",
            "“There is no greater agony than bearing an untold story inside you.”― Maya Angelou",
            " “If the book is true, it will find an audience that is meant to read it.”— Wally Lamb",
            "I think all writing is a disease. You can’t stop it.”— William Carlos Williams",
            "“I can shake off everything as I write; my sorrows disappear, my courage is reborn.”— Anne Frank",
            "A professional writer is an amateur who didn’t quit.”— Richard Bach"


        };
        string generate = quotes[Random.Range(0, quotes.Length)];



        quote.text = generate;
    }
}
