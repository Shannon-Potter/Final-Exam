using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MidScript : MonoBehaviour
{
    public Text playerNameInput;
    public static string playerName;
    public static bool easterEggValue = false;
    public GameObject easterEgg;

    // Start is called before the first frame update
    private void Start()
    {
        if (!easterEggValue)
            Destroy(easterEgg);
    }

    public void nextScene()
    {
        if (playerNameInput.text.CompareTo("") == 0)
            playerName = "Anonymous";
        else
            playerName = playerNameInput.text;

        FileScript.updateFlag = true;

        SceneManager.LoadScene("3Game");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
