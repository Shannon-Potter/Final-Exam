using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{

    public Text gameStatsDisplay;
    // Start is called before the first frame update
    void Start()
    {
        gameStatsDisplay.text = "Score: " + ScoreKeeper.newScore + "\nLives: " + LivesTracker.lives + "\nTime: " + GameScript.finalTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void nextScene()
    {
        ScoreKeeper.newScore = 0;
        LivesTracker.lives = 9;
        SceneManager.LoadScene("3Game");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
