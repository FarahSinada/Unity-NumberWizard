using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    public int MaxGuessesAllowed = 5;
    public Text text;

    // Use this for initialization
    void Start () {

        StartGame();
        text.text = guess.ToString();
	}

    void StartGame()
    {

        max = 1000;
        min = 1;
        NextGuess();
    }
    
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();
        MaxGuessesAllowed -= 1;
        if(MaxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }

}
