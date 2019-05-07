using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{

    public Dropdown SizeDropdown;
    public Slider SpeedSlider;

    public Toggle trackThing;
    public string size;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (SizeDropdown.value)
        {
            case 1:
                Debug.Log("Selection: Small");
                size = "Small";
                break;
            case 2:
                Debug.Log("Selection: Normal");
                size = "Normal";
                break;
            case 3:
                Debug.Log("Selection: Big");
                size = "Big";
                break;
            default:
                Debug.Log("No Selection Made");
                size = "Normal";
                break;
        }
    }
    
    public void nextScene()
    {
        GameScript.mySpeed = SpeedSlider.value;
        GameScript.mySize = size;
        MidScript.easterEggValue = trackThing.isOn;
        SceneManager.LoadScene("2HighScores");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}