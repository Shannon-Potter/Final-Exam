using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public static string mySize;
    public static float mySpeed;
    public Text timerText;
    float timer = 61f;
    public static int finalTime;
    public Text speedDisplay;
    public Text sizeDisplay;

    // Start is called before the first frame update
    void Start()
    {
        speedDisplay.text = mySpeed.ToString();
        sizeDisplay.text = mySize.ToString();

    }

    private void Update()
    {     
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
        timerText.text = 0.ToString();
        }
        else
            timerText.text = ((int)timer).ToString();
        
    }

    public void doneWithGame()
    {
        finalTime = (int)timer;
        SceneManager.LoadScene("4Exit");
    }
}