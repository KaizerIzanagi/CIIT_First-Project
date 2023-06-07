using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGameManager : MonoBehaviour
{
    // Look man I just want to make a text based horror game about Dead Hard
    public float healthValue, willpowerValue;
    // Oh my god this will kill my PC's storage space
    public TextMeshProUGUI hpTextValue, willpowerTextValue, storyTextValue;
    // Now, DO IT MY DOOD! WRITE!!!
    public string storyText;
    // Game Object to make "Proofs" go "Poof"!
    public GameObject level1_Choices, TitleScreen, GameProper;

    // Start is called before the first frame update
    void Start()
    {
        GameProper.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        hpTextValue.text = healthValue.ToString();
        willpowerTextValue.text = willpowerValue.ToString();
        storyTextValue.text = storyText.ToString();
    }

    public void ScreamForHelp()
    {
        // "HP -= x" is the same as "HP = HP - x", but shorter
        healthValue -= 33;
        willpowerValue -= 33;
        storyText = "Your Scream attracted the killer to your location, and now the chase is on! You see a Pallet, a Window, and an Open Field, where do you run to?";
    }

    public void LookAround()
    {
        storyText = "You look around and see a Generator, a Chest, and an Open Field. What do you do?";
    }
    

    public void Panic()
    {
        healthValue -= 100;
        willpowerValue -= 100;
        storyText = "Your Panic attracted the killer to your location, and you have been sacrificed immediately! Try again?";
        level1_Choices.SetActive(false);
 
    }

    public void StartButton()
    {
        GameProper.SetActive(true);
        TitleScreen.SetActive(false);
        healthValue = 100;
        willpowerValue = 100;
        storyText = "Ugh... where am I?";
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    
    
}
