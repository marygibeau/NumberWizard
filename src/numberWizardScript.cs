using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NumberWizard : MonoBehaviour {
    public Text text;
    private int max;
    private int min;
    private int guess;
    private int maxguesses = 10;

    // Use this for initialization
    void Start () {
        StartGame();
    }

    void StartGame(){
        max = 1000;
        min = 1;
        NextGuess();
    }

    public void Higher(){
        min = guess;
        NextGuess();
    }

    public void Lower(){
        max = guess;
        NextGuess();
    }

    void NextGuess(){
        guess = Random.Range(min, max+1);
        text.text = guess.ToString() + "?";
        if(maxguesses <= 0){
            Application.LoadLevel("PlayerWin");
        }
        maxguesses--;
    }
}
